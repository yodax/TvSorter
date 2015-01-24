Feature: Moving a release to its destination

Background: 
	Given a release in c:\incoming\ReleaseDir
	And a tv destination of c:\tv\{ShowName}\{SeasonEpisode}\{ReleaseName}.{Extension}
	And a directory structure
	| Item        | Type      |
	| c:\tv       | Directory |
	| c:\incoming | Directory |
    	
Scenario: Just one file to be moved
	Given the files in the release directory
	| Item                         |
	| Show.S01E01.HDTV-NOGROUP.mkv |
	When we request a move
	Then the directory structure should contain
	| Item                                           |
	| c:\tv\Show\S01E01\Show.S01E01.HDTV-NOGROUP.mkv |
	And the directory c:\incoming should be empty

Scenario: An existing file is present
	Given the files in the release directory
	| Item                         |
	| Show.S01E01.HDTV-NOGROUP.mkv |
	And a directory structure
	| Item                                           | Type |
	| c:\tv\Show\S01E01\Show.S01E01.HDTV-NOGROUP.mkv | File |
	When we request a move
	Then the directory structure should contain
	| Item                                             |
	| c:\tv\Show\S01E01\Show.S01E01.HDTV-NOGROUP.mkv   |
	| c:\tv\Show\S01E01\Show.S01E01.HDTV-NOGROUP.1.mkv |
	And the directory c:\incoming should be empty

Scenario: Two existing files are present
	Given the files in the release directory
	| Item                         |
	| Show.S01E01.HDTV-NOGROUP.mkv |
	And a directory structure
	| Item                                             | Type |
	| c:\tv\Show\S01E01\Show.S01E01.HDTV-NOGROUP.mkv   | File |
	| c:\tv\Show\S01E01\Show.S01E01.HDTV-NOGROUP.1.mkv | File |

	When we request a move
	Then the directory structure should contain
	| Item                                             |
	| c:\tv\Show\S01E01\Show.S01E01.HDTV-NOGROUP.mkv   |
	| c:\tv\Show\S01E01\Show.S01E01.HDTV-NOGROUP.1.mkv |
	| c:\tv\Show\S01E01\Show.S01E01.HDTV-NOGROUP.2.mkv |
	And the directory c:\incoming should be empty

Scenario: A seperate nfo file with a different name should be renamed
	Given the files in the release directory
	| Item                         |
	| Show.S01E01.HDTV-NOGROUP.mkv |
	| info.nfo                     |
	When we request a move
	Then the directory structure should contain
	| Item                                           |
	| c:\tv\Show\S01E01\Show.S01E01.HDTV-NOGROUP.mkv |
	| c:\tv\Show\S01E01\Show.S01E01.HDTV-NOGROUP.nfo |
	And the directory c:\incoming should be empty

Scenario: A seperate subtitle file with a different name should be renamed
	Given the files in the release directory
	| Item                         |
	| Show.S01E01.HDTV-NOGROUP.mkv |
	| subtitle.srt                     |
	When we request a move
	Then the directory structure should contain
	| Item                                           |
	| c:\tv\Show\S01E01\Show.S01E01.HDTV-NOGROUP.mkv |
	| c:\tv\Show\S01E01\Show.S01E01.HDTV-NOGROUP.srt |
	And the directory c:\incoming should be empty

Scenario: A mp4 file should be moved
	Given the files in the release directory
	| Item                         | 
	| Show.S01E01.HDTV-NOGROUP.mp4 | 
	When we request a move
	Then the directory structure should contain
	| Item                                           |
	| c:\tv\Show\S01E01\Show.S01E01.HDTV-NOGROUP.mp4 |
	And the directory c:\incoming should be empty

Scenario: A avi file should be moved
	Given the files in the release directory
	| Item                         |
	| Show.S01E01.HDTV-NOGROUP.avi |
	When we request a move
	Then the directory structure should contain
	| Item                                           |
	| c:\tv\Show\S01E01\Show.S01E01.HDTV-NOGROUP.avi |
	And the directory c:\incoming should be empty

