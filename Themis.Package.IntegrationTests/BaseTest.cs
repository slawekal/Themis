using System;
using System.Diagnostics;
using System.IO;
using Microsoft.VSSDK.Tools.VsIdeTesting;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VsSDK.IntegrationTestLibrary;

namespace Themis.Package.IntegrationTests
{
    public abstract class BaseTest
    {
        private delegate void ThreadInvoker();

        /// <summary>
        ///     Gets or sets the test context which provides
        ///     information about and functionality for the current test run.
        /// </summary>
        public TestContext TestContext { get; set; }

        protected abstract string Language { get; }

        protected void InNewWebFormProject(Action<TestUtils> actionAfterProjectCreated)
        {
            var projectName = GetProjectName();

            UIThreadInvoker.Invoke(
                (ThreadInvoker)
                delegate
                    {
                        var testUtils = new TestUtils();

                        Debug.WriteLine("New solution created:");
                        Debug.WriteLine(Path.Combine(TestContext.TestDir, projectName + "1"));
                        Debug.WriteLine("");

                        testUtils.CloseCurrentSolution(
                            __VSSLNSAVEOPTIONS.SLNSAVEOPT_NoSave);

                        // Create empty solution
                        testUtils.CreateEmptySolution(TestContext.TestDir, projectName);
                        Assert.AreEqual(0, testUtils.ProjectCount());

                        try
                        {
                            // Create Winforms application project
                            testUtils.CreateProjectFromTemplate(
                                "MyWindowsApp",
                                "Windows Forms Application", Language, false);
                            Assert.AreEqual(1, testUtils.ProjectCount());

                            actionAfterProjectCreated(testUtils);

                            //TODO Verify that we can debug launch the application

                            //TODO Set Break point and verify that will hit

                            //TODO Verify Adding new project item to project
                        }
                        finally
                        {
                            testUtils.CloseCurrentSolution(
                                __VSSLNSAVEOPTIONS.SLNSAVEOPT_SaveIfDirty);
                        }
                    });
        }

        private static string GetProjectName()
        {
            var stackTrace = new StackTrace();
            var stackFrame = stackTrace.GetFrame(2);
            var method = stackFrame.GetMethod();
            Debug.Assert(method.DeclaringType != null, "method.DeclaringType != null");
            return string.Format("{0}.{1}", method.DeclaringType.FullName, method.Name);
        }
    }
}