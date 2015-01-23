Feature: When checking command line arguments

Scenario Template: Destination and source ar both provided
	Given the commandline parameters <Arguments>
	Then the configuration setting destination is destination
	And the configuration setting release is release

Examples:
| Arguments                                       |
| -d "destination" -r "release"                   |
| -r "release" -d "destination"                   |
| --release "release" --destination "destination" |
