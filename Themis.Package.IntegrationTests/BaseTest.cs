using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Themis.Package.IntegrationTests
{
    public abstract class BaseTest
    {
        protected delegate void ThreadInvoker();

        /// <summary>
        ///     Gets or sets the test context which provides
        ///     information about and functionality for the current test run.
        /// </summary>
        public TestContext TestContext { get; set; }
    }
}