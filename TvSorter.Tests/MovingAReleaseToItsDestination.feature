Feature: Moving a release to its destination

Background: 
	Given a release in c:\incoming\ReleaseDir
	And a tv destination of c:\tv\{ShowName}\{SeasonEpisode}\{ReleaseName}.{Extension}
    	
Scenario: Just one file to be moved
	Given a directory structure
	| Item                                                | Type      |
	| c:\tv                                               | Directory |
	| c:\incoming\ReleaseDir\Show.S01E01.HDTV-NOGROUP.mkv | File      |
	When we request a move
	Then the directory structure should contain
	| Item                                           |
	| c:\tv\Show\S01E01\Show.S01E01.HDTV-NOGROUP.mkv |
	And the directory c:\incoming should be empty

Scenario: A seperate nfo file with a different name should be renamed
	Given a directory structure
	| Item                                                | Type      |
	| c:\tv                                               | Directory |
	| c:\incoming\ReleaseDir\Show.S01E01.HDTV-NOGROUP.mkv | File      |
	| c:\incoming\ReleaseDir\info.nfo                     | File      |
	When we request a move
	Then the directory structure should contain
	| Item                                           |
	| c:\tv\Show\S01E01\Show.S01E01.HDTV-NOGROUP.mkv |
	| c:\tv\Show\S01E01\Show.S01E01.HDTV-NOGROUP.nfo |
	And the directory c:\incoming should be empty

Scenario: A mp4 file should be moved
	Given a directory structure
	| Item                                                | Type      |
	| c:\tv                                               | Directory |
	| c:\incoming\ReleaseDir\Show.S01E01.HDTV-NOGROUP.mp4 | File      |
	When we request a move
	Then the directory structure should contain
	| Item                                           |
	| c:\tv\Show\S01E01\Show.S01E01.HDTV-NOGROUP.mp4 |
	And the directory c:\incoming should be empty

Scenario: A avi file should be moved
	Given a directory structure
	| Item                                                | Type      |
	| c:\tv                                               | Directory |
	| c:\incoming\ReleaseDir\Show.S01E01.HDTV-NOGROUP.avi | File      |
	When we request a move
	Then the directory structure should contain
	| Item                                           |
	| c:\tv\Show\S01E01\Show.S01E01.HDTV-NOGROUP.avi |
	And the directory c:\incoming should be empty

Scenario: No files are detected

	If no files are detected a message should be shown and the original directory should be preserved

	Given a directory structure
	| Item                   | Type      |
	| c:\tv                  | Directory |
	| c:\incoming\ReleaseDir | Directory |
	When we request a move
	Then the directory structure should contain
	| Item                   | Type      |
	| c:\incoming\ReleaseDir | Directory |
	And the output should be
	| Line                                              |
	| No media files detected in c:\incoming\ReleaseDir |
