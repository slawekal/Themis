using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using NUnit.Framework;
using White.Core;
using White.Core.Configuration;
using White.Core.Factory;
using White.Core.UIItems.Finders;
using White.Core.UIItems.WindowItems;
using Debug = System.Diagnostics.Debug;

namespace Themis.Specs.Infrastructure
{
    public sealed class ApplicationWrapper
    {
        private const string EXPERIMENTAL_VISUAL_STUDIO_ARGUMENTS = @"/rootsuffix Exp /RANU";

        private const string EXPERIMENTAL_VISUAL_STUDIO_PATH =
            @"C:\Program Files (x86)\Microsoft Visual Studio 11.0\Common7\IDE\devenv.exe";

        private static readonly ApplicationWrapper Instnc = new ApplicationWrapper();

        public static ApplicationWrapper Instance
        {
            get { return Instnc; }
        }

        public Application Application { get; private set; }
        public Window Window { get; private set; }
        public string ProjectsDirectory { get; private set; }

        private ApplicationWrapper()
        {
        }

        public void StartApplication()
        {
            var process =
                new Process
                    {
                        StartInfo =
                            {
                                FileName = EXPERIMENTAL_VISUAL_STUDIO_PATH,
                                Arguments = EXPERIMENTAL_VISUAL_STUDIO_ARGUMENTS
                            }
                    };
            process.Start();

            Application = Application.Attach(process);

            var orgBusyTimeout = CoreAppXmlConfiguration.Instance.BusyTimeout;
            CoreAppXmlConfiguration.Instance.BusyTimeout = 20000;
            Window = Application.GetWindow(
                SearchCriteria.ByAutomationId("VisualStudioMainWindow"), InitializeOption.NoCache);
            CoreAppXmlConfiguration.Instance.BusyTimeout = orgBusyTimeout;

            Debug.Assert(
                TestContext.CurrentContext.TestDirectory != null,
                "TestContext.CurrentContext.TestDirectory should be not null");
            ProjectsDirectory =
                Path.Combine(
                    Path.GetPathRoot(TestContext.CurrentContext.TestDirectory), "ThemisTestProjects",
                    "Run" + DateTime.Now.Ticks.ToString(CultureInfo.InvariantCulture));
            Directory.CreateDirectory(ProjectsDirectory);
        }

        public void StopApplication()
        {
            if (Application != null)
            {
                Application.Dispose();
                Application = null;
            }
            Window = null;
        }
    }
}