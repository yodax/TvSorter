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
    public partial class MovingAReleaseToItsDestinationFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "MovingAReleaseToItsDestination.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Moving a release to its destination", "", ProgrammingLanguage.CSharp, ((string[])(null)));
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
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Moving a release to its destination")))
            {
                TvSorter.Tests.MovingAReleaseToItsDestinationFeature.FeatureSetup(null);
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
        
        public virtual void FeatureBackground()
        {
#line 3
#line 4
 testRunner.Given("a release in c:\\incoming\\ReleaseDir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 5
 testRunner.And("a tv destination of c:\\tv\\{ShowName}\\{SeasonEpisode}\\{ReleaseName}.{Extension}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item",
                        "Type"});
            table1.AddRow(new string[] {
                        "c:\\tv",
                        "Directory"});
            table1.AddRow(new string[] {
                        "c:\\incoming",
                        "Directory"});
#line 6
 testRunner.And("a directory structure", ((string)(null)), table1, "And ");
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Just one file to be moved")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving a release to its destination")]
        public virtual void JustOneFileToBeMoved()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Just one file to be moved", ((string[])(null)));
#line 11
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item"});
            table2.AddRow(new string[] {
                        "Show.S01E01.HDTV-NOGROUP.mkv"});
#line 12
 testRunner.Given("the files in the release directory", ((string)(null)), table2, "Given ");
#line 15
 testRunner.When("we request a move", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item"});
            table3.AddRow(new string[] {
                        "c:\\tv\\Show\\S01E01\\Show.S01E01.HDTV-NOGROUP.mkv"});
#line 16
 testRunner.Then("the directory structure should contain", ((string)(null)), table3, "Then ");
#line 19
 testRunner.And("the directory c:\\incoming should be empty", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("An existing file is present")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving a release to its destination")]
        public virtual void AnExistingFileIsPresent()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("An existing file is present", ((string[])(null)));
#line 21
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item"});
            table4.AddRow(new string[] {
                        "Show.S01E01.HDTV-NOGROUP.mkv"});
#line 22
 testRunner.Given("the files in the release directory", ((string)(null)), table4, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item",
                        "Type"});
            table5.AddRow(new string[] {
                        "c:\\tv\\Show\\S01E01\\Show.S01E01.HDTV-NOGROUP.mkv",
                        "File"});
#line 25
 testRunner.And("a directory structure", ((string)(null)), table5, "And ");
#line 28
 testRunner.When("we request a move", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item"});
            table6.AddRow(new string[] {
                        "c:\\tv\\Show\\S01E01\\Show.S01E01.HDTV-NOGROUP.mkv"});
            table6.AddRow(new string[] {
                        "c:\\tv\\Show\\S01E01\\Show.S01E01.HDTV-NOGROUP.1.mkv"});
#line 29
 testRunner.Then("the directory structure should contain", ((string)(null)), table6, "Then ");
#line 33
 testRunner.And("the directory c:\\incoming should be empty", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Two existing files are present")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving a release to its destination")]
        public virtual void TwoExistingFilesArePresent()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Two existing files are present", ((string[])(null)));
#line 35
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item"});
            table7.AddRow(new string[] {
                        "Show.S01E01.HDTV-NOGROUP.mkv"});
#line 36
 testRunner.Given("the files in the release directory", ((string)(null)), table7, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item",
                        "Type"});
            table8.AddRow(new string[] {
                        "c:\\tv\\Show\\S01E01\\Show.S01E01.HDTV-NOGROUP.mkv",
                        "File"});
            table8.AddRow(new string[] {
                        "c:\\tv\\Show\\S01E01\\Show.S01E01.HDTV-NOGROUP.1.mkv",
                        "File"});
#line 39
 testRunner.And("a directory structure", ((string)(null)), table8, "And ");
