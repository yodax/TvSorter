Feature: When requesting a show name

Background: 
	Given a release in c:\incoming\ReleaseDir
	And a tv destination of c:\tv\{ShowName}\{SeasonEpisode}\{ReleaseName}.{Extension}
	And a directory structure
	| Item        | Type      |
	| c:\tv       | Directory |
	| c:\incoming | Directory |
    	
Scenario: Just one file in the release
	Given the files in the release directory
	| Item                         |
	| Show.S01E01.HDTV-NOGROUP.mkv |
	When we request a show name from the release directory
	Then the requested show name should be Show S01E01 HDTV

Scenario: More complex filename in the release
	Given the files in the release directory
	| Item                         |
	| Show.and.Show.S01E01.720p.HDTV-NOGROUP.mkv |
	When we request a show name from the release directory
	Then the requested show name should be Show and Show S01E01 720p HDTV

Scenario: No valid files in the release
	Given a directory structure
	| Item                   | Type      |
	| c:\incoming\ReleaseDir | Directory |
	When we request a show name from the release directory
	Then the output should be
	"""
	No media files detected in c:\incoming\ReleaseDir
	"""

Scenario: More than one media file detected
	Given the files in the release directory
	| Item                         |
	| Show.S01E01.HDTV-NOGROUP.mkv |
	| Show.S01E02.HDTV-NOGROUP.mkv |
	When we request a show name from the release directory
	Then the output should be
	"""
	More than one media file detected in c:\incoming\ReleaseDir
	"""

Scenario: No release directory
	When we request a show name from the release directory
	Then the output should be
	"""
	Release directory doesn't exist c:\incoming\ReleaseDir
	"""

	
