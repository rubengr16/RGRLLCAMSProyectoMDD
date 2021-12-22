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
[assembly: AssemblyCompany(@"UPM_IPS")]
[assembly: AssemblyProduct(@"RGRLLCAMSProyectoMDD")]
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
[assembly: InternalsVisibleTo(@"UPM_IPS.RGRLLCAMSProyectoMDD.DslPackage, PublicKey=0024000004800000940000000602000000240000525341310004000001000100514B1267F702D18B4F4FAF9BCEBD2C6BA253403332B6A2C20848134854CA82EA64C06350244D42610A561C6ADA10384C7050247A0A21EF4545ECE902C05B04903433BDA893D2A63135CF604CD1A2BCDFAE7F9966D6F43729DBF2C2720B626E8A101E35FC9D36C6C60A2956CB1E26266C7C884694EB9E76F71FD421848647F9C5")]