' Developer Express Code Central Example:
' How to create custom theme for the DXRibbonControl for Silverlight
' 
' The main idea is to copy our theme templates, and accurately modify our
' templates.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E3037


Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports System.Windows.Data
Imports System.Collections.ObjectModel
Imports DevExpress.Xpf.Core

Imports System.Text
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation

Namespace CustomRibbonSLTheme
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			Dim theme As New Theme("CustomTheme", New Uri("/DevExpress.Xpf.Themes.CustomRibbon.v11.2;component/Theme.xaml", UriKind.Relative))
			Theme.RegisterTheme(theme)
			'Theme theme = Theme.Office2007Black;
			ThemeManager.ApplicationTheme = theme
			InitializeComponent()
		End Sub
	End Class


End Namespace
