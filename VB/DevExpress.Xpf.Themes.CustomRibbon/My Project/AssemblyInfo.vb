Imports Microsoft.VisualBasic
Imports System.Windows.Markup
Imports System.Resources
#If (Not SL) Then
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows
Imports System
Imports System.Security
Imports DevExpress.Utils
Imports DevExpress.Xpf.Core.Native

#Else
Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports DevExpress.Internal
Imports System.Runtime.CompilerServices
#End If
' General Information about an assembly is controlled through the following 
' set of attributes. Change these attribute values to modify the information
' associated with an assembly.
<Assembly: AssemblyDescription("Xpf.Core Library")>
<Assembly: AssemblyConfiguration("")>
<Assembly: AssemblyCompany("Developer Express Inc.")>
<Assembly: AssemblyProduct("DevExpress.Xpf.Themes.CustomRibbon.Theme")>
<Assembly: AssemblyCopyright(AssemblyInfo.AssemblyCopyright)>
<Assembly: AssemblyTrademark("")>
<Assembly: AssemblyCulture("")>
<Assembly: CLSCompliant(True)>
#If (Not SL) Then
<Assembly: AllowPartiallyTrustedCallers>
<Assembly: ThemeInfo(ResourceDictionaryLocation.None, ResourceDictionaryLocation.SourceAssembly)>
#End If
<Assembly: SatelliteContractVersion(AssemblyInfo.SatelliteContractVersion)>

' Setting ComVisible to false makes the types in this assembly not visible 
' to COM components.  If you need to access a type in this assembly from 
' COM, set the ComVisible attribute to true on that type.
<Assembly: ComVisible(False)>

<Assembly: Guid("4E99E381-22BA-4A62-8F3C-0292A924FBEC")>

'In order to begin building localizable applications, set 
'<UICulture>CultureYouAreCodingWith</UICulture> in your .csproj file
'inside a <PropertyGroup>.  For example, if you are using US english
'in your source files, set the <UICulture> to en-US.  Then uncomment
'the NeutralResourceLanguage attribute below.  Update the "en-US" in
'the line below to match the UICulture setting in the project file.

'[assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.Satellite)]



' Version information for an assembly consists of the following four values:
'
'      Major Version
'      Minor Version 
'      Build Number
'      Revision
'
' You can specify all the values or you can default the Build and Revision Numbers 
' by using the '*' as shown below:
' [assembly: AssemblyVersion("1.0.*")]
<Assembly: AssemblyVersion(AssemblyInfo.Version)>
<Assembly: AssemblyFileVersion(AssemblyInfo.FileVersion)>
'INSTANT VB TODO TASK: There is no equivalent to #pragma directives in VB.NET:
'#pragma warning disable 1699
#If (Not SL) Then
<Assembly: ToolboxTabName(AssemblyInfo.DXTabWpfCommon)>
<Assembly: AssemblyKeyFile("")>
<Assembly: AssemblyDelaySign(False)>
<Assembly: AssemblyKeyName("")>
#End If
'INSTANT VB TODO TASK: There is no equivalent to #pragma directives in VB.NET:
'#pragma warning restore 1699
