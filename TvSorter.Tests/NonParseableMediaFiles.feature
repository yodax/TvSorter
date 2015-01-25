Feature: Moving a release with no parseable media files

Scenario: Move media for bad media good directory
	Given a release in c:\incoming\Show.S01E01.HDTV-NOGROUP
	And a tv destination of c:\tv\{ShowName}\{SeasonEpisode}\{ReleaseName}.{Extension}
	And a directory structure
	| Item        | Type      |
	| c:\tv       | Directory |
	| c:\incoming | Directory |
	And the files in the release directory
	| Item                         |
	| Blaat.mkv |
	When we request a move
	Then the directory structure should contain
	| Item                                           |
	| c:\tv\Show\S01E01\Show.S01E01.HDTV-NOGROUP.mkv |
	And the directory c:\incoming should be empty

Scenario: Move media for bad media bad directory
	Given a release in c:\incoming\Release
	And a tv destination of c:\tv\{ShowName}\{SeasonEpisode}\{ReleaseName}.{Extension}
	And a directory structure
	| Item        | Type      |
	| c:\tv       | Directory |
	| c:\incoming | Directory |
	And the files in the release directory
	| Item                         |
	| Blaat.mkv |
	When we request a move
	Then the directory structure should contain
	| Item                          |
	| c:\incoming\Release\Blaat.mkv |
	And the output should be
         """
         Can't parse release name!
         """

Scenario: Show info for bad media good directory
	Given a release in c:\incoming\Show.S01E01.HDTV-NOGROUP
	And a tv destination of c:\tv\{ShowName}\{SeasonEpisode}\{ReleaseName}.{Extension}
	And a directory structure
	| Item        | Type      |
	| c:\tv       | Directory |
	| c:\incoming | Directory |
	And the files in the release directory
	| Item                         |
	| Blaat.mkv |
	When we request a show name from the release directory
	Then the requested show name should be Show S01E01 HDTV

Scenario: Show info for bad media bad directory
	Given a release in c:\incoming\Release
	And a tv destination of c:\tv\{ShowName}\{SeasonEpisode}\{ReleaseName}.{Extension}
	And a directory structure
	| Item        | Type      |
	| c:\tv       | Directory |
	| c:\incoming | Directory |
	And the files in the release directory
	| Item                         |
	| Blaat.mkv |
	When we request a show name from the release directory
	Then the output should be
         """
         Can't parse release name!
         """
