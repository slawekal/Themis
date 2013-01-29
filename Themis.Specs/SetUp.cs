using NUnit.Framework;
using Themis.Specs.Infrastructure;

namespace Themis.Specs
{
    [SetUpFixture]
    public class SetUp
    {
        [SetUp]
        private void RunBeforeAnyTests()
        {
            ApplicationWrapper.Instance.StartApplication();
        }

        [TearDown]
        private void RunAfterAnyTests()
        {
            ApplicationWrapper.Instance.StopApplication();
        }
    }
}