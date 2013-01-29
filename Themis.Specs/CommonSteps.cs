using TechTalk.SpecFlow;
using Themis.Specs.Infrastructure;
using White.Core;
using White.Core.UIItems.WindowItems;

namespace Themis.Specs
{
    public class CommonSteps
    {
        protected static Application Application
        {
            get { return ApplicationWrapper.Instance.Application; }
        }

        protected static Window Window
        {
            get { return ApplicationWrapper.Instance.Window; }
        }

        [Given]
        public void GivenIHaveOpenedTheVs()
        {
            ScenarioContext.Current.Pending();
        }

        [Given]
        public void GivenIHaveCreatedANewCSharpClassLibraryProject()
        {
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