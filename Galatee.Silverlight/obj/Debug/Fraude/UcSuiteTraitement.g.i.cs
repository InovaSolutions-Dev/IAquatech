﻿#pragma checksum "C:\Users\EDMSA\Documents\Galatee\Galatee.Silverlight\Fraude\UcSuiteTraitement.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CDE9BE8A2EEFC23B40BCBDA2C2FC83A5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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


namespace Galatee.Silverlight.Fraude {
    
    
    public partial class UcSuiteTraitement : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal SilverlightContrib.Controls.GroupBox Gbo_MontnatPrese_Copy;
        
        internal System.Windows.Controls.Button CancelButton;
        
        internal System.Windows.Controls.Button OKButton;
        
        internal System.Windows.Controls.TextBox txtProduit;
        
        internal System.Windows.Controls.TextBox txtTotal;
        
        internal System.Windows.Controls.CheckBox ckbControleIndex;
        
        internal System.Windows.Controls.CheckBox ckbCloture;
        
        internal System.Windows.Controls.CheckBox ckbForfait;
        
        internal System.Windows.Controls.TextBox txtForfait;
        
        internal System.Windows.Controls.DatePicker dtpDateLimite;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Galatee.Silverlight;component/Fraude/UcSuiteTraitement.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.Gbo_MontnatPrese_Copy = ((SilverlightContrib.Controls.GroupBox)(this.FindName("Gbo_MontnatPrese_Copy")));
            this.CancelButton = ((System.Windows.Controls.Button)(this.FindName("CancelButton")));
            this.OKButton = ((System.Windows.Controls.Button)(this.FindName("OKButton")));
            this.txtProduit = ((System.Windows.Controls.TextBox)(this.FindName("txtProduit")));
            this.txtTotal = ((System.Windows.Controls.TextBox)(this.FindName("txtTotal")));
            this.ckbControleIndex = ((System.Windows.Controls.CheckBox)(this.FindName("ckbControleIndex")));
            this.ckbCloture = ((System.Windows.Controls.CheckBox)(this.FindName("ckbCloture")));
            this.ckbForfait = ((System.Windows.Controls.CheckBox)(this.FindName("ckbForfait")));
            this.txtForfait = ((System.Windows.Controls.TextBox)(this.FindName("txtForfait")));
            this.dtpDateLimite = ((System.Windows.Controls.DatePicker)(this.FindName("dtpDateLimite")));
        }
    }
}

