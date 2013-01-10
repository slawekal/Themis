using System;
using Microsoft.VSSDK.Tools.VsIdeTesting;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Themis.Package.IntegrationTests
{
    /// <summary>
    ///     Integration test for package validation
    /// </summary>
    [TestClass]
    public class PackageTest : BaseTest
    {
        [TestMethod]
        [HostType("VS IDE")]
        public void PackageLoadTest()
        {
            UIThreadInvoker.Invoke(
                (ThreadInvoker)
                delegate
                    {
                        //Get the Shell Service
                        var shellService =
                            VsIdeTestHostContext.ServiceProvider.GetService(typeof (SVsShell)) as IVsShell;
                        Assert.IsNotNull(shellService);

                        //Validate package load
                        IVsPackage package;
                        var packageGuid = new Guid(Constants.ThemisPackageId);
                        Assert.IsTrue(0 == shellService.LoadPackage(ref packageGuid, out package));
                        Assert.IsNotNull(package, "Package failed to load");
                    });
        }
    }
}