#pragma checksum "C:\SOURCES NOUVELLES\Galatee.Silverlight\Caisse\FrmPaiementDemande.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FBE4D4AC6B73536FCFD8DA16CDA14395"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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


namespace Galatee.Silverlight.Caisse {
    
    
    public partial class FrmPaiementDemande : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal SilverlightContrib.Controls.GroupBox gbo1;
        
        internal System.Windows.Controls.Button CancelButton;
        
        internal System.Windows.Controls.Button OKButton;
        
        internal System.Windows.Controls.TextBox Txt_NumeroDemande;
        
        internal System.Windows.Controls.TextBox Txt_NomClient;
        
        internal System.Windows.Controls.DataGrid LsvFacture;
        
        internal System.Windows.Controls.TextBox Txt_TotalHt;
        
        internal System.Windows.Controls.TextBox Txt_totalTaxe;
        
        internal System.Windows.Controls.TextBox Txt_TotalTTC;
        
        internal System.Windows.Controls.Label lbl_total;
        
        internal System.Windows.Controls.Label lbl_Nom;
        
        internal System.Windows.Controls.TextBox Txt_Client;
        
        internal System.Windows.Controls.Label lbl_RefClient;
        
        internal System.Windows.Controls.Label lbl_NumDemande;
        
        internal Galatee.Silverlight.Library.NumericTextBox txt_MontantPayes;
        
        internal System.Windows.Controls.Label label1;
        
        internal System.Windows.Controls.CheckBox Chk_DevisPrestation;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Galatee.Silverlight;component/Caisse/FrmPaiementDemande.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.gbo1 = ((SilverlightContrib.Controls.GroupBox)(this.FindName("gbo1")));
            this.CancelButton = ((System.Windows.Controls.Button)(this.FindName("CancelButton")));
            this.OKButton = ((System.Windows.Controls.Button)(this.FindName("OKButton")));
            this.Txt_NumeroDemande = ((System.Windows.Controls.TextBox)(this.FindName("Txt_NumeroDemande")));
            this.Txt_NomClient = ((System.Windows.Controls.TextBox)(this.FindName("Txt_NomClient")));
            this.LsvFacture = ((System.Windows.Controls.DataGrid)(this.FindName("LsvFacture")));
            this.Txt_TotalHt = ((System.Windows.Controls.TextBox)(this.FindName("Txt_TotalHt")));
            this.Txt_totalTaxe = ((System.Windows.Controls.TextBox)(this.FindName("Txt_totalTaxe")));
            this.Txt_TotalTTC = ((System.Windows.Controls.TextBox)(this.FindName("Txt_TotalTTC")));
            this.lbl_total = ((System.Windows.Controls.Label)(this.FindName("lbl_total")));
            this.lbl_Nom = ((System.Windows.Controls.Label)(this.FindName("lbl_Nom")));
            this.Txt_Client = ((System.Windows.Controls.TextBox)(this.FindName("Txt_Client")));
            this.lbl_RefClient = ((System.Windows.Controls.Label)(this.FindName("lbl_RefClient")));
            this.lbl_NumDemande = ((System.Windows.Controls.Label)(this.FindName("lbl_NumDemande")));
            this.txt_MontantPayes = ((Galatee.Silverlight.Library.NumericTextBox)(this.FindName("txt_MontantPayes")));
            this.label1 = ((System.Windows.Controls.Label)(this.FindName("label1")));
            this.Chk_DevisPrestation = ((System.Windows.Controls.CheckBox)(this.FindName("Chk_DevisPrestation")));
        }
    }
}

