﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.34014
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace TvSorter.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class WhenCheckingCommandLineArgumentsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "WhenCheckingCommandLineArguments.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "When checking command line arguments", @"
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
 | c:\tv\{ShowName}\{SeasonEpisode}\{ReleaseName}.{Extension}        |", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "When checking command line arguments")))
            {
                TvSorter.Tests.WhenCheckingCommandLineArgumentsFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void DestinationAndSourceArBothProvided(string arguments, string destination, string release, string checkForShowName, string valid, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Destination and source ar both provided", exampleTags);
#line 20
this.ScenarioSetup(scenarioInfo);
#line 21
 testRunner.Given(string.Format("the commandline parameters {0}", arguments), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 22
 testRunner.Then(string.Format("the configuration setting destination is {0}", destination), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
 testRunner.And(string.Format("the configuration setting release is {0}", release), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.And(string.Format("the configuration setting to check for a show name is {0}", checkForShowName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.And(string.Format("the configuration should be marked as {0}", valid), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Destination and source ar both provided")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "When checking command line arguments")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "-d \"destination\" -r \"release\"")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Arguments", "-d \"destination\" -r \"release\"")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Destination", "destination")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Release", "release")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Check for show name", "not set")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Valid", "valid")]
        public virtual void DestinationAndSourceArBothProvided_DDestination_RRelease()
        {
            this.DestinationAndSourceArBothProvided("-d \"destination\" -r \"release\"", "destination", "release", "not set", "valid", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Destination and source ar both provided")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "When checking command line arguments")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "-r \"release\" -d \"destination\"")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Arguments", "-r \"release\" -d \"destination\"")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Destination", "destination")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Release", "release")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Check for show name", "not set")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Valid", "valid")]
        public virtual void DestinationAndSourceArBothProvided_RRelease_DDestination()
        {
            this.DestinationAndSourceArBothProvided("-r \"release\" -d \"destination\"", "destination", "release", "not set", "valid", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Destination and source ar both provided")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "When checking command line arguments")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "--release \"release\" --destination \"destination\"")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Arguments", "--release \"release\" --destination \"destination\"")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Destination", "destination")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Release", "release")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Check for show name", "not set")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Valid", "valid")]
        public virtual void DestinationAndSourceArBothProvided_ReleaseRelease_DestinationDestination()
        {
            this.DestinationAndSourceArBothProvided("--release \"release\" --destination \"destination\"", "destination", "release", "not set", "valid", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Destination and source ar both provided")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "When checking command line arguments")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "--showName --Release \"release\"")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Arguments", "--showName --Release \"release\"")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Destination", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Release", "release")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Check for show name", "set")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Valid", "valid")]
        public virtual void DestinationAndSourceArBothProvided_ShowName_ReleaseRelease()
        {
            this.DestinationAndSourceArBothProvided("--showName --Release \"release\"", "", "release", "set", "valid", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Destination and source ar both provided")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "When checking command line arguments")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "--showName")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Arguments", "--showName")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Destination", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Release", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Check for show name", "set")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Valid", "invalid")]
        public virtual void DestinationAndSourceArBothProvided_ShowName()
        {
            this.DestinationAndSourceArBothProvided("--showName", "", "", "set", "invalid", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Destination and source ar both provided")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "When checking command line arguments")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "--showName --release /tank/video/TV/TempTV/How\\ - To\\ Get/")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Arguments", "--showName --release /tank/video/TV/TempTV/How\\ - To\\ Get/")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Destination", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Release", "/tank/video/TV/TempTV/How\\ - To\\ Get/")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Check for show name", "set")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Valid", "valid")]
        public virtual void DestinationAndSourceArBothProvided_ShowName_ReleaseTankVideoTVTempTVHow_ToGet()
        {
            this.DestinationAndSourceArBothProvided("--showName --release /tank/video/TV/TempTV/How\\ - To\\ Get/", "", "/tank/video/TV/TempTV/How\\ - To\\ Get/", "set", "valid", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Destination and source ar both provided")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "When checking command line arguments")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "--showName --release \"/tank/video/TV/TempTV/How\\ To\\ Get/\"")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Arguments", "--showName --release \"/tank/video/TV/TempTV/How\\ To\\ Get/\"")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Destination", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Release", "/tank/video/TV/TempTV/How\\ To\\ Get/")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Check for show name", "set")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Valid", "valid")]
        public virtual void DestinationAndSourceArBothProvided_ShowName_ReleaseTankVideoTVTempTVHowToGet()
        {
            this.DestinationAndSourceArBothProvided("--showName --release \"/tank/video/TV/TempTV/How\\ To\\ Get/\"", "", "/tank/video/TV/TempTV/How\\ To\\ Get/", "set", "valid", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("When release is supplied as an argument but no configuration file is present")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "When checking command line arguments")]
        public virtual void WhenReleaseIsSuppliedAsAnArgumentButNoConfigurationFileIsPresent()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When release is supplied as an argument but no configuration file is present", ((string[])(null)));
