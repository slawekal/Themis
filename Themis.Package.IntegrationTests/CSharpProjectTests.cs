using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Themis.Package.IntegrationTests
{
    [TestClass]
    public class CSharpProjectTests : BaseTest
    {
        protected override string Language
        {
            get { return "CSharp"; }
        }

        [TestMethod]
        [HostType("VS IDE")]
        public void WinformsApplication()
        {
            InNewWebFormProject(testUtils => { });
        }
    }
}