Scenario: More than one media file detected
	Given the files in the release directory
	| Item                         |
	| Show.S01E01.HDTV-NOGROUP.mkv |
	| Show.S01E02.HDTV-NOGROUP.mkv |
	When we request a move
	Then the release should not have been removed
	And the output should be
	"""
	More than one media file detected in c:\incoming\ReleaseDir
	"""

Scenario: No files are detected

	If no files are detected a message should be shown and the original directory should be preserved

	Given a directory structure
	| Item                   | Type      |
	| c:\incoming\ReleaseDir | Directory |
	When we request a move
	Then the release should not have been removed
	And the output should be
	"""
	No media files detected in c:\incoming\ReleaseDir
	"""

Scenario Template: Not all file types should be moved
	Given a file with extenstion <AllowedExtension>
	And a file with a non allowed extension <NotAllowedExtension>
	When we request a move
	Then the directory structure should not contain a file with <NotAllowedExtension>
	And the directory structure should contain a file <AllowedExtension>
	And the directory c:\incoming should be empty

	Examples: 
	| AllowedExtension | NotAllowedExtension |
	| mkv              | rar                 |
	| mp4              | srr                 |
	| nfo              | xyz                 |
	| srt              | xyz                 |
	| idx              | xyz                 |
	| sub              | xyz                 |
	| avi              | txt                 |
	| mkv              | url                 |

Scenario: A succesfull move with output
	Given the files in the release directory
	| Item                         |
	| Show.S01E01.HDTV-NOGROUP.mkv |
	| subtitle.srt                 |
	| url.txt                      |
	And an info file in the release directory
"""
Hello world!
This is a multiline info file :)
"""
	When we request a move
	Then the directory structure should contain
	| Item                                           |
	| c:\tv\Show\S01E01\Show.S01E01.HDTV-NOGROUP.mkv |
	| c:\tv\Show\S01E01\Show.S01E01.HDTV-NOGROUP.srt |
	| c:\tv\Show\S01E01\Show.S01E01.HDTV-NOGROUP.nfo |
	And the directory c:\incoming should be empty
	And the output should be
"""
Using filename: Show.S01E01.HDTV-NOGROUP

Moving files from: c:\incoming\ReleaseDir
        directory: c:\tv\Show\S01E01

Moving:

	$ Show.S01E01.HDTV-NOGROUP.mkv => Show.S01E01.HDTV-NOGROUP.mkv
	$ subtitle.srt                 => Show.S01E01.HDTV-NOGROUP.srt
	$ info.nfo                     => Show.S01E01.HDTV-NOGROUP.nfo

Not moving:

	$ url.txt

NFO file:

	$ Hello world!
	$ This is a multiline info file :)
"""       

Scenario: A succesfull move without an nfo file should not have the nfo section in its output
	Given the files in the release directory
	| Item                         |
	| Show.S01E01.HDTV-NOGROUP.mkv |
	| subtitle.srt                 |
	| url.txt                      |
	When we request a move
	Then the directory structure should contain
	| Item                                           |
	| c:\tv\Show\S01E01\Show.S01E01.HDTV-NOGROUP.mkv |
	| c:\tv\Show\S01E01\Show.S01E01.HDTV-NOGROUP.srt |
	And the directory c:\incoming should be empty    
	And the output should not contain NFO file:  

Scenario: A succesfull move without an extra file should not have the not moved section in its output
	Given the files in the release directory
	| Item                         |
	| Show.S01E01.HDTV-NOGROUP.mkv |
	| subtitle.srt                 |
	When we request a move
	Then the directory structure should contain
	| Item                                           |
	| c:\tv\Show\S01E01\Show.S01E01.HDTV-NOGROUP.mkv |
	| c:\tv\Show\S01E01\Show.S01E01.HDTV-NOGROUP.srt |
	And the directory c:\incoming should be empty    
	And the output should not contain Not moving:         
	                                                               

