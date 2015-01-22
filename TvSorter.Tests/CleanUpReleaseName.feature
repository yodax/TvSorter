Feature: Cleanup release name to match scene rules

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
| Input scene name                                     | Clean scene name                                     | Show name                | Season | Episode | Group   | Quality                 |
| Show.S01E11.720p.HDTV.x264-GROUP                     | Show.S01E11.720p.HDTV.x264-GROUP                     | Show                     | 1      | 11      | GROUP   | 720p.HDTV.x264          |
| Show.S01E11.HDTV.x264-GROUP                          | Show.S01E11.HDTV.x264-GROUP                          | Show                     | 1      | 11      | GROUP   | HDTV.x264               |
| Show.S01E11.HDTV.XVID-GROUP                          | Show.S01E11.HDTV.XviD-GROUP                          | Show                     | 1      | 11      | GROUP   | HDTV.XviD               |
| Show.Part.2.720p.HDTV.x264-GROUP                     | Show.S01E02.720p.HDTV.x264-GROUP                     | Show                     | 1      | 2       | GROUP   | 720p.HDTV.x264          |
| Show S06E01 720p WEB-DL DD5.1 H.264                  | Show.S06E01.720p.WEB-DL.DD5.1.H.264-NOGROUP          | Show                     | 6      | 1       | NOGROUP | 720p.WEB-DL.DD5.1.H.264 |
| Show S06E01 720p WEB-DL DD5.1 H.264-GROUP            | Show.S06E01.720p.WEB-DL.DD5.1.H.264-GROUP            | Show                     | 6      | 1       | GROUP   | 720p.WEB-DL.DD5.1.H.264 |
| Show.with.multiple.names.S01E11.720p.HDTV.x264-GROUP | Show.With.Multiple.Names.S01E11.720p.HDTV.x264-GROUP | Show With Multiple Names | 1      | 11      | GROUP   | 720p.HDTV.x264          |
