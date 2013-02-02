using TechTalk.SpecFlow;

namespace Themis.Specs
{
    [Binding]
    public class WalkingSkeletonSteps
    {
        [Then]
        public void ThenMappingDesignerShouldOpenWithAOneDefaultClassCreated()
        {
            ScenarioContext.Current.Pending();
        }
    }
}