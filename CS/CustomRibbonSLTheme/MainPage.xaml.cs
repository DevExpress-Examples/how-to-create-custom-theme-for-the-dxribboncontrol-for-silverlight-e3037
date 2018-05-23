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

namespace CustomRibbonSLTheme {
    public partial class MainPage : UserControl {
        public MainPage() {
            Theme theme = new Theme("CustomTheme") {  IsStandard = false, FullName = "Custom Theme for the RibbonControl" };
            ThemeManager.ApplicationTheme = theme;
            InitializeComponent();           
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            DXVisualizer.DXVisualTreeVisualizer.Show();
        }

    }         


}
