﻿#pragma checksum "c:\users\kai.chen\documents\visual studio 2012\Projects\PictureMemoryUsageDemo\PictureMemoryUsageDemo\Views\StartPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "08E7850696EB1F2BD4A5198B04EC97A9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace PictureMemoryUsageDemo.Views {
    
    
    public partial class StartPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Button StartToTrip_BT;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton LogRecord_AP;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/PictureMemoryUsageDemo;component/Views/StartPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.StartToTrip_BT = ((System.Windows.Controls.Button)(this.FindName("StartToTrip_BT")));
            this.LogRecord_AP = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("LogRecord_AP")));
        }
    }
}
