﻿#pragma checksum "E:\SOURCES\EDMSA - AQUATECH\Galatee_save\Galatee.Silverlight\Devis\UcAbonnePicker.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E20308BE353FE12438AB81C34E9EA0A0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
    
    
    public partial class UcAbonnePicker : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Button BtnCancel;
        
        internal System.Windows.Controls.Button BtnOK;
        
        internal System.Windows.Controls.Label Lab_Client;
        
        internal System.Windows.Controls.TextBox Txt_Client;
        
        internal System.Windows.Controls.Label Lab_Nom;
        
        internal System.Windows.Controls.TextBox Txt_Nom;
        
        internal System.Windows.Controls.Label Lab_Centre;
        
        internal System.Windows.Controls.TextBox Txt_Centre;
        
        internal System.Windows.Controls.ComboBox Cbo_Centre;
        
        internal System.Windows.Controls.Button Btn_search;
        
        internal System.Windows.Controls.Button Btn_reset;
        
        internal System.Windows.Controls.DataGrid Dtg_abonne;
        
        internal System.Windows.Controls.BusyIndicator busyIndicator;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Galatee.Silverlight;component/Devis/UcAbonnePicker.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.BtnCancel = ((System.Windows.Controls.Button)(this.FindName("BtnCancel")));
            this.BtnOK = ((System.Windows.Controls.Button)(this.FindName("BtnOK")));
            this.Lab_Client = ((System.Windows.Controls.Label)(this.FindName("Lab_Client")));
            this.Txt_Client = ((System.Windows.Controls.TextBox)(this.FindName("Txt_Client")));
            this.Lab_Nom = ((System.Windows.Controls.Label)(this.FindName("Lab_Nom")));
            this.Txt_Nom = ((System.Windows.Controls.TextBox)(this.FindName("Txt_Nom")));
            this.Lab_Centre = ((System.Windows.Controls.Label)(this.FindName("Lab_Centre")));
            this.Txt_Centre = ((System.Windows.Controls.TextBox)(this.FindName("Txt_Centre")));
            this.Cbo_Centre = ((System.Windows.Controls.ComboBox)(this.FindName("Cbo_Centre")));
            this.Btn_search = ((System.Windows.Controls.Button)(this.FindName("Btn_search")));
            this.Btn_reset = ((System.Windows.Controls.Button)(this.FindName("Btn_reset")));
            this.Dtg_abonne = ((System.Windows.Controls.DataGrid)(this.FindName("Dtg_abonne")));
            this.busyIndicator = ((System.Windows.Controls.BusyIndicator)(this.FindName("busyIndicator")));
        }
    }
}

