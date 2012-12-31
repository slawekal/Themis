#region Using directives

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.ConstrainedExecution;

#endregion

//
// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
//
[assembly: AssemblyTitle(@"")]
[assembly: AssemblyDescription(@"")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(@"Sławomir Aleksiuk")]
[assembly: AssemblyProduct(@"Themis")]
[assembly: AssemblyCopyright("")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: System.Resources.NeutralResourcesLanguage("en")]

//
// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:

[assembly: AssemblyVersion(@"1.0.0.0")]
[assembly: ComVisible(false)]
[assembly: CLSCompliant(false)]
[assembly: ReliabilityContract(Consistency.MayCorruptProcess, Cer.None)]
[assembly:
    InternalsVisibleTo(
        "Themis.Package.IntegrationTests, PublicKey=0024000004800000940000000602000000240000525341310004000001000100e7a966d1f878b548c075117236081f1d2d23c320915fe6066e37f1dad860412de4aea330fd39879e5895974e1cce136f78f8ec398586fb8213df5eebf23cbf5cbead44df324c213bde05a80e8a9b72c3945a715f71c98291aa65e9efdb172dc7fd56ee1c1a900b9e526e0bf834661fd9161dc0e53e6b748fd4a1b343500cd6e7"
        )]
[assembly:
    InternalsVisibleTo(
        "Themis.Package.UnitTests, PublicKey=0024000004800000940000000602000000240000525341310004000001000100e7a966d1f878b548c075117236081f1d2d23c320915fe6066e37f1dad860412de4aea330fd39879e5895974e1cce136f78f8ec398586fb8213df5eebf23cbf5cbead44df324c213bde05a80e8a9b72c3945a715f71c98291aa65e9efdb172dc7fd56ee1c1a900b9e526e0bf834661fd9161dc0e53e6b748fd4a1b343500cd6e7"
        )]