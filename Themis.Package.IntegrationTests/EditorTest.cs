
#warning Reuse below code and then delete it

//using Microsoft.VSSDK.Tools.VsIdeTesting;
//using Microsoft.VisualStudio.Shell.Interop;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Microsoft.VsSDK.IntegrationTestLibrary;
//
//namespace Themis.Package.IntegrationTests
//{
//    [TestClass]
//    public class EditorTest : BaseTest
//    {
//        /// <summary>
//        ///     A test for opening the editor
//        /// </summary>
//        [TestMethod]
//        [HostType("VS IDE")]
//        public void ValidateNewFileOpenedWithEditor()
//        {
//            UIThreadInvoker.Invoke(
//                (ThreadInvoker)
//                delegate
//                    {
//                        var testUtils = new TestUtils();
//                        testUtils.CloseCurrentSolution(__VSSLNSAVEOPTIONS.SLNSAVEOPT_NoSave);
//                        testUtils.CreateEmptySolution(TestContext.TestDir, "CreateEmptySolution");
//
//                        //Add new file to the solution and save all
//                        const string name = "mynewfile";
//                        EnvDTE.DTE dte = VsIdeTestHostContext.Dte;
//                        EnvDTE.Window win =
//                            dte.ItemOperations.NewFile(
//                                @"Themis Mappings Editor Files\Themis Mappings Editor", name);
//                        Assert.IsNotNull(win);
//                        dte.ExecuteCommand("File.SaveAll", string.Empty);
//
//                        //get the currect misc files state
//                        var property =
//                            dte.Properties["Environment", "Documents"]
//                                .Item("MiscFilesProjectSavesLastNItems");
//                        object originalValueMiscFilesSavesLastNItems = property.Value;
//                        if (originalValueMiscFilesSavesLastNItems != null &&
//                            (int) originalValueMiscFilesSavesLastNItems == 0)
//                        {
//                            property.Value = 5;
//                        }
//
//                        //get a handle to the project item in the solution explorer
//                        EnvDTE.ProjectItem item = win.Document.ProjectItem;
//                        Assert.IsNotNull(item);
//
//                        //close window
//                        win.Close();
//
//                        //reset the miscfiles property if it was modified
//                        property =
//                            dte.Properties["Environment", "Documents"]
//                                .Item("MiscFilesProjectSavesLastNItems");
//                        if (property != null &&
//                            originalValueMiscFilesSavesLastNItems != property.Value)
//                        {
//                            property.Value = originalValueMiscFilesSavesLastNItems;
//                        }
//                    });
//        }
//    }
//}