﻿#pragma checksum "F:\SOURCES\AQUATECH\Galatee_save\Galatee.Silverlight\InterfaceComptable\FrmGeneration.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "09CF9C8D7BDCECD0BC2CADBCEF8E04E5"
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


namespace Galatee.Silverlight.InterfaceComptable {
    
    
    public partial class FrmGeneration : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal SilverlightContrib.Controls.GroupBox groupBox2;
        
        internal SilverlightContrib.Controls.GroupBox groupBox2_Copy;
        
        internal System.Windows.Controls.ComboBox CmbSite;
        
        internal System.Windows.Controls.Button CancelButton;
        
        internal System.Windows.Controls.RadioButton RdbDate;
        
        internal System.Windows.Controls.RadioButton RdbIntervalle;
        
        internal System.Windows.Controls.DatePicker dtpDateDebut;
        
        internal System.Windows.Controls.DatePicker dtpDateFin;
        
        internal System.Windows.Controls.ComboBox CmbCaisse;
        
        internal System.Windows.Controls.DatePicker dtpDateCaisse;
        
        internal System.Windows.Controls.TabItem TBOperationClient;
        
        internal System.Windows.Controls.DataGrid DTOperationClientele;
        
        internal System.Windows.Controls.TextBox txt_total;
        
        internal System.Windows.Controls.TabItem TBEcritureComptable;
        
        internal System.Windows.Controls.DataGrid DTEcritureComptableFacture;
        
        internal System.Windows.Controls.TextBox txt_Debit;
        
        internal System.Windows.Controls.TextBox txt_Credit;
        
        internal System.Windows.Controls.Button ValiderButton;
        
        internal System.Windows.Controls.Button GenererButton;
        
        internal System.Windows.Controls.Button EditerButton;
        
        internal System.Windows.Controls.ComboBox cmbCentre;
        
        internal System.Windows.Controls.Button btnOpertaion;
        
        internal System.Windows.Controls.ComboBox CmbOperation;
        
        internal System.Windows.Controls.RadioButton rdbEncaisse;
        
        internal System.Windows.Controls.RadioButton rdbFacture;
        
        internal System.Windows.Controls.RadioButton rdbDecaissement;
        
        internal System.Windows.Controls.CheckBox Chk_TouteCaisse;
        
        internal System.Windows.Controls.ProgressBar prgBar;
        
        internal System.Windows.Controls.CheckBox Chk_Mt;
        
        internal System.Windows.Controls.CheckBox Chk_Bt;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Galatee.Silverlight;component/InterfaceComptable/FrmGeneration.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.groupBox2 = ((SilverlightContrib.Controls.GroupBox)(this.FindName("groupBox2")));
            this.groupBox2_Copy = ((SilverlightContrib.Controls.GroupBox)(this.FindName("groupBox2_Copy")));
            this.CmbSite = ((System.Windows.Controls.ComboBox)(this.FindName("CmbSite")));
            this.CancelButton = ((System.Windows.Controls.Button)(this.FindName("CancelButton")));
            this.RdbDate = ((System.Windows.Controls.RadioButton)(this.FindName("RdbDate")));
            this.RdbIntervalle = ((System.Windows.Controls.RadioButton)(this.FindName("RdbIntervalle")));
            this.dtpDateDebut = ((System.Windows.Controls.DatePicker)(this.FindName("dtpDateDebut")));
            this.dtpDateFin = ((System.Windows.Controls.DatePicker)(this.FindName("dtpDateFin")));
            this.CmbCaisse = ((System.Windows.Controls.ComboBox)(this.FindName("CmbCaisse")));
            this.dtpDateCaisse = ((System.Windows.Controls.DatePicker)(this.FindName("dtpDateCaisse")));
            this.TBOperationClient = ((System.Windows.Controls.TabItem)(this.FindName("TBOperationClient")));
            this.DTOperationClientele = ((System.Windows.Controls.DataGrid)(this.FindName("DTOperationClientele")));
            this.txt_total = ((System.Windows.Controls.TextBox)(this.FindName("txt_total")));
            this.TBEcritureComptable = ((System.Windows.Controls.TabItem)(this.FindName("TBEcritureComptable")));
            this.DTEcritureComptableFacture = ((System.Windows.Controls.DataGrid)(this.FindName("DTEcritureComptableFacture")));
            this.txt_Debit = ((System.Windows.Controls.TextBox)(this.FindName("txt_Debit")));
            this.txt_Credit = ((System.Windows.Controls.TextBox)(this.FindName("txt_Credit")));
            this.ValiderButton = ((System.Windows.Controls.Button)(this.FindName("ValiderButton")));
            this.GenererButton = ((System.Windows.Controls.Button)(this.FindName("GenererButton")));
            this.EditerButton = ((System.Windows.Controls.Button)(this.FindName("EditerButton")));
            this.cmbCentre = ((System.Windows.Controls.ComboBox)(this.FindName("cmbCentre")));
            this.btnOpertaion = ((System.Windows.Controls.Button)(this.FindName("btnOpertaion")));
            this.CmbOperation = ((System.Windows.Controls.ComboBox)(this.FindName("CmbOperation")));
            this.rdbEncaisse = ((System.Windows.Controls.RadioButton)(this.FindName("rdbEncaisse")));
            this.rdbFacture = ((System.Windows.Controls.RadioButton)(this.FindName("rdbFacture")));
            this.rdbDecaissement = ((System.Windows.Controls.RadioButton)(this.FindName("rdbDecaissement")));
            this.Chk_TouteCaisse = ((System.Windows.Controls.CheckBox)(this.FindName("Chk_TouteCaisse")));
            this.prgBar = ((System.Windows.Controls.ProgressBar)(this.FindName("prgBar")));
            this.Chk_Mt = ((System.Windows.Controls.CheckBox)(this.FindName("Chk_Mt")));
            this.Chk_Bt = ((System.Windows.Controls.CheckBox)(this.FindName("Chk_Bt")));
        }
    }
}

