using TechTalk.SpecFlow;

namespace Themis.Specs
{
    [Binding]
    public class WalkingSkeletonSteps : BaseSteps
    {
        [Then]
        public void ThenMappingDesignerShouldOpenWithAOneDefaultClassCreated()
        {
            ScenarioContext.Current.Pending();
        }
    }
}