﻿#pragma checksum "E:\SOURCES\EDMSA - AQUATECH\Galatee_save\Galatee.Silverlight\Caisse\FrmEncaissementRegroupement.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BBD372CF28AFB2F97CA94D5B45C5B43B"
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


namespace Galatee.Silverlight.Caisse {
    
    
    public partial class FrmEncaissementRegroupement : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Button CancelButton;
        
        internal System.Windows.Controls.Button Btn_Payement;
        
        internal System.Windows.Controls.ComboBox Cbo_ListeClient;
        
        internal System.Windows.Controls.TextBox TxtNomClient;
        
        internal System.Windows.Controls.TextBox TxtAddress;
        
        internal System.Windows.Controls.DataGrid Lsv_ListFacture;
        
        internal System.Windows.Controls.Button BntNth;
        
        internal System.Windows.Controls.Button Bntall;
        
        internal System.Windows.Controls.Label label4;
        
        internal System.Windows.Controls.TextBox Txt_DateEncaissement;
        
        internal System.Windows.Controls.Label label5;
        
        internal System.Windows.Controls.TextBox Txt_TotalAPayer;
        
        internal System.Windows.Controls.ProgressBar progressBar1;
        
        internal System.Windows.Controls.Button button1;
        
        internal System.Windows.Controls.Button btn_Regroupement;
        
        internal System.Windows.Controls.TextBox txtCodeLabel;
        
        internal System.Windows.Controls.ComboBox cbo_Periode;
        
        internal System.Windows.Controls.ComboBox cbo_PeriodeRegroupement;
        
        internal System.Windows.Controls.Button btn_Periode;
        
        internal System.Windows.Controls.TextBox Txt_Periode;
        
        internal System.Windows.Controls.Button btn_Rechercher;
        
        internal System.Windows.Controls.TextBox txtCodeRegroupement;
        
        internal System.Windows.Controls.Button btn_Ajouter;
        
        internal System.Windows.Controls.Button btn_Supprimer;
        
        internal System.Windows.Controls.CheckBox chk_PaiementPartiel;
        
        internal System.Windows.Controls.TextBox txt_PaiementPartiel;
        
        internal System.Windows.Controls.TextBox Txt_MontantTotal;
        
        internal System.Windows.Controls.Button btn_SupprimerPeriode;
        
        internal System.Windows.Controls.CheckBox Chk_MT;
        
        internal System.Windows.Controls.CheckBox Chk_BT;
        
        internal System.Windows.Controls.ProgressBar prgBar;
        
        internal System.Windows.Controls.DataGrid Lsv_ListFactureFinal;
        
        internal System.Windows.Controls.Button btn_UnSeul;
        
        internal System.Windows.Controls.Button Bnt_DeselectUn;
        
        internal System.Windows.Controls.Button btn_ToutSelect;
        
        internal System.Windows.Controls.Button Bnt_DeselectAll;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Galatee.Silverlight;component/Caisse/FrmEncaissementRegroupement.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.CancelButton = ((System.Windows.Controls.Button)(this.FindName("CancelButton")));
            this.Btn_Payement = ((System.Windows.Controls.Button)(this.FindName("Btn_Payement")));
            this.Cbo_ListeClient = ((System.Windows.Controls.ComboBox)(this.FindName("Cbo_ListeClient")));
            this.TxtNomClient = ((System.Windows.Controls.TextBox)(this.FindName("TxtNomClient")));
            this.TxtAddress = ((System.Windows.Controls.TextBox)(this.FindName("TxtAddress")));
            this.Lsv_ListFacture = ((System.Windows.Controls.DataGrid)(this.FindName("Lsv_ListFacture")));
            this.BntNth = ((System.Windows.Controls.Button)(this.FindName("BntNth")));
            this.Bntall = ((System.Windows.Controls.Button)(this.FindName("Bntall")));
            this.label4 = ((System.Windows.Controls.Label)(this.FindName("label4")));
            this.Txt_DateEncaissement = ((System.Windows.Controls.TextBox)(this.FindName("Txt_DateEncaissement")));
            this.label5 = ((System.Windows.Controls.Label)(this.FindName("label5")));
            this.Txt_TotalAPayer = ((System.Windows.Controls.TextBox)(this.FindName("Txt_TotalAPayer")));
            this.progressBar1 = ((System.Windows.Controls.ProgressBar)(this.FindName("progressBar1")));
            this.button1 = ((System.Windows.Controls.Button)(this.FindName("button1")));
            this.btn_Regroupement = ((System.Windows.Controls.Button)(this.FindName("btn_Regroupement")));
            this.txtCodeLabel = ((System.Windows.Controls.TextBox)(this.FindName("txtCodeLabel")));
            this.cbo_Periode = ((System.Windows.Controls.ComboBox)(this.FindName("cbo_Periode")));
            this.cbo_PeriodeRegroupement = ((System.Windows.Controls.ComboBox)(this.FindName("cbo_PeriodeRegroupement")));
            this.btn_Periode = ((System.Windows.Controls.Button)(this.FindName("btn_Periode")));
            this.Txt_Periode = ((System.Windows.Controls.TextBox)(this.FindName("Txt_Periode")));
            this.btn_Rechercher = ((System.Windows.Controls.Button)(this.FindName("btn_Rechercher")));
            this.txtCodeRegroupement = ((System.Windows.Controls.TextBox)(this.FindName("txtCodeRegroupement")));
            this.btn_Ajouter = ((System.Windows.Controls.Button)(this.FindName("btn_Ajouter")));
            this.btn_Supprimer = ((System.Windows.Controls.Button)(this.FindName("btn_Supprimer")));
            this.chk_PaiementPartiel = ((System.Windows.Controls.CheckBox)(this.FindName("chk_PaiementPartiel")));
            this.txt_PaiementPartiel = ((System.Windows.Controls.TextBox)(this.FindName("txt_PaiementPartiel")));
            this.Txt_MontantTotal = ((System.Windows.Controls.TextBox)(this.FindName("Txt_MontantTotal")));
            this.btn_SupprimerPeriode = ((System.Windows.Controls.Button)(this.FindName("btn_SupprimerPeriode")));
            this.Chk_MT = ((System.Windows.Controls.CheckBox)(this.FindName("Chk_MT")));
            this.Chk_BT = ((System.Windows.Controls.CheckBox)(this.FindName("Chk_BT")));
            this.prgBar = ((System.Windows.Controls.ProgressBar)(this.FindName("prgBar")));
            this.Lsv_ListFactureFinal = ((System.Windows.Controls.DataGrid)(this.FindName("Lsv_ListFactureFinal")));
            this.btn_UnSeul = ((System.Windows.Controls.Button)(this.FindName("btn_UnSeul")));
            this.Bnt_DeselectUn = ((System.Windows.Controls.Button)(this.FindName("Bnt_DeselectUn")));
            this.btn_ToutSelect = ((System.Windows.Controls.Button)(this.FindName("btn_ToutSelect")));
            this.Bnt_DeselectAll = ((System.Windows.Controls.Button)(this.FindName("Bnt_DeselectAll")));
        }
    }
}

