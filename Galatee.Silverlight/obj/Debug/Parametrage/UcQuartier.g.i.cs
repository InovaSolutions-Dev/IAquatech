﻿#pragma checksum "D:\PROJET IWEBS\IWEB\Galatee\Galatee.Silverlight\Parametrage\UcQuartier.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3B49CED398D6ED2040D31CBAB06635DE"
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


namespace Galatee.Silverlight.Parametrage {
    
    
    public partial class UcQuartier : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Label lab_Code;
        
        internal System.Windows.Controls.TextBox Txt_Code;
        
        internal System.Windows.Controls.Label lab_Libelle;
        
        internal System.Windows.Controls.TextBox Txt_Libelle;
        
        internal System.Windows.Controls.Button btnOk;
        
        internal System.Windows.Controls.Button Btn_Reinitialiser;
        
        internal SilverlightContrib.Controls.GroupBox GboCodeDepart;
        
        internal System.Windows.Controls.ComboBox CboCentre;
        
        internal System.Windows.Controls.ComboBox CboCommune;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Galatee.Silverlight;component/Parametrage/UcQuartier.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.lab_Code = ((System.Windows.Controls.Label)(this.FindName("lab_Code")));
            this.Txt_Code = ((System.Windows.Controls.TextBox)(this.FindName("Txt_Code")));
            this.lab_Libelle = ((System.Windows.Controls.Label)(this.FindName("lab_Libelle")));
            this.Txt_Libelle = ((System.Windows.Controls.TextBox)(this.FindName("Txt_Libelle")));
            this.btnOk = ((System.Windows.Controls.Button)(this.FindName("btnOk")));
            this.Btn_Reinitialiser = ((System.Windows.Controls.Button)(this.FindName("Btn_Reinitialiser")));
            this.GboCodeDepart = ((SilverlightContrib.Controls.GroupBox)(this.FindName("GboCodeDepart")));
            this.CboCentre = ((System.Windows.Controls.ComboBox)(this.FindName("CboCentre")));
            this.CboCommune = ((System.Windows.Controls.ComboBox)(this.FindName("CboCommune")));
        }
    }
}

