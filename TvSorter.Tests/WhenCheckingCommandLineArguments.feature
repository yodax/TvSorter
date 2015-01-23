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

Examples:
| Arguments                                       | Destination | Release |
| -d "destination" -r "release"                   | destination | release |
| -r "release" -d "destination"                   | destination | release |
| --release "release" --destination "destination" | destination | release |

Scenario: When release is supplied as an argument but no configuration file is present
Given the commandline parameters --release c:\release
And no configuration file is present
Then the output should be a statment defining the usage of the program

Scenario: When destination is supplied as an argument but no configuration file is present
Given the commandline parameters --destination c:\destination
And no configuration file is present
Then the output should be a statment defining the usage of the program

Scenario: When no command line arguments are supplied and no configuration file is present
Given No command line parameters
And no configuration file is present
Then the output should be a statment defining the usage of the program

Scenario: When no destination is given but it is present in the configuration file
Given the commandline parameters --release c:\release
And the configuration file
"""
destination=c:\destination
"""
Then the configuration setting destination is c:\destination

Scenario: When destination is supplied from the commandline and from the configfile
Given the commandline parameters --destination c:\destinationFromCommandLine --release c:\release
And the configuration file
"""
destination=c:\destinationFromConfig
"""
Then the configuration setting destination is c:\destinationFromCommandLine






