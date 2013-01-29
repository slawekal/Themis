using System;
using TechTalk.SpecFlow;

namespace Themis.Specs
{
    [Binding]
    public class WalkingSkeletonSteps : CommonSteps
    {
        [Then]
        public void ThenMappingDesignerShouldOpenWithAOneDefaultClassCreated()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