#line 37
this.ScenarioSetup(scenarioInfo);
#line 38
testRunner.Given("the commandline parameters --release c:\\release", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 39
testRunner.And("no configuration file is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
testRunner.Then("the output should be a statment defining the usage of the program", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 41
testRunner.And("the configuration should be marked as invalid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("When destination is supplied as an argument but no configuration file is present")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "When checking command line arguments")]
        public virtual void WhenDestinationIsSuppliedAsAnArgumentButNoConfigurationFileIsPresent()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When destination is supplied as an argument but no configuration file is present", ((string[])(null)));
#line 43
this.ScenarioSetup(scenarioInfo);
#line 44
testRunner.Given("the commandline parameters --destination c:\\destination", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 45
testRunner.And("no configuration file is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
testRunner.Then("the output should be a statment defining the usage of the program", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 47
testRunner.And("the configuration should be marked as invalid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("When no command line arguments are supplied and no configuration file is present")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "When checking command line arguments")]
        public virtual void WhenNoCommandLineArgumentsAreSuppliedAndNoConfigurationFileIsPresent()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When no command line arguments are supplied and no configuration file is present", ((string[])(null)));
#line 49
this.ScenarioSetup(scenarioInfo);
#line 50
testRunner.Given("No command line parameters", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 51
testRunner.And("no configuration file is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
testRunner.Then("the output should be a statment defining the usage of the program", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 53
testRunner.And("the configuration should be marked as invalid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("When no destination is given and no configuration file is present but we are look" +
            "ing up a show name")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "When checking command line arguments")]
        public virtual void WhenNoDestinationIsGivenAndNoConfigurationFileIsPresentButWeAreLookingUpAShowName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When no destination is given and no configuration file is present but we are look" +
                    "ing up a show name", ((string[])(null)));
#line 55
this.ScenarioSetup(scenarioInfo);
#line 56
testRunner.Given("the commandline parameters --release c:\\release --showname", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 57
testRunner.Then("the configuration should be marked as valid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("When no destination is given but it is present in the configuration file")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "When checking command line arguments")]
        public virtual void WhenNoDestinationIsGivenButItIsPresentInTheConfigurationFile()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When no destination is given but it is present in the configuration file", ((string[])(null)));
#line 59
this.ScenarioSetup(scenarioInfo);
#line 60
testRunner.Given("the commandline parameters --release c:\\release", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 61
testRunner.And("the configuration file", "destination=c:\\destination", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
testRunner.Then("the configuration setting destination is c:\\destination", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 66
testRunner.And("the configuration should be marked as valid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("When destination is supplied from the commandline and from the configfile")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "When checking command line arguments")]
        public virtual void WhenDestinationIsSuppliedFromTheCommandlineAndFromTheConfigfile()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When destination is supplied from the commandline and from the configfile", ((string[])(null)));
#line 68
this.ScenarioSetup(scenarioInfo);
#line 69
testRunner.Given("the commandline parameters --destination c:\\destinationFromCommandLine --release " +
                    "c:\\release", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 70
testRunner.And("the configuration file", "destination=c:\\destinationFromConfig", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
testRunner.Then("the configuration setting destination is c:\\destinationFromCommandLine", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 75
testRunner.And("the configuration should be marked as valid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("When an incorrect config is supplied")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "When checking command line arguments")]
        public virtual void WhenAnIncorrectConfigIsSupplied()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When an incorrect config is supplied", ((string[])(null)));
#line 77
this.ScenarioSetup(scenarioInfo);
#line 78
testRunner.Given("the commandline parameters --release c:\\release", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 79
testRunner.And("the configuration file", "notvalid", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
testRunner.Then("the configuration should be marked as invalid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("When an incorrect config name is supplied")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "When checking command line arguments")]
        public virtual void WhenAnIncorrectConfigNameIsSupplied()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When an incorrect config name is supplied", ((string[])(null)));
#line 85
this.ScenarioSetup(scenarioInfo);
#line 86
testRunner.Given("the commandline parameters --release c:\\release", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 87
testRunner.And("the configuration file", "notvalid=c:\\", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
testRunner.Then("the configuration should be marked as invalid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
