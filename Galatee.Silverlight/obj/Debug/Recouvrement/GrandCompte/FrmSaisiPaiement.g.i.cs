﻿#pragma checksum "D:\PROJET IWEBS\IWEB\Galatee\Galatee.Silverlight\Recouvrement\GrandCompte\FrmSaisiPaiement.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D26999FF75C34C9427E31EE3B5407F90"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
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


namespace Galatee.Silverlight.Recouvrement {
    
    
    public partial class FrmSaisiPaiement : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Button CancelButton;
        
        internal System.Windows.Controls.Button OKButton;
        
        internal System.Windows.Controls.TextBox txt_montant;
        
        internal System.Windows.Controls.ComboBox cbo_regroupement;
        
        internal System.Windows.Controls.DataGrid dg_campagne;
        
        internal System.Windows.Controls.DataGrid dg_facture;
        
        internal System.Windows.Controls.DataPager datapager;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Galatee.Silverlight;component/Recouvrement/GrandCompte/FrmSaisiPaiement.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.CancelButton = ((System.Windows.Controls.Button)(this.FindName("CancelButton")));
            this.OKButton = ((System.Windows.Controls.Button)(this.FindName("OKButton")));
            this.txt_montant = ((System.Windows.Controls.TextBox)(this.FindName("txt_montant")));
            this.cbo_regroupement = ((System.Windows.Controls.ComboBox)(this.FindName("cbo_regroupement")));
            this.dg_campagne = ((System.Windows.Controls.DataGrid)(this.FindName("dg_campagne")));
            this.dg_facture = ((System.Windows.Controls.DataGrid)(this.FindName("dg_facture")));
            this.datapager = ((System.Windows.Controls.DataPager)(this.FindName("datapager")));
        }
    }
}
