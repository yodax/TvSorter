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
	And the release should be parseable

Examples:
| Input scene name                                                                    | Clean scene name                                            | Show name                   | Season | Episode | Group   | Quality                    |
| Show.S01E11.720p.HDTV.x264-GROUP                                                    | Show.S01E11.720p.HDTV.x264-GROUP                            | Show                        | 1      | 11      | GROUP   | 720p.HDTV.x264             |
| Show.1x11.HDTV.x264-GROUP                                                           | Show.S01E11.HDTV.x264-GROUP                                 | Show                        | 1      | 11      | GROUP   | HDTV.x264                  |
| Show.S01E11.HDTV.x264-GROUP                                                         | Show.S01E11.HDTV.x264-GROUP                                 | Show                        | 1      | 11      | GROUP   | HDTV.x264                  |
| Show.S01E11.HDTV.XVID-GROUP                                                         | Show.S01E11.HDTV.XviD-GROUP                                 | Show                        | 1      | 11      | GROUP   | HDTV.XviD                  |
| Show.Part.2.720p.HDTV.x264-GROUP                                                    | Show.S01E02.720p.HDTV.x264-GROUP                            | Show                        | 1      | 2       | GROUP   | 720p.HDTV.x264             |
| Show S06E01 720p WEB-DL DD5.1 H.264                                                 | Show.S06E01.720p.WEB-DL.DD5.1.H.264-NOGROUP                 | Show                        | 6      | 1       | NOGROUP | 720p.WEB-DL.DD5.1.H.264    |
| Show S06E01 720p WEB-DL DD5.1 H.264-GROUP                                           | Show.S06E01.720p.WEB-DL.DD5.1.H.264-GROUP                   | Show                        | 6      | 1       | GROUP   | 720p.WEB-DL.DD5.1.H.264    |
| Constantine.S01E09.The.Saint.Of.Last.Resort.Part.2.1080p.WEB-DL.DD5.1.H.264-ECI     | Constantine.S01E09.1080p.WEB-DL.DD5.1.H.264-ECI             | Constantine                 | 1      | 9       | ECI     | 1080p.WEB-DL.DD5.1.H.264   |
| Melissa.&.Joey.S04E04.The.Day.After.1080p.WEB-DL.DD5.1.H.264-SA89                   | Melissa.and.Joey.S04E04.1080p.WEB-DL.DD5.1.H.264-SA89       | Melissa and Joey            | 4      | 4       | SA89    | 1080p.WEB-DL.DD5.1.H.264   |
| Dokter Tinus (2014) S03E12 720p HDTV NL Audio SAM TBS                               | Dokter.Tinus.2014.S03E12.720p.HDTV.NL.AUDIO.SAM.TBS-NOGROUP | Dokter Tinus 2014           | 3      | 12      | NOGROUP | 720p.HDTV.NL.AUDIO.SAM.TBS |
| How To Get Away With Murder - S01E01 [BullCrap] [1080p] WEB-DL [Subtitles Included] | How.To.Get.Away.With.Murder.S01E01.1080p.WEB-DL-NOGROUP     | How To Get Away With Murder | 1      | 1       | NOGROUP | 1080p.WEB-DL               |
| moordvrouw.404.720p-DHn                                                             | Moordvrouw.S04E04.720p-DHN                                  | Moordvrouw                  | 4      | 4       | DHN     | 720p                       |

Scenario Template: Set of show names to be formatted
	Given an input of <inputReleaseName>.S01E01.720p.HDTV-GROUP
	When clean up the release name
	Then the show name should be <expectedShowName>

	Examples: 
	| inputReleaseName         | expectedShowName         |
	| The.Bad.Show             | The Bad Show             |
	| Show.with.multiple.names | Show With Multiple Names |
	| Show.&.The.Showing       | Show and the Showing     |

Scenario Template: Empty show name
	Given an input of <ShowName>
	When clean up the release name
	Then the release should be non parseable

	Examples:
	| ShowName                                       |
	| UNPARSEABLE                                    |
	| Season 6 - Episode 5 - The Hurt Locker, Part 2 |

Scenario Template: Quality strings should be cleaned up
	Given an input of <Input scene name>
	When clean up the release name
	Then the quality should be <Quality>

Examples:
| Input scene name                 | Quality        |
| Show.S01E01.HDTV.XVID-GROUP      | HDTV.XviD      |
| Show.S01E01.720p.HDTV.x264-GROUP | 720p.HDTV.x264 |
| Show.S01E01.DVDRIP-GROUP         | DVDRip         |
| Show.S01E01.BLURAY-GROUP         | BluRay         |

Scenario Template: Quality strings should only start with allowed words
	Given an input of Show.S01E01.<Input quality>-GROUP
	When clean up the release name
	Then the quality should be <Quality>

Examples:
| Input quality                 | Quality                       |
|                               |                               |
| convert                       | CONVERT                       |
| native                        | NATIVE                        |
| proper                        | PROPER                        |
| real                          | REAL                          |
| repack                        | REPACK                        |
| dirfix                        | DIRFIX                        |
| nfofix                        | NFOFIX                        |
| read.nfo                      | READ.NFO                      |
| internal                      | INTERNAL                      |
| subbed                        | SUBBED                        |
| dubbed                        | DUBBED                        |
| 1080p                         | 1080p                         |
| 720p                          | 720p                          |
| 480p                          | 480p                          |
| hdtv                          | HDTV                          |
| dsr                           | DSR                           |
| ws                            | WS                            |
| bdrip                         | BDRIP                         |
| bluray                        | BluRay                        |
| dvdrip                        | DVDRip                        |
| pdtv                          | PDTV                          |
| x264                          | x264                          |
| H.264                         | H.264                         |
| REAL.1080p.WEB-DL.DD5.1.H.264 | REAL.1080p.WEB-DL.DD5.1.H.264 |

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

