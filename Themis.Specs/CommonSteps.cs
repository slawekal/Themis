using System.Diagnostics;
using System.IO;
using NUnit.Framework;
using TechTalk.SpecFlow;
using Themis.Specs.Infrastructure;
using White.Core.UIItems;
using White.Core.UIItems.Finders;
using White.Core.UIItems.ListBoxItems;
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
            Assert.NotNull(classLibraryItem, "Class Library item on the New Project dialog cannot be found.");
            classLibraryItem.Click();
            var nameTextBox = newProjectWindow.Get<TextBox>(SearchCriteria.ByAutomationId("txt_Name"));
            Assert.NotNull(nameTextBox, "Name textbox on the New Project dialog cannot be found.");
            var locationCombo = newProjectWindow.Get<ComboBox>(SearchCriteria.ByAutomationId("LocationCombo"));
            Assert.NotNull(locationCombo, "Location combobox on the New Project dialog cannot be found.");
            var newSlnDirectoryCheckBox =
                newProjectWindow.Get<CheckBox>(SearchCriteria.ByAutomationId("chk_NewSlnDirectory"));
            Assert.NotNull(
                newSlnDirectoryCheckBox,
                "Create directory for solution checkbox on the New Project dialog cannot be found.");
            var okButton = newProjectWindow.Get<Button>(SearchCriteria.ByAutomationId("btn_OK"));
            Assert.NotNull(okButton, "OK button on the New Project dialog cannot be found.");
            locationCombo.EditableText = ProjectsDirectory;
            newSlnDirectoryCheckBox.UnSelect();
            okButton.Click();
            Wait();
            SaveAll();
            Debug.WriteLine("Project created: {0}", (object) Path.Combine(ProjectsDirectory, nameTextBox.Text));
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

        private static void PressShortcutOfNewProject()
        {
            Window.PressShortcut('n', KeyboardInput.SpecialKeys.CONTROL, KeyboardInput.SpecialKeys.SHIFT);
        }

        private static void SaveAll()
        {
            Window.PressShortcut('s', KeyboardInput.SpecialKeys.CONTROL, KeyboardInput.SpecialKeys.SHIFT);
        }
    }
}