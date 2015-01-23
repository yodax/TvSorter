Feature: Moving a release to its destination

Background: 
	Given a tv destination of c:\tv\{ShowName}\{SeasonEpisode}\{ReleaseName}.{Extension}

Scenario: Just one file to be moved
	Given a release in c:\incoming\Show.S01E01.720p.HDTV-NOGROUP
	And a directory structure
	| Item                                                                        | Type      |
	| c:\tv                                                                       | Directory |
	| c:\incoming\Show.S01E01.720p.HDTV-NOGROUP\Show.S01E01.720p.HDTV-NOGROUP.mkv | File      |
	When we request a move
	Then the directory structure should contain
	| Item                                                |
	| c:\tv\Show\S01E01\Show.S01E01.720p.HDTV-NOGROUP.mkv |
	And the directory c:\incoming should be empty

Scenario: A seperate nfo file with a different name should be renamed
	Given a release in c:\incoming\Show.S01E01.720p.HDTV-NOGROUP
	And a directory structure
	| Item                                                                        | Type      |
	| c:\tv                                                                       | Directory |
	| c:\incoming\Show.S01E01.720p.HDTV-NOGROUP\Show.S01E01.720p.HDTV-NOGROUP.mkv | File      |
	| c:\incoming\Show.S01E01.720p.HDTV-NOGROUP\info.nfo                          | File      |
	When we request a move
	Then the directory structure should contain
	| Item                                                |
	| c:\tv\Show\S01E01\Show.S01E01.720p.HDTV-NOGROUP.mkv |
	| c:\tv\Show\S01E01\Show.S01E01.720p.HDTV-NOGROUP.nfo |
	And the directory c:\incoming should be empty

Scenario: A mp4 file should be moved
	Given a release in c:\incoming\Show.S01E01.720p.HDTV-NOGROUP
	And a directory structure
	| Item                                                                        | Type      |
	| c:\tv                                                                       | Directory |
	| c:\incoming\Show.S01E01.720p.HDTV-NOGROUP\Show.S01E01.720p.HDTV-NOGROUP.mp4 | File      |
	When we request a move
	Then the directory structure should contain
	| Item                                                |
	| c:\tv\Show\S01E01\Show.S01E01.720p.HDTV-NOGROUP.mp4 |
	And the directory c:\incoming should be empty

Scenario: A avi file should be moved
	Given a release in c:\incoming\Show.S01E01.720p.HDTV-NOGROUP
	And a directory structure
	| Item                                                                        | Type      |
	| c:\tv                                                                       | Directory |
	| c:\incoming\Show.S01E01.720p.HDTV-NOGROUP\Show.S01E01.720p.HDTV-NOGROUP.avi | File      |
	When we request a move
	Then the directory structure should contain
	| Item                                                |
	| c:\tv\Show\S01E01\Show.S01E01.720p.HDTV-NOGROUP.avi |
	And the directory c:\incoming should be empty