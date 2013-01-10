//using System;
//using System.Diagnostics;
//using Microsoft.VSSDK.Tools.VsIdeTesting;
//using Microsoft.VisualStudio.Shell.Interop;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//
//namespace Themis.Package.IntegrationTests
//{
//    /// <summary>
//    ///     Integration test for package validation
//    /// </summary>
//    [TestClass]
//    public class PackageTest : BaseTest
//    {
//        [TestMethod]
//        [HostType("VS IDE")]
//        public void PackageLoadTest()
//        {
//            UIThreadInvoker.Invoke(
//                (ThreadInvoker)
//                delegate
//                    {
//                        //Get the Shell Service
//                        var shellService =
//                            VsIdeTestHostContext.ServiceProvider.GetService(typeof (SVsShell)) as IVsShell;
//                        Assert.IsNotNull(shellService);
//
//                        //Validate package load
//                        IVsPackage package;
//                        var packageGuid = new Guid(Constants.ThemisPackageId);
//                        Debug.WriteLine(packageGuid);
//                        var loadPackage = shellService.LoadPackage(ref packageGuid, out package);
//                        Debug.WriteLine(loadPackage);
//                        Assert.IsTrue(0 == loadPackage);
//                        Assert.IsNotNull(package, "Package failed to load");
//                    });
//        }
//    }
//}