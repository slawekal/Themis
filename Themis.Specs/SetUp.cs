using NUnit.Framework;
using Themis.Specs.Infrastructure;

namespace Themis.Specs
{
    [SetUpFixture]
    public class SetUp
    {
        [SetUp]
        public void RunBeforeAnyTests()
        {
            ApplicationWrapper.Instance.StartApplication();
        }

        [TearDown]
        public void RunAfterAnyTests()
        {
            ApplicationWrapper.Instance.StopApplication();
        }
    }
}