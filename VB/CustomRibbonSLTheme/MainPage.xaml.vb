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
			Dim theme As New Theme("CustomTheme", New Uri("/DevExpress.Xpf.Themes.CustomRibbon.v11.1;component/Theme.xaml", UriKind.Relative))
			Theme.RegisterTheme(theme)
			'Theme theme = Theme.Office2007Black;
			ThemeManager.ApplicationTheme = theme
			InitializeComponent()
		End Sub
	End Class


End Namespace
