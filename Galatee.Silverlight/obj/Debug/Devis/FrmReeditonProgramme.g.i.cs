﻿#pragma checksum "C:\Users\EDMSA\Documents\Galatee\Galatee.Silverlight\Devis\FrmReeditonProgramme.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5D3B58A35F7D0C42AAD3943BD5199A3C"
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


namespace Galatee.Silverlight.Accueil {
    
    
    public partial class FrmReeditonProgramme : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal SilverlightContrib.Controls.GroupBox Gbo_ListeDevis;
        
        internal System.Windows.Controls.DataGrid dtgrdParametre;
        
        internal System.Windows.Controls.Button CancelButton;
        
        internal System.Windows.Controls.ProgressBar prgBar;
        
        internal System.Windows.Controls.Button EditerButton;
        
        internal System.Windows.Controls.Button btn_RechercheClient;
        
        internal System.Windows.Controls.ComboBox cboEquipe;
        
        internal System.Windows.Controls.DatePicker dtProgramDeb;
        
        internal System.Windows.Controls.DatePicker dtProgramFin;
        
        internal System.Windows.Controls.TextBox Txt_NumeroProgramme;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Galatee.Silverlight;component/Devis/FrmReeditonProgramme.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.Gbo_ListeDevis = ((SilverlightContrib.Controls.GroupBox)(this.FindName("Gbo_ListeDevis")));
            this.dtgrdParametre = ((System.Windows.Controls.DataGrid)(this.FindName("dtgrdParametre")));
            this.CancelButton = ((System.Windows.Controls.Button)(this.FindName("CancelButton")));
            this.prgBar = ((System.Windows.Controls.ProgressBar)(this.FindName("prgBar")));
            this.EditerButton = ((System.Windows.Controls.Button)(this.FindName("EditerButton")));
            this.btn_RechercheClient = ((System.Windows.Controls.Button)(this.FindName("btn_RechercheClient")));
            this.cboEquipe = ((System.Windows.Controls.ComboBox)(this.FindName("cboEquipe")));
            this.dtProgramDeb = ((System.Windows.Controls.DatePicker)(this.FindName("dtProgramDeb")));
            this.dtProgramFin = ((System.Windows.Controls.DatePicker)(this.FindName("dtProgramFin")));
            this.Txt_NumeroProgramme = ((System.Windows.Controls.TextBox)(this.FindName("Txt_NumeroProgramme")));
        }
    }
}

