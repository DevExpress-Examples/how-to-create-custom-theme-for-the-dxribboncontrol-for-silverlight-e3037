using System.Windows.Markup;
using System.Resources;
#if !SL
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System;
using System.Security;
using DevExpress.Utils;
using DevExpress.Xpf.Core.Native;

#else
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using DevExpress.Internal;
using System.Runtime.CompilerServices;
#endif
// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyDescription("Xpf.Core Library")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Developer Express Inc.")]
[assembly: AssemblyProduct("DevExpress.Xpf.Themes.CustomRibbon.Theme")]
[assembly: AssemblyCopyright(AssemblyInfo.AssemblyCopyright)]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: CLSCompliant(true)]
#if !SL
[assembly: AllowPartiallyTrustedCallers]
[assembly: ThemeInfo(ResourceDictionaryLocation.None, ResourceDictionaryLocation.SourceAssembly)]
#endif
[assembly: SatelliteContractVersion(AssemblyInfo.SatelliteContractVersion)]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

[assembly: Guid("4E99E381-22BA-4A62-8F3C-0292A924FBEC")]

//In order to begin building localizable applications, set 
//<UICulture>CultureYouAreCodingWith</UICulture> in your .csproj file
//inside a <PropertyGroup>.  For example, if you are using US english
//in your source files, set the <UICulture> to en-US.  Then uncomment
//the NeutralResourceLanguage attribute below.  Update the "en-US" in
//the line below to match the UICulture setting in the project file.

//[assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.Satellite)]



// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion(AssemblyInfo.Version)]
[assembly: AssemblyFileVersion(AssemblyInfo.FileVersion)]
#pragma warning disable 1699
#if !SL
[assembly: ToolboxTabName(AssemblyInfo.DXTabWpfCommon)]
[assembly: AssemblyKeyFile(@"")]
[assembly: AssemblyDelaySign(false)]
[assembly: AssemblyKeyName("")]
#endif
#pragma warning restore 1699
