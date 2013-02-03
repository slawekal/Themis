using NUnit.Framework;
using TechTalk.SpecFlow;
using Themis.Specs.Infrastructure;
using White.Core.UIItems.Finders;
using White.Core.WindowsAPI;

namespace Themis.Specs
{
    [Binding]
    public class CommonSteps : BaseSteps
    {
        [Given]
        public void GivenIHaveOpenedTheVs()
        {
            Assert.NotNull(Application, "Visual Studio not found.");
            Assert.NotNull(Window, "Main window not found.");
        }

        [Given]
        public void GivenIHaveCreatedANewCSharpClassLibraryProject()
        {
            PressShortcutOfNewProject();
            var newProjectWindow = GetWindowByAutomationId("NewProjectDialog1");
            Assert.NotNull(newProjectWindow, "New Project dialog cannot be found.");
            var classLibraryItem = newProjectWindow.GetElement(SearchCriteria.ByAutomationId("Class Library"));
            Assert.NotNull(classLibraryItem, "Class Library item on New Project dialog cannot be found.");
            classLibraryItem.Click();
            Wait();
            ScenarioContext.Current.Pending();
        }

        private static void PressShortcutOfNewProject()
        {
            Window.PressShortcut('n', KeyboardInput.SpecialKeys.CONTROL, KeyboardInput.SpecialKeys.SHIFT);
        }

        [Given]
        public void GivenIHaveAddedANewMappingFileToTheProject()
        {
            ScenarioContext.Current.Pending();
        }

        [When]
        public void WhenIOpenTheMappingFile()
        {
            ScenarioContext.Current.Pending();
        }
    }
}