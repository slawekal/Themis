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
[assembly: CLSCompliant(true)]
[assembly: ReliabilityContract(Consistency.MayCorruptProcess, Cer.None)]

//
// Make the Dsl project internally visible to the DslPackage assembly
//
[assembly: InternalsVisibleTo(@"Themis.DslPackage, PublicKey=0024000004800000940000000602000000240000525341310004000001000100F31F4B9BC3E8E974D3DB838B2D549117EA97B31AB9D269DD568DF013FB4A5FE8348F508910AC61859B74601DBFDACC626226CD0C3337FDC7A00369C983566B8340FDF90056F7A08010209D6C3A1C457DA77CF3DA11BE383BB62E5B3E2D61EA0BF11E53875CB7DBCF27D1FF93E0AC47BF45B1FA49A60146F753A70052FD75918C")]