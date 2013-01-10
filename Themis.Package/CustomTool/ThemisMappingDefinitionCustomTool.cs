using System.Diagnostics;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TextTemplating.VSHost;

namespace Themis.Package.CustomTool
{
    [System.Runtime.InteropServices.Guid("198F783E-D695-4AF4-A4EC-FA83AA2212CB")]
    public class SampleDslCustomTool : TemplatedCodeGenerator
    {
        protected override byte[] GenerateCode(string inputFileName, string inputFileContent)
        {
            // The "inputFileContent" parameter the contains the contents of the 
            // file the custom tool is being run against. In this case, this means 
            // the contents of the model file.

            // However, we want to load the text template code from a resource
            // file instead. We need to specify the model file that should be
            // loaded when the template is run, so the text template code contains
            // a marker - we'll replace this marker with the name of the model file.

            const string modelFileNameMarker = "%MODELFILENAME%";
            const string resourceName =
                @"Themis.Package.CustomTool.ThemisMappingDefinition.tt";

            // Load the text template from the embedded resource
            string templateCode;
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
            {
                Debug.Assert(stream != null, "Error - could not find the resource");
                var reader = new StreamReader(stream);
                templateCode = reader.ReadToEnd();
                reader.Close();
            }

            Debug.Assert(
                templateCode.Contains(modelFileNameMarker),
                "Error - the template code does not contain the expected model file name marker");


            // Substitute the real model file name into the template code
            templateCode = templateCode.Replace(modelFileNameMarker, inputFileName);

            // Delegate the rest of the work to the base class.
            // This will run the T4 transformation and return the
            // result.
            return base.GenerateCode(inputFileName, templateCode);
        }
    }
}