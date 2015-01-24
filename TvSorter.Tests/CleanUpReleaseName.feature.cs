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
    public partial class CleanupReleaseNameToMatchSceneRulesFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CleanUpReleaseName.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Cleanup release name to match scene rules", "\nInput release names need to be aligned with scene rules", ProgrammingLanguage.CSharp, ((string[])(null)));
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
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Cleanup release name to match scene rules")))
            {
                TvSorter.Tests.CleanupReleaseNameToMatchSceneRulesFeature.FeatureSetup(null);
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
        
        public virtual void SetOfExampleCleanups(string inputSceneName, string cleanSceneName, string showName, string season, string episode, string group, string quality, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Set of example cleanups", exampleTags);
#line 5
this.ScenarioSetup(scenarioInfo);
#line 6
 testRunner.Given(string.Format("an input of {0}", inputSceneName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
 testRunner.When("clean up the release name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 8
 testRunner.Then(string.Format("the new name should be {0}", cleanSceneName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 9
 testRunner.And(string.Format("the show name should be {0}", showName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.And(string.Format("the season should be {0}", season), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.And(string.Format("the episode should be {0}", episode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.And(string.Format("the release group should be {0}", group), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.And(string.Format("the quality should be {0}", quality), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Set of example cleanups")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Cleanup release name to match scene rules")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Show.S01E11.720p.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Input scene name", "Show.S01E11.720p.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Clean scene name", "Show.S01E11.720p.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Show name", "Show")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Season", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Episode", "11")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Group", "GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Quality", "720p.HDTV.x264")]
        public virtual void SetOfExampleCleanups_Show_S01E11_720P_HDTV_X264_GROUP()
        {
            this.SetOfExampleCleanups("Show.S01E11.720p.HDTV.x264-GROUP", "Show.S01E11.720p.HDTV.x264-GROUP", "Show", "1", "11", "GROUP", "720p.HDTV.x264", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Set of example cleanups")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Cleanup release name to match scene rules")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Show.1x11.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Input scene name", "Show.1x11.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Clean scene name", "Show.S01E11.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Show name", "Show")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Season", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Episode", "11")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Group", "GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Quality", "HDTV.x264")]
        public virtual void SetOfExampleCleanups_Show_1X11_HDTV_X264_GROUP()
        {
            this.SetOfExampleCleanups("Show.1x11.HDTV.x264-GROUP", "Show.S01E11.HDTV.x264-GROUP", "Show", "1", "11", "GROUP", "HDTV.x264", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Set of example cleanups")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Cleanup release name to match scene rules")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Show.S01E11.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Input scene name", "Show.S01E11.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Clean scene name", "Show.S01E11.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Show name", "Show")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Season", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Episode", "11")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Group", "GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Quality", "HDTV.x264")]
        public virtual void SetOfExampleCleanups_Show_S01E11_HDTV_X264_GROUP()
        {
            this.SetOfExampleCleanups("Show.S01E11.HDTV.x264-GROUP", "Show.S01E11.HDTV.x264-GROUP", "Show", "1", "11", "GROUP", "HDTV.x264", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Set of example cleanups")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Cleanup release name to match scene rules")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Show.S01E11.HDTV.XVID-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Input scene name", "Show.S01E11.HDTV.XVID-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Clean scene name", "Show.S01E11.HDTV.XviD-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Show name", "Show")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Season", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Episode", "11")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Group", "GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Quality", "HDTV.XviD")]
        public virtual void SetOfExampleCleanups_Show_S01E11_HDTV_XVID_GROUP()
        {
            this.SetOfExampleCleanups("Show.S01E11.HDTV.XVID-GROUP", "Show.S01E11.HDTV.XviD-GROUP", "Show", "1", "11", "GROUP", "HDTV.XviD", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Set of example cleanups")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Cleanup release name to match scene rules")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Show.Part.2.720p.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Input scene name", "Show.Part.2.720p.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Clean scene name", "Show.S01E02.720p.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Show name", "Show")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Season", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Episode", "2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Group", "GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Quality", "720p.HDTV.x264")]
        public virtual void SetOfExampleCleanups_Show_Part_2_720P_HDTV_X264_GROUP()
        {
            this.SetOfExampleCleanups("Show.Part.2.720p.HDTV.x264-GROUP", "Show.S01E02.720p.HDTV.x264-GROUP", "Show", "1", "2", "GROUP", "720p.HDTV.x264", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Set of example cleanups")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Cleanup release name to match scene rules")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Show S06E01 720p WEB-DL DD5.1 H.264")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Input scene name", "Show S06E01 720p WEB-DL DD5.1 H.264")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Clean scene name", "Show.S06E01.720p.WEB-DL.DD5.1.H.264-NOGROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Show name", "Show")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Season", "6")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Episode", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Group", "NOGROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Quality", "720p.WEB-DL.DD5.1.H.264")]
        public virtual void SetOfExampleCleanups_ShowS06E01720PWEB_DLDD5_1H_264()
        {
            this.SetOfExampleCleanups("Show S06E01 720p WEB-DL DD5.1 H.264", "Show.S06E01.720p.WEB-DL.DD5.1.H.264-NOGROUP", "Show", "6", "1", "NOGROUP", "720p.WEB-DL.DD5.1.H.264", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Set of example cleanups")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Cleanup release name to match scene rules")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Show S06E01 720p WEB-DL DD5.1 H.264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Input scene name", "Show S06E01 720p WEB-DL DD5.1 H.264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Clean scene name", "Show.S06E01.720p.WEB-DL.DD5.1.H.264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Show name", "Show")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Season", "6")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Episode", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Group", "GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Quality", "720p.WEB-DL.DD5.1.H.264")]
        public virtual void SetOfExampleCleanups_ShowS06E01720PWEB_DLDD5_1H_264_GROUP()
        {
            this.SetOfExampleCleanups("Show S06E01 720p WEB-DL DD5.1 H.264-GROUP", "Show.S06E01.720p.WEB-DL.DD5.1.H.264-GROUP", "Show", "6", "1", "GROUP", "720p.WEB-DL.DD5.1.H.264", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Set of example cleanups")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Cleanup release name to match scene rules")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Show.with.multiple.names.S01E11.720p.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Input scene name", "Show.with.multiple.names.S01E11.720p.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Clean scene name", "Show.With.Multiple.Names.S01E11.720p.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Show name", "Show With Multiple Names")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Season", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Episode", "11")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Group", "GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Quality", "720p.HDTV.x264")]
        public virtual void SetOfExampleCleanups_Show_With_Multiple_Names_S01E11_720P_HDTV_X264_GROUP()
        {
            this.SetOfExampleCleanups("Show.with.multiple.names.S01E11.720p.HDTV.x264-GROUP", "Show.With.Multiple.Names.S01E11.720p.HDTV.x264-GROUP", "Show With Multiple Names", "1", "11", "GROUP", "720p.HDTV.x264", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Set of example cleanups")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Cleanup release name to match scene rules")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Show.&.The.Showing.S01E11.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Input scene name", "Show.&.The.Showing.S01E11.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Clean scene name", "Show.and.the.Showing.S01E11.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Show name", "Show and the Showing")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Season", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Episode", "11")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Group", "GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Quality", "HDTV.x264")]
        public virtual void SetOfExampleCleanups_Show__The_Showing_S01E11_HDTV_X264_GROUP()
        {
            this.SetOfExampleCleanups("Show.&.The.Showing.S01E11.HDTV.x264-GROUP", "Show.and.the.Showing.S01E11.HDTV.x264-GROUP", "Show and the Showing", "1", "11", "GROUP", "HDTV.x264", ((string[])(null)));
        }
        
        public virtual void QualityStringsShouldBeCleanedUp(string inputSceneName, string quality, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Quality strings should be cleaned up", exampleTags);
#line 28
this.ScenarioSetup(scenarioInfo);
#line 29
 testRunner.Given(string.Format("an input of {0}", inputSceneName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 30
 testRunner.When("clean up the release name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
 testRunner.Then(string.Format("the quality should be {0}", quality), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Quality strings should be cleaned up")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Cleanup release name to match scene rules")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Show.S01E01.HDTV.XVID-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Input scene name", "Show.S01E01.HDTV.XVID-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Quality", "HDTV.XviD")]
        public virtual void QualityStringsShouldBeCleanedUp_Show_S01E01_HDTV_XVID_GROUP()
        {
            this.QualityStringsShouldBeCleanedUp("Show.S01E01.HDTV.XVID-GROUP", "HDTV.XviD", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Quality strings should be cleaned up")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Cleanup release name to match scene rules")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Show.S01E01.720p.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Input scene name", "Show.S01E01.720p.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Quality", "720p.HDTV.x264")]
        public virtual void QualityStringsShouldBeCleanedUp_Show_S01E01_720P_HDTV_X264_GROUP()
        {
            this.QualityStringsShouldBeCleanedUp("Show.S01E01.720p.HDTV.x264-GROUP", "720p.HDTV.x264", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Quality strings should be cleaned up")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Cleanup release name to match scene rules")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Show.S01E01.DVDRIP-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Input scene name", "Show.S01E01.DVDRIP-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Quality", "DVDRip")]
        public virtual void QualityStringsShouldBeCleanedUp_Show_S01E01_DVDRIP_GROUP()
        {
            this.QualityStringsShouldBeCleanedUp("Show.S01E01.DVDRIP-GROUP", "DVDRip", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Quality strings should be cleaned up")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Cleanup release name to match scene rules")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Show.S01E01.BLURAY-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Input scene name", "Show.S01E01.BLURAY-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Quality", "BluRay")]
        public virtual void QualityStringsShouldBeCleanedUp_Show_S01E01_BLURAY_GROUP()
        {
            this.QualityStringsShouldBeCleanedUp("Show.S01E01.BLURAY-GROUP", "BluRay", ((string[])(null)));
        }
        
        public virtual void RomanNumeralsShouldBeConvertedToDecimal(string inputSceneName, string season, string episode, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Roman numerals should be converted to decimal", exampleTags);
#line 40
this.ScenarioSetup(scenarioInfo);
#line 41
 testRunner.Given(string.Format("an input of {0}", inputSceneName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 42
 testRunner.When("clean up the release name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 43
 testRunner.Then(string.Format("the season should be {0}", season), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 44
 testRunner.And(string.Format("the episode should be {0}", episode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Roman numerals should be converted to decimal")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Cleanup release name to match scene rules")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Show.Part.I.720p.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Input scene name", "Show.Part.I.720p.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Season", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Episode", "1")]
        public virtual void RomanNumeralsShouldBeConvertedToDecimal_Show_Part_I_720P_HDTV_X264_GROUP()
        {
            this.RomanNumeralsShouldBeConvertedToDecimal("Show.Part.I.720p.HDTV.x264-GROUP", "1", "1", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Roman numerals should be converted to decimal")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Cleanup release name to match scene rules")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Show.Part.II.720p.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Input scene name", "Show.Part.II.720p.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Season", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Episode", "2")]
        public virtual void RomanNumeralsShouldBeConvertedToDecimal_Show_Part_II_720P_HDTV_X264_GROUP()
        {
            this.RomanNumeralsShouldBeConvertedToDecimal("Show.Part.II.720p.HDTV.x264-GROUP", "1", "2", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Roman numerals should be converted to decimal")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Cleanup release name to match scene rules")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Show.Part.III.720p.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Input scene name", "Show.Part.III.720p.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Season", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Episode", "3")]
        public virtual void RomanNumeralsShouldBeConvertedToDecimal_Show_Part_III_720P_HDTV_X264_GROUP()
        {
            this.RomanNumeralsShouldBeConvertedToDecimal("Show.Part.III.720p.HDTV.x264-GROUP", "1", "3", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Roman numerals should be converted to decimal")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Cleanup release name to match scene rules")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Show.Part.IV.720p.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Input scene name", "Show.Part.IV.720p.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Season", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Episode", "4")]
        public virtual void RomanNumeralsShouldBeConvertedToDecimal_Show_Part_IV_720P_HDTV_X264_GROUP()
        {
            this.RomanNumeralsShouldBeConvertedToDecimal("Show.Part.IV.720p.HDTV.x264-GROUP", "1", "4", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Roman numerals should be converted to decimal")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Cleanup release name to match scene rules")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Show.Part.V.720p.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Input scene name", "Show.Part.V.720p.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Season", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Episode", "5")]
        public virtual void RomanNumeralsShouldBeConvertedToDecimal_Show_Part_V_720P_HDTV_X264_GROUP()
        {
            this.RomanNumeralsShouldBeConvertedToDecimal("Show.Part.V.720p.HDTV.x264-GROUP", "1", "5", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Roman numerals should be converted to decimal")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Cleanup release name to match scene rules")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Show.Part.VI.720p.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Input scene name", "Show.Part.VI.720p.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Season", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Episode", "6")]
        public virtual void RomanNumeralsShouldBeConvertedToDecimal_Show_Part_VI_720P_HDTV_X264_GROUP()
        {
            this.RomanNumeralsShouldBeConvertedToDecimal("Show.Part.VI.720p.HDTV.x264-GROUP", "1", "6", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Roman numerals should be converted to decimal")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Cleanup release name to match scene rules")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Show.Part.VII.720p.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Input scene name", "Show.Part.VII.720p.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Season", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Episode", "7")]
        public virtual void RomanNumeralsShouldBeConvertedToDecimal_Show_Part_VII_720P_HDTV_X264_GROUP()
        {
            this.RomanNumeralsShouldBeConvertedToDecimal("Show.Part.VII.720p.HDTV.x264-GROUP", "1", "7", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Roman numerals should be converted to decimal")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Cleanup release name to match scene rules")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Show.Part.VIII.720p.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Input scene name", "Show.Part.VIII.720p.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Season", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Episode", "8")]
        public virtual void RomanNumeralsShouldBeConvertedToDecimal_Show_Part_VIII_720P_HDTV_X264_GROUP()
        {
            this.RomanNumeralsShouldBeConvertedToDecimal("Show.Part.VIII.720p.HDTV.x264-GROUP", "1", "8", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Roman numerals should be converted to decimal")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Cleanup release name to match scene rules")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Show.Part.IX.720p.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Input scene name", "Show.Part.IX.720p.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Season", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Episode", "9")]
        public virtual void RomanNumeralsShouldBeConvertedToDecimal_Show_Part_IX_720P_HDTV_X264_GROUP()
        {
            this.RomanNumeralsShouldBeConvertedToDecimal("Show.Part.IX.720p.HDTV.x264-GROUP", "1", "9", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Roman numerals should be converted to decimal")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Cleanup release name to match scene rules")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Show.Part.X.720p.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Input scene name", "Show.Part.X.720p.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Season", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Episode", "10")]
        public virtual void RomanNumeralsShouldBeConvertedToDecimal_Show_Part_X_720P_HDTV_X264_GROUP()
        {
            this.RomanNumeralsShouldBeConvertedToDecimal("Show.Part.X.720p.HDTV.x264-GROUP", "1", "10", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Roman numerals should be converted to decimal")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Cleanup release name to match scene rules")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Show.Part.XI.720p.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Input scene name", "Show.Part.XI.720p.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Season", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Episode", "11")]
        public virtual void RomanNumeralsShouldBeConvertedToDecimal_Show_Part_XI_720P_HDTV_X264_GROUP()
        {
            this.RomanNumeralsShouldBeConvertedToDecimal("Show.Part.XI.720p.HDTV.x264-GROUP", "1", "11", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Roman numerals should be converted to decimal")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Cleanup release name to match scene rules")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Show.Part.XII.720p.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Input scene name", "Show.Part.XII.720p.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Season", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Episode", "12")]
        public virtual void RomanNumeralsShouldBeConvertedToDecimal_Show_Part_XII_720P_HDTV_X264_GROUP()
        {
            this.RomanNumeralsShouldBeConvertedToDecimal("Show.Part.XII.720p.HDTV.x264-GROUP", "1", "12", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Roman numerals should be converted to decimal")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Cleanup release name to match scene rules")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Show.Part.XIII.720p.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Input scene name", "Show.Part.XIII.720p.HDTV.x264-GROUP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Season", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Episode", "13")]
        public virtual void RomanNumeralsShouldBeConvertedToDecimal_Show_Part_XIII_720P_HDTV_X264_GROUP()
        {
            this.RomanNumeralsShouldBeConvertedToDecimal("Show.Part.XIII.720p.HDTV.x264-GROUP", "1", "13", ((string[])(null)));
        }
    }
}
#pragma warning restore
#endregion
