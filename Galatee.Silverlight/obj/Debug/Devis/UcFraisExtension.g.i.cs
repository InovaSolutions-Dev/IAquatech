﻿#pragma checksum "D:\PROJET IWEBS\IWEB\Galatee\Galatee.Silverlight\Devis\UcFraisExtension.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8163EEF6B9E1E8934CD73C5022BA278A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SilverlightContrib.Controls;
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


namespace Galatee.Silverlight.Devis {
    
    
    public partial class UcFraisExtension : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Button CancelButton;
        
        internal System.Windows.Controls.Button OKButton;
        
        internal SilverlightContrib.Controls.GroupBox Gbo_Frais;
        
        internal System.Windows.Controls.Label label1;
        
        internal System.Windows.Controls.TextBox Txt_Frais;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Galatee.Silverlight;component/Devis/UcFraisExtension.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.CancelButton = ((System.Windows.Controls.Button)(this.FindName("CancelButton")));
            this.OKButton = ((System.Windows.Controls.Button)(this.FindName("OKButton")));
            this.Gbo_Frais = ((SilverlightContrib.Controls.GroupBox)(this.FindName("Gbo_Frais")));
            this.label1 = ((System.Windows.Controls.Label)(this.FindName("label1")));
            this.Txt_Frais = ((System.Windows.Controls.TextBox)(this.FindName("Txt_Frais")));
        }
    }
}

