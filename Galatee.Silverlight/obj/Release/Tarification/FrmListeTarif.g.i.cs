#pragma checksum "F:\SOURCES\AQUATECH\Galatee_save\Galatee.Silverlight\Tarification\FrmListeTarif.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EBB87C3E805F9D2BBA67791183256B14"
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


namespace Galatee.Silverlight.Tarification {
    
    
    public partial class FrmListeTarif : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal SilverlightContrib.Controls.GroupBox groupBox1_Copy1;
        
        internal SilverlightContrib.Controls.GroupBox groupBox1_Copy2;
        
        internal SilverlightContrib.Controls.GroupBox groupBox1_Copy3;
        
        internal System.Windows.Controls.Button CancelButton;
        
        internal System.Windows.Controls.Button NewButton;
        
        internal System.Windows.Controls.DataGrid dgListeTarifFacturation;
        
        internal System.Windows.Controls.DataPager datapager;
        
        internal System.Windows.Controls.DataGrid dg_Detail;
        
        internal System.Windows.Controls.Button DeleteButton;
        
        internal System.Windows.Controls.Label lbl_id_centre;
        
        internal System.Windows.Controls.Label label3;
        
        internal System.Windows.Controls.TextBox Txt_CodeCentre;
        
        internal System.Windows.Controls.Button btn_Centre1;
        
        internal System.Windows.Controls.TextBox Txt_LibelleCentre1;
        
        internal System.Windows.Controls.Label label6;
        
        internal System.Windows.Controls.TextBox Txt_CodeRedevence;
        
        internal System.Windows.Controls.Button btn_Redevence;
        
        internal System.Windows.Controls.TextBox Txt_LibelleRedevence;
        
        internal System.Windows.Controls.Label label16;
        
        internal System.Windows.Controls.TextBox Txt_CodeProduit;
        
        internal System.Windows.Controls.Button btn_Produit;
        
        internal System.Windows.Controls.TextBox Txt_LibelleProduit;
        
        internal System.Windows.Controls.Label label1;
        
        internal System.Windows.Controls.TextBox Txt_CodeRechercheTarif;
        
        internal System.Windows.Controls.Button btn_RechercheTarif;
        
        internal System.Windows.Controls.TextBox Txt_LibelleRechercheTarif;
        
        internal System.Windows.Controls.Label label16_Copy;
        
        internal System.Windows.Controls.TextBox Txt_CodeSite;
        
        internal System.Windows.Controls.Button btn_Site;
        
        internal System.Windows.Controls.TextBox Txt_LibelleSite;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Galatee.Silverlight;component/Tarification/FrmListeTarif.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.groupBox1_Copy1 = ((SilverlightContrib.Controls.GroupBox)(this.FindName("groupBox1_Copy1")));
            this.groupBox1_Copy2 = ((SilverlightContrib.Controls.GroupBox)(this.FindName("groupBox1_Copy2")));
            this.groupBox1_Copy3 = ((SilverlightContrib.Controls.GroupBox)(this.FindName("groupBox1_Copy3")));
            this.CancelButton = ((System.Windows.Controls.Button)(this.FindName("CancelButton")));
            this.NewButton = ((System.Windows.Controls.Button)(this.FindName("NewButton")));
            this.dgListeTarifFacturation = ((System.Windows.Controls.DataGrid)(this.FindName("dgListeTarifFacturation")));
            this.datapager = ((System.Windows.Controls.DataPager)(this.FindName("datapager")));
            this.dg_Detail = ((System.Windows.Controls.DataGrid)(this.FindName("dg_Detail")));
            this.DeleteButton = ((System.Windows.Controls.Button)(this.FindName("DeleteButton")));
            this.lbl_id_centre = ((System.Windows.Controls.Label)(this.FindName("lbl_id_centre")));
            this.label3 = ((System.Windows.Controls.Label)(this.FindName("label3")));
            this.Txt_CodeCentre = ((System.Windows.Controls.TextBox)(this.FindName("Txt_CodeCentre")));
            this.btn_Centre1 = ((System.Windows.Controls.Button)(this.FindName("btn_Centre1")));
            this.Txt_LibelleCentre1 = ((System.Windows.Controls.TextBox)(this.FindName("Txt_LibelleCentre1")));
            this.label6 = ((System.Windows.Controls.Label)(this.FindName("label6")));
            this.Txt_CodeRedevence = ((System.Windows.Controls.TextBox)(this.FindName("Txt_CodeRedevence")));
            this.btn_Redevence = ((System.Windows.Controls.Button)(this.FindName("btn_Redevence")));
            this.Txt_LibelleRedevence = ((System.Windows.Controls.TextBox)(this.FindName("Txt_LibelleRedevence")));
            this.label16 = ((System.Windows.Controls.Label)(this.FindName("label16")));
            this.Txt_CodeProduit = ((System.Windows.Controls.TextBox)(this.FindName("Txt_CodeProduit")));
            this.btn_Produit = ((System.Windows.Controls.Button)(this.FindName("btn_Produit")));
            this.Txt_LibelleProduit = ((System.Windows.Controls.TextBox)(this.FindName("Txt_LibelleProduit")));
            this.label1 = ((System.Windows.Controls.Label)(this.FindName("label1")));
            this.Txt_CodeRechercheTarif = ((System.Windows.Controls.TextBox)(this.FindName("Txt_CodeRechercheTarif")));
            this.btn_RechercheTarif = ((System.Windows.Controls.Button)(this.FindName("btn_RechercheTarif")));
            this.Txt_LibelleRechercheTarif = ((System.Windows.Controls.TextBox)(this.FindName("Txt_LibelleRechercheTarif")));
            this.label16_Copy = ((System.Windows.Controls.Label)(this.FindName("label16_Copy")));
            this.Txt_CodeSite = ((System.Windows.Controls.TextBox)(this.FindName("Txt_CodeSite")));
            this.btn_Site = ((System.Windows.Controls.Button)(this.FindName("btn_Site")));
            this.Txt_LibelleSite = ((System.Windows.Controls.TextBox)(this.FindName("Txt_LibelleSite")));
        }
    }
}

