using Microsoft.VisualStudio.TextTemplating.VSHost;

namespace Themis.Package.CustomTool
{
    [ProvideCodeGenerator(typeof (SampleDslCustomTool), "ThemisMappingDefinitionCustomTool",
        "Generates output directly from a Themis mapping definition file", true,
        ProjectSystem = ProvideCodeGeneratorAttribute.CSharpProjectGuid)]
    [ProvideCodeGenerator(typeof (SampleDslCustomTool), "ThemisMappingDefinitionCustomTool",
        "Generates output directly from a Themis mapping definition file", true,
        ProjectSystem = ProvideCodeGeneratorAttribute.VisualBasicProjectGuid)]
    internal class ThemisMappingDefinitionCustomToolLanguagePackage
    {
    }
}