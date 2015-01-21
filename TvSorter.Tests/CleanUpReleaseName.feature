﻿Feature: CleanUpReleaseName

Input release names need to be aligned with scene rules

Scenario Template: Set of example cleanups
	Given an input of <Input scene name>
	When clean up the release name
	Then the new name should be <Clean scene name>
	And the show name should be <Show name>
	And the season should be <Season>
	And the episode should be <Episode>
	And the release group should be <Group>
	And the quality should be <Quality>

Examples:
| Input scene name                       | Clean scene name                       | Show name | Season | Episode | Group   | Quality        |
| Cristela.S01E11.720p.HDTV.x264-KILLERS | Cristela.S01E11.720p.HDTV.x264-KILLERS | Cristela  | 1      | 11      | KILLERS | 720p.HDTV.x264 | 
#| Cristela.S01E11.720p.HDTV.x264-killers | Cristela.S01E11.720p.HDTV.x264-KILLERS |           |