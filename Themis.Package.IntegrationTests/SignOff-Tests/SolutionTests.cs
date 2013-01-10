using Microsoft.VSSDK.Tools.VsIdeTesting;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VsSDK.IntegrationTestLibrary;

namespace Themis.Package.IntegrationTests
{
    [TestClass]
    public class SolutionTests : BaseTest
    {
        [TestMethod]
        [HostType("VS IDE")]
        public void CreateEmptySolution()
        {
            UIThreadInvoker.Invoke(
                (ThreadInvoker)
                delegate
                    {
                        var testUtils = new TestUtils();
                        testUtils.CloseCurrentSolution(
                            __VSSLNSAVEOPTIONS.SLNSAVEOPT_NoSave);
                        testUtils.CreateEmptySolution(
                            TestContext.TestDir, "EmptySolution");
                    });
        }
    }
}