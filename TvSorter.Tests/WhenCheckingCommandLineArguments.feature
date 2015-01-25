Feature: When checking command line arguments

   If the arguments supplied are in correct a message should be show:

   | Line                                                              |
   | Please add a configuration file called <TvSorter.ini> containing: |
   |                                                                   |
   | destination=<Path to destination>                                 |
   |                                                                   |
   | OR                                                                |
   |                                                                   |
   | Supply the following arguments (-r is mandatory):                 |
   |                                                                   |
   | -r OR --release <Path to release>                                 |
   | -d OR --destination <Path to destination>                         |
   |                                                                   |
   | <Path to destination> can be formatted like:                      |
   | c:\tv\{ShowName}\{SeasonEpisode}\{ReleaseName}.{Extension}        |

Scenario Template: Destination and source ar both provided
	Given the commandline parameters <Arguments>
	Then the configuration setting destination is <Destination>
	And the configuration setting release is <Release>
	And the configuration setting to check for a show name is <Check for show name>
	And the configuration should be marked as <Valid>
Examples:
| Arguments                                       | Destination | Release | Check for show name | Valid   |
| -d "destination" -r "release"                   | destination | release | not set             | valid   |
| -r "release" -d "destination"                   | destination | release | not set             | valid   |
| --release "release" --destination "destination" | destination | release | not set             | valid   |
| --showName --release "release"                  |             | release | set                 | valid   |
| --showName                                      |             |         | set                 | invalid |


Scenario: When release is supplied as an argument but no configuration file is present
Given the commandline parameters --release c:\release
And no configuration file is present
Then the output should be a statment defining the usage of the program
And the configuration should be marked as invalid

Scenario: When destination is supplied as an argument but no configuration file is present
Given the commandline parameters --destination c:\destination
And no configuration file is present
Then the output should be a statment defining the usage of the program
And the configuration should be marked as invalid

Scenario: When no command line arguments are supplied and no configuration file is present
Given No command line parameters
And no configuration file is present
Then the output should be a statment defining the usage of the program
And the configuration should be marked as invalid

Scenario: When no destination is given but it is present in the configuration file
Given the commandline parameters --release c:\release
And the configuration file
"""
destination=c:\destination
"""
Then the configuration setting destination is c:\destination
And the configuration should be marked as valid

Scenario: When destination is supplied from the commandline and from the configfile
Given the commandline parameters --destination c:\destinationFromCommandLine --release c:\release
And the configuration file
"""
destination=c:\destinationFromConfig
"""
Then the configuration setting destination is c:\destinationFromCommandLine
And the configuration should be marked as valid

Scenario: When an incorrect config is supplied
Given the commandline parameters --release c:\release
And the configuration file
"""
notvalid
"""
Then the configuration should be marked as invalid

Scenario: When an incorrect config name is supplied
Given the commandline parameters --release c:\release
And the configuration file
"""
notvalid=c:\
"""
Then the configuration should be marked as invalid







