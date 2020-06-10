﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Microsoft.Win32;

using Shimakaze.ToolKit.CSF.GUI.ViewModel;
using Shimakaze.ToolKit.CSF.Kernel;

namespace Shimakaze.ToolKit.CSF.GUI
{
    /// <summary>
    /// Ribbon.xaml 的交互逻辑
    /// </summary>
    public partial class Ribbon
    {
        public Ribbon()
        {
            InitializeComponent();
            ChangeToggleButtonName(btnToggleTheme);
        }
        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            Theme.ThemeManager.IsDarkTheme = !Theme.ThemeManager.IsDarkTheme;
            ChangeToggleButtonName(sender);
        }
        private void ChangeToggleButtonName(object sender)
        {
            if (Theme.ThemeManager.IsDarkTheme)
                (sender as Fluent.Button).Header = "LightTheme";
            else
                (sender as Fluent.Button).Header = "DarkTheme";
        }
    }
}