using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Data;
using System.Collections.ObjectModel;
using DevExpress.Xpf.Core;

using System.Text;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace CustomRibbonSLTheme {
    public partial class MainPage: UserControl {
        public MainPage() {
            Theme theme = new Theme("CustomTheme", new Uri("/DevExpress.Xpf.Themes.CustomRibbon.v11.1;component/Theme.xaml", UriKind.Relative));
            Theme.RegisterTheme(theme);
            //Theme theme = Theme.Office2007Black;
            ThemeManager.ApplicationTheme = theme;
            InitializeComponent();
        }
    }


}
