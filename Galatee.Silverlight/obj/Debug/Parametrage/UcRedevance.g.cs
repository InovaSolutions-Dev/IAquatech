﻿#pragma checksum "D:\PROJET IWEBS\IWEB\Galatee\Galatee.Silverlight\Parametrage\UcRedevance.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B4F0A0FE65515A5C2D247868F75C9EEF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
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


namespace Galatee.Silverlight.Parametrage {
    
    
    public partial class UcRedevance : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Label lab_Libelle;
        
        internal System.Windows.Controls.TextBox Txt_Libelle;
        
        internal SilverlightContrib.Controls.GroupBox GboCodeDepart;
        
        internal System.Windows.Controls.ComboBox CboCentre;
        
        internal System.Windows.Controls.ComboBox CboProduit;
        
        internal System.Windows.Controls.Label lab_Code;
        
        internal Galatee.Silverlight.Library.NumericTextBox Txt_Redevance;
        
        internal System.Windows.Controls.TextBox TxtTranche;
        
        internal System.Windows.Controls.Button btnOk;
        
        internal System.Windows.Controls.Button Btn_Reinitialiser;
        
        internal System.Windows.Controls.ComboBox CboNatureClient;
        
        internal System.Windows.Controls.CheckBox ChkExoneree;
        
        internal System.Windows.Controls.CheckBox ChkEditable;
        
        internal System.Windows.Controls.ComboBox CboLienRedevance;
        
        internal System.Windows.Controls.TextBox TxtParametre1;
        
        internal System.Windows.Controls.TextBox TxtParametre2;
        
        internal System.Windows.Controls.TextBox TxtParametre3;
        
        internal System.Windows.Controls.TextBox TxtParametre4;
        
        internal System.Windows.Controls.TextBox TxtParametre5;
        
        internal System.Windows.Controls.TextBox TxtParametre6;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Galatee.Silverlight;component/Parametrage/UcRedevance.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.lab_Libelle = ((System.Windows.Controls.Label)(this.FindName("lab_Libelle")));
            this.Txt_Libelle = ((System.Windows.Controls.TextBox)(this.FindName("Txt_Libelle")));
            this.GboCodeDepart = ((SilverlightContrib.Controls.GroupBox)(this.FindName("GboCodeDepart")));
            this.CboCentre = ((System.Windows.Controls.ComboBox)(this.FindName("CboCentre")));
            this.CboProduit = ((System.Windows.Controls.ComboBox)(this.FindName("CboProduit")));
            this.lab_Code = ((System.Windows.Controls.Label)(this.FindName("lab_Code")));
            this.Txt_Redevance = ((Galatee.Silverlight.Library.NumericTextBox)(this.FindName("Txt_Redevance")));
            this.TxtTranche = ((System.Windows.Controls.TextBox)(this.FindName("TxtTranche")));
            this.btnOk = ((System.Windows.Controls.Button)(this.FindName("btnOk")));
            this.Btn_Reinitialiser = ((System.Windows.Controls.Button)(this.FindName("Btn_Reinitialiser")));
            this.CboNatureClient = ((System.Windows.Controls.ComboBox)(this.FindName("CboNatureClient")));
            this.ChkExoneree = ((System.Windows.Controls.CheckBox)(this.FindName("ChkExoneree")));
            this.ChkEditable = ((System.Windows.Controls.CheckBox)(this.FindName("ChkEditable")));
            this.CboLienRedevance = ((System.Windows.Controls.ComboBox)(this.FindName("CboLienRedevance")));
            this.TxtParametre1 = ((System.Windows.Controls.TextBox)(this.FindName("TxtParametre1")));
            this.TxtParametre2 = ((System.Windows.Controls.TextBox)(this.FindName("TxtParametre2")));
            this.TxtParametre3 = ((System.Windows.Controls.TextBox)(this.FindName("TxtParametre3")));
            this.TxtParametre4 = ((System.Windows.Controls.TextBox)(this.FindName("TxtParametre4")));
            this.TxtParametre5 = ((System.Windows.Controls.TextBox)(this.FindName("TxtParametre5")));
            this.TxtParametre6 = ((System.Windows.Controls.TextBox)(this.FindName("TxtParametre6")));
        }
    }
}
