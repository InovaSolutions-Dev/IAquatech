#pragma checksum "F:\SOURCES\AQUATECH\Galatee_save\Galatee.Silverlight\Scelles\UcAffectationCompteur.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F2F9684DBBE75BD53F89B05B8D649AC7"
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


namespace Galatee.Silverlight.Scelles {
    
    
    public partial class UcAffectationCompteur : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Button Fermer;
        
        internal System.Windows.Controls.Button OKButton;
        
        internal SilverlightContrib.Controls.GroupBox groupBox;
        
        internal System.Windows.Controls.Button Charger;
        
        internal System.Windows.Controls.Button Decharger;
        
        internal System.Windows.Controls.Button chargerTout;
        
        internal System.Windows.Controls.Button DechargerTout;
        
        internal System.Windows.Controls.DataGrid dgCompteur;
        
        internal System.Windows.Controls.DataGrid dgMargasinVirtuelle;
        
        internal SilverlightContrib.Controls.GroupBox Gbo_InformationDevis;
        
        internal System.Windows.Controls.Label label2;
        
        internal System.Windows.Controls.TextBox txtSite;
        
        internal System.Windows.Controls.ComboBox Cbo_Site;
        
        internal System.Windows.Controls.Label label3;
        
        internal System.Windows.Controls.TextBox txtCentre;
        
        internal System.Windows.Controls.ComboBox Cbo_Centre;
        
        internal System.Windows.Controls.ComboBox Cbo_Produit;
        
        internal System.Windows.Controls.CheckBox chb_SaisiNombreCompteurSouhaite;
        
        internal System.Windows.Controls.TextBox txt_NombreCompteurSouhaite;
        
        internal System.Windows.Controls.Label lbl_Debut;
        
        internal System.Windows.Controls.TextBox txt_DebutNumCompteur;
        
        internal System.Windows.Controls.Label lbl_Fin;
        
        internal System.Windows.Controls.TextBox txt_FinNumCompteur;
        
        internal System.Windows.Controls.Button btn_Rafraichir;
        
        internal System.Windows.Controls.ProgressBar progressBar1;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Galatee.Silverlight;component/Scelles/UcAffectationCompteur.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.Fermer = ((System.Windows.Controls.Button)(this.FindName("Fermer")));
            this.OKButton = ((System.Windows.Controls.Button)(this.FindName("OKButton")));
            this.groupBox = ((SilverlightContrib.Controls.GroupBox)(this.FindName("groupBox")));
            this.Charger = ((System.Windows.Controls.Button)(this.FindName("Charger")));
            this.Decharger = ((System.Windows.Controls.Button)(this.FindName("Decharger")));
            this.chargerTout = ((System.Windows.Controls.Button)(this.FindName("chargerTout")));
            this.DechargerTout = ((System.Windows.Controls.Button)(this.FindName("DechargerTout")));
            this.dgCompteur = ((System.Windows.Controls.DataGrid)(this.FindName("dgCompteur")));
            this.dgMargasinVirtuelle = ((System.Windows.Controls.DataGrid)(this.FindName("dgMargasinVirtuelle")));
            this.Gbo_InformationDevis = ((SilverlightContrib.Controls.GroupBox)(this.FindName("Gbo_InformationDevis")));
            this.label2 = ((System.Windows.Controls.Label)(this.FindName("label2")));
            this.txtSite = ((System.Windows.Controls.TextBox)(this.FindName("txtSite")));
            this.Cbo_Site = ((System.Windows.Controls.ComboBox)(this.FindName("Cbo_Site")));
            this.label3 = ((System.Windows.Controls.Label)(this.FindName("label3")));
            this.txtCentre = ((System.Windows.Controls.TextBox)(this.FindName("txtCentre")));
            this.Cbo_Centre = ((System.Windows.Controls.ComboBox)(this.FindName("Cbo_Centre")));
            this.Cbo_Produit = ((System.Windows.Controls.ComboBox)(this.FindName("Cbo_Produit")));
            this.chb_SaisiNombreCompteurSouhaite = ((System.Windows.Controls.CheckBox)(this.FindName("chb_SaisiNombreCompteurSouhaite")));
            this.txt_NombreCompteurSouhaite = ((System.Windows.Controls.TextBox)(this.FindName("txt_NombreCompteurSouhaite")));
            this.lbl_Debut = ((System.Windows.Controls.Label)(this.FindName("lbl_Debut")));
            this.txt_DebutNumCompteur = ((System.Windows.Controls.TextBox)(this.FindName("txt_DebutNumCompteur")));
            this.lbl_Fin = ((System.Windows.Controls.Label)(this.FindName("lbl_Fin")));
            this.txt_FinNumCompteur = ((System.Windows.Controls.TextBox)(this.FindName("txt_FinNumCompteur")));
            this.btn_Rafraichir = ((System.Windows.Controls.Button)(this.FindName("btn_Rafraichir")));
            this.progressBar1 = ((System.Windows.Controls.ProgressBar)(this.FindName("progressBar1")));
        }
    }
}

