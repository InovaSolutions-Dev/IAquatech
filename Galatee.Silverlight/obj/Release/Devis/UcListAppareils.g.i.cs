﻿#pragma checksum "C:\Users\EDMSA\Documents\EDM\New\new\New\IWEB EN COURS\Galatee\Galatee.Silverlight\Devis\UcListAppareils.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1C413FF82B00B823A9C9C2E37597FFD7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.36366
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Galatee.Silverlight.Library;
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
    
    
    public partial class UcListAppareils : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal SilverlightContrib.Controls.GroupBox Gbo_InformationDevis;
        
        internal System.Windows.Controls.Button CancelButton;
        
        internal System.Windows.Controls.Button OKButton;
        
        internal System.Windows.Controls.Label label1;
        
        internal System.Windows.Controls.DataGrid dtgAppareils;
        
        internal Galatee.Silverlight.Library.NumericTextBox Txt_Nombre;
        
        internal System.Windows.Controls.Label label1_Copy;
        
        internal Galatee.Silverlight.Library.NumericTextBox Txt_PuissanceGlobale;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Galatee.Silverlight;component/Devis/UcListAppareils.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.Gbo_InformationDevis = ((SilverlightContrib.Controls.GroupBox)(this.FindName("Gbo_InformationDevis")));
            this.CancelButton = ((System.Windows.Controls.Button)(this.FindName("CancelButton")));
            this.OKButton = ((System.Windows.Controls.Button)(this.FindName("OKButton")));
            this.label1 = ((System.Windows.Controls.Label)(this.FindName("label1")));
            this.dtgAppareils = ((System.Windows.Controls.DataGrid)(this.FindName("dtgAppareils")));
            this.Txt_Nombre = ((Galatee.Silverlight.Library.NumericTextBox)(this.FindName("Txt_Nombre")));
            this.label1_Copy = ((System.Windows.Controls.Label)(this.FindName("label1_Copy")));
            this.Txt_PuissanceGlobale = ((Galatee.Silverlight.Library.NumericTextBox)(this.FindName("Txt_PuissanceGlobale")));
        }
    }
}