#line 44
 testRunner.When("we request a move", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item"});
            table9.AddRow(new string[] {
                        "c:\\tv\\Show\\S01E01\\Show.S01E01.HDTV-NOGROUP.mkv"});
            table9.AddRow(new string[] {
                        "c:\\tv\\Show\\S01E01\\Show.S01E01.HDTV-NOGROUP.1.mkv"});
            table9.AddRow(new string[] {
                        "c:\\tv\\Show\\S01E01\\Show.S01E01.HDTV-NOGROUP.2.mkv"});
#line 45
 testRunner.Then("the directory structure should contain", ((string)(null)), table9, "Then ");
#line 50
 testRunner.And("the directory c:\\incoming should be empty", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("A seperate nfo file with a different name should be renamed")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving a release to its destination")]
        public virtual void ASeperateNfoFileWithADifferentNameShouldBeRenamed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A seperate nfo file with a different name should be renamed", ((string[])(null)));
#line 52
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item"});
            table10.AddRow(new string[] {
                        "Show.S01E01.HDTV-NOGROUP.mkv"});
            table10.AddRow(new string[] {
                        "info.nfo"});
#line 53
 testRunner.Given("the files in the release directory", ((string)(null)), table10, "Given ");
#line 57
 testRunner.When("we request a move", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item"});
            table11.AddRow(new string[] {
                        "c:\\tv\\Show\\S01E01\\Show.S01E01.HDTV-NOGROUP.mkv"});
            table11.AddRow(new string[] {
                        "c:\\tv\\Show\\S01E01\\Show.S01E01.HDTV-NOGROUP.nfo"});
#line 58
 testRunner.Then("the directory structure should contain", ((string)(null)), table11, "Then ");
#line 62
 testRunner.And("the directory c:\\incoming should be empty", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("A seperate subtitle file with a different name should be renamed")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving a release to its destination")]
        public virtual void ASeperateSubtitleFileWithADifferentNameShouldBeRenamed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A seperate subtitle file with a different name should be renamed", ((string[])(null)));
#line 64
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item"});
            table12.AddRow(new string[] {
                        "Show.S01E01.HDTV-NOGROUP.mkv"});
            table12.AddRow(new string[] {
                        "subtitle.srt"});
#line 65
 testRunner.Given("the files in the release directory", ((string)(null)), table12, "Given ");
#line 69
 testRunner.When("we request a move", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item"});
            table13.AddRow(new string[] {
                        "c:\\tv\\Show\\S01E01\\Show.S01E01.HDTV-NOGROUP.mkv"});
            table13.AddRow(new string[] {
                        "c:\\tv\\Show\\S01E01\\Show.S01E01.HDTV-NOGROUP.srt"});
#line 70
 testRunner.Then("the directory structure should contain", ((string)(null)), table13, "Then ");
#line 74
 testRunner.And("the directory c:\\incoming should be empty", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("A mp4 file should be moved")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving a release to its destination")]
        public virtual void AMp4FileShouldBeMoved()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A mp4 file should be moved", ((string[])(null)));
#line 76
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item"});
            table14.AddRow(new string[] {
                        "Show.S01E01.HDTV-NOGROUP.mp4"});
#line 77
 testRunner.Given("the files in the release directory", ((string)(null)), table14, "Given ");
#line 80
 testRunner.When("we request a move", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item"});
            table15.AddRow(new string[] {
                        "c:\\tv\\Show\\S01E01\\Show.S01E01.HDTV-NOGROUP.mp4"});
#line 81
 testRunner.Then("the directory structure should contain", ((string)(null)), table15, "Then ");
#line 84
 testRunner.And("the directory c:\\incoming should be empty", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("A avi file should be moved")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving a release to its destination")]
        public virtual void AAviFileShouldBeMoved()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A avi file should be moved", ((string[])(null)));
#line 86
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item"});
            table16.AddRow(new string[] {
                        "Show.S01E01.HDTV-NOGROUP.avi"});
#line 87
 testRunner.Given("the files in the release directory", ((string)(null)), table16, "Given ");
#line 90
 testRunner.When("we request a move", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item"});
            table17.AddRow(new string[] {
                        "c:\\tv\\Show\\S01E01\\Show.S01E01.HDTV-NOGROUP.avi"});
#line 91
 testRunner.Then("the directory structure should contain", ((string)(null)), table17, "Then ");
#line 94
 testRunner.And("the directory c:\\incoming should be empty", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("More than one media file detected")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving a release to its destination")]
        public virtual void MoreThanOneMediaFileDetected()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("More than one media file detected", ((string[])(null)));
#line 96
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item"});
            table18.AddRow(new string[] {
                        "Show.S01E01.HDTV-NOGROUP.mkv"});
            table18.AddRow(new string[] {
                        "Show.S01E02.HDTV-NOGROUP.mkv"});
#line 97
 testRunner.Given("the files in the release directory", ((string)(null)), table18, "Given ");
#line 101
 testRunner.When("we request a move", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 102
 testRunner.Then("the release should not have been removed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 103
 testRunner.And("the output should be", "More than one media file detected in c:\\incoming\\ReleaseDir", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("No files are detected")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving a release to its destination")]
        public virtual void NoFilesAreDetected()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("No files are detected", ((string[])(null)));
#line 108
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item",
                        "Type"});
            table19.AddRow(new string[] {
                        "c:\\incoming\\ReleaseDir",
                        "Directory"});
#line 112
 testRunner.Given("a directory structure", ((string)(null)), table19, "Given ");
#line 115
 testRunner.When("we request a move", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 116
 testRunner.Then("the release should not have been removed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 117
 testRunner.And("the output should be", "No media files detected in c:\\incoming\\ReleaseDir", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void NotAllFileTypesShouldBeMoved(string allowedExtension, string notAllowedExtension, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Not all file types should be moved", exampleTags);
#line 122
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 123
 testRunner.Given(string.Format("a file with extenstion {0}", allowedExtension), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 124
 testRunner.And(string.Format("a file with a non allowed extension {0}", notAllowedExtension), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 125
 testRunner.When("we request a move", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 126
 testRunner.Then(string.Format("the directory structure should not contain a file with {0}", notAllowedExtension), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 127
 testRunner.And(string.Format("the directory structure should contain a file {0}", allowedExtension), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 128
 testRunner.And("the directory c:\\incoming should be empty", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Not all file types should be moved")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving a release to its destination")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AllowedExtension", "mkv")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:NotAllowedExtension", "rar")]
        public virtual void NotAllFileTypesShouldBeMoved_Variant0()
        {
            this.NotAllFileTypesShouldBeMoved("mkv", "rar", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Not all file types should be moved")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving a release to its destination")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AllowedExtension", "mp4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:NotAllowedExtension", "srr")]
        public virtual void NotAllFileTypesShouldBeMoved_Variant1()
        {
            this.NotAllFileTypesShouldBeMoved("mp4", "srr", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Not all file types should be moved")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving a release to its destination")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AllowedExtension", "nfo")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:NotAllowedExtension", "xyz")]
        public virtual void NotAllFileTypesShouldBeMoved_Variant2()
        {
            this.NotAllFileTypesShouldBeMoved("nfo", "xyz", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Not all file types should be moved")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving a release to its destination")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AllowedExtension", "srt")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:NotAllowedExtension", "xyz")]
        public virtual void NotAllFileTypesShouldBeMoved_Variant3()
        {
            this.NotAllFileTypesShouldBeMoved("srt", "xyz", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Not all file types should be moved")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving a release to its destination")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AllowedExtension", "idx")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:NotAllowedExtension", "xyz")]
        public virtual void NotAllFileTypesShouldBeMoved_Variant4()
        {
            this.NotAllFileTypesShouldBeMoved("idx", "xyz", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Not all file types should be moved")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving a release to its destination")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 5")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AllowedExtension", "sub")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:NotAllowedExtension", "xyz")]
        public virtual void NotAllFileTypesShouldBeMoved_Variant5()
        {
            this.NotAllFileTypesShouldBeMoved("sub", "xyz", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Not all file types should be moved")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving a release to its destination")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 6")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AllowedExtension", "avi")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:NotAllowedExtension", "txt")]
        public virtual void NotAllFileTypesShouldBeMoved_Variant6()
        {
            this.NotAllFileTypesShouldBeMoved("avi", "txt", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Not all file types should be moved")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving a release to its destination")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 7")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AllowedExtension", "mkv")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:NotAllowedExtension", "url")]
        public virtual void NotAllFileTypesShouldBeMoved_Variant7()
        {
            this.NotAllFileTypesShouldBeMoved("mkv", "url", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("A succesfull move with output")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving a release to its destination")]
        public virtual void ASuccesfullMoveWithOutput()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A succesfull move with output", ((string[])(null)));
#line 141
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item"});
            table20.AddRow(new string[] {
                        "Show.S01E01.HDTV-NOGROUP.mkv"});
            table20.AddRow(new string[] {
                        "subtitle.srt"});
            table20.AddRow(new string[] {
                        "url.txt"});
#line 142
 testRunner.Given("the files in the release directory", ((string)(null)), table20, "Given ");
#line hidden
#line 147
 testRunner.And("an info file in the release directory with name info1.nfo", "Hello world!\nThis is a multiline info file :)", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 152
 testRunner.And("an info file in the release directory with name info2.nfo", "This is a second nfo file", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 156
 testRunner.When("we request a move", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item"});
            table21.AddRow(new string[] {
                        "c:\\tv\\Show\\S01E01\\Show.S01E01.HDTV-NOGROUP.mkv"});
            table21.AddRow(new string[] {
                        "c:\\tv\\Show\\S01E01\\Show.S01E01.HDTV-NOGROUP.srt"});
            table21.AddRow(new string[] {
                        "c:\\tv\\Show\\S01E01\\Show.S01E01.HDTV-NOGROUP.nfo"});
#line 157
 testRunner.Then("the directory structure should contain", ((string)(null)), table21, "Then ");
#line 162
 testRunner.And("the directory c:\\incoming should be empty", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 163
 testRunner.And("the output should be", @"Using filename: Show.S01E01.HDTV-NOGROUP

Moving files from: c:\incoming\ReleaseDir
        directory: c:\tv\Show\S01E01

Moving:

	$ Show.S01E01.HDTV-NOGROUP.mkv => Show.S01E01.HDTV-NOGROUP.mkv
	$ subtitle.srt                 => Show.S01E01.HDTV-NOGROUP.srt
	$ info1.nfo                    => Show.S01E01.HDTV-NOGROUP.nfo
	$ info2.nfo                    => Show.S01E01.HDTV-NOGROUP.1.nfo

Not moving:

	$ url.txt

NFO file:

	$ Hello world!
	$ This is a multiline info file :)
	$ 
	$ =====================
	$ 
	$ This is a second nfo file", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("A succesfull move without an nfo file should not have the nfo section in its outp" +
            "ut")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving a release to its destination")]
        public virtual void ASuccesfullMoveWithoutAnNfoFileShouldNotHaveTheNfoSectionInItsOutput()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A succesfull move without an nfo file should not have the nfo section in its outp" +
                    "ut", ((string[])(null)));
#line 191
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item"});
            table22.AddRow(new string[] {
                        "Show.S01E01.HDTV-NOGROUP.mkv"});
            table22.AddRow(new string[] {
                        "subtitle.srt"});
            table22.AddRow(new string[] {
                        "url.txt"});
#line 192
 testRunner.Given("the files in the release directory", ((string)(null)), table22, "Given ");
#line 197
 testRunner.When("we request a move", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item"});
            table23.AddRow(new string[] {
                        "c:\\tv\\Show\\S01E01\\Show.S01E01.HDTV-NOGROUP.mkv"});
            table23.AddRow(new string[] {
                        "c:\\tv\\Show\\S01E01\\Show.S01E01.HDTV-NOGROUP.srt"});
#line 198
 testRunner.Then("the directory structure should contain", ((string)(null)), table23, "Then ");
#line 202
 testRunner.And("the directory c:\\incoming should be empty", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 203
 testRunner.And("the output should not contain NFO file:", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("A succesfull move without an extra file should not have the not moved section in " +
            "its output")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving a release to its destination")]
        public virtual void ASuccesfullMoveWithoutAnExtraFileShouldNotHaveTheNotMovedSectionInItsOutput()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A succesfull move without an extra file should not have the not moved section in " +
                    "its output", ((string[])(null)));
#line 205
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item"});
            table24.AddRow(new string[] {
                        "Show.S01E01.HDTV-NOGROUP.mkv"});
            table24.AddRow(new string[] {
                        "subtitle.srt"});
#line 206
 testRunner.Given("the files in the release directory", ((string)(null)), table24, "Given ");
#line 210
 testRunner.When("we request a move", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item"});
            table25.AddRow(new string[] {
                        "c:\\tv\\Show\\S01E01\\Show.S01E01.HDTV-NOGROUP.mkv"});
            table25.AddRow(new string[] {
                        "c:\\tv\\Show\\S01E01\\Show.S01E01.HDTV-NOGROUP.srt"});
#line 211
 testRunner.Then("the directory structure should contain", ((string)(null)), table25, "Then ");
#line 215
 testRunner.And("the directory c:\\incoming should be empty", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 216
 testRunner.And("the output should not contain Not moving:", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
