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

Scenario Template: Roman numerals should be converted to decimal
	Given an input of <Input scene name>
	When clean up the release name
	Then the season should be <Season>
	And the episode should be <Episode>

Examples:
| Input scene name                    | Season | Episode |
| Show.Part.I.720p.HDTV.x264-GROUP    | 1      | 1       |
| Show.Part.II.720p.HDTV.x264-GROUP   | 1      | 2       |
| Show.Part.III.720p.HDTV.x264-GROUP  | 1      | 3       |
| Show.Part.IV.720p.HDTV.x264-GROUP   | 1      | 4       |
| Show.Part.V.720p.HDTV.x264-GROUP    | 1      | 5       |
| Show.Part.VI.720p.HDTV.x264-GROUP   | 1      | 6       |
| Show.Part.VII.720p.HDTV.x264-GROUP  | 1      | 7       |
| Show.Part.VIII.720p.HDTV.x264-GROUP | 1      | 8       |
| Show.Part.IX.720p.HDTV.x264-GROUP   | 1      | 9       |
| Show.Part.X.720p.HDTV.x264-GROUP    | 1      | 10      |
| Show.Part.XI.720p.HDTV.x264-GROUP   | 1      | 11      |
| Show.Part.XII.720p.HDTV.x264-GROUP  | 1      | 12      |
| Show.Part.XIII.720p.HDTV.x264-GROUP | 1      | 13      |

