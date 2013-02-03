using NUnit.Framework;
using TechTalk.SpecFlow;
using Themis.Specs.Infrastructure;
using White.Core.WindowsAPI;

namespace Themis.Specs
{
    [Binding]
    public class CommonSteps : BaseSteps
    {
        [Given]
        public void GivenIHaveOpenedTheVs()
        {
            Assert.NotNull(Application);
            Assert.NotNull(Window);
        }

        [Given]
        public void GivenIHaveCreatedANewCSharpClassLibraryProject()
        {
            Window.PressShortcut('f', KeyboardInput.SpecialKeys.ALT);
            Window.PressShortcut('n');
            ScenarioContext.Current.Pending();
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