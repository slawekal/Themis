using System.Threading;
using Themis.Specs.Infrastructure;
using White.Core;
using White.Core.Factory;
using White.Core.UIItems.Finders;
using White.Core.UIItems.WindowItems;

namespace Themis.Specs
{
    public class BaseSteps
    {
        protected static Application Application
        {
            get { return ApplicationWrapper.Instance.Application; }
        }

        protected static Window Window
        {
            get { return ApplicationWrapper.Instance.Window; }
        }

        protected static string ProjectsDirectory
        {
            get { return ApplicationWrapper.Instance.ProjectsDirectory; }
        }

        protected static Window GetWindowByAutomationId(string windowAutomationId)
        {
            return Window.ModalWindow(
                SearchCriteria.ByAutomationId(windowAutomationId),
                InitializeOption.NoCache);
        }

        protected static void Wait()
        {
            Thread.Sleep(5000);
        }
    }
}