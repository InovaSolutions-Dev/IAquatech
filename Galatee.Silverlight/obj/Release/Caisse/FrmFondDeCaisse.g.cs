#pragma checksum "F:\SOURCES\AQUATECH\Galatee_save\Galatee.Silverlight\Caisse\FrmFondDeCaisse.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "14FC9F7D13C2E8672364460E4C094F49"
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
    
    
    public partial class FrmFondDeCaisse : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Button CancelButton;
        
        internal System.Windows.Controls.Button OKButton;
        
        internal System.Windows.Controls.Label lbl_NumCaisse;
        
        internal System.Windows.Controls.Label lbl_fondCaisseActuel;
        
        internal System.Windows.Controls.Label lbl_NouveauFondCaisse;
        
        internal System.Windows.Controls.ComboBox cbo_MoisComptable;
        
        internal System.Windows.Controls.Label lbl_MoisComptable;
        
        internal System.Windows.Controls.TextBox txtNumCaisse;
        
        internal System.Windows.Controls.TextBox txtFondActuel;
        
        internal System.Windows.Controls.TextBox txtFondNouveau;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Galatee.Silverlight;component/Caisse/FrmFondDeCaisse.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.CancelButton = ((System.Windows.Controls.Button)(this.FindName("CancelButton")));
            this.OKButton = ((System.Windows.Controls.Button)(this.FindName("OKButton")));
            this.lbl_NumCaisse = ((System.Windows.Controls.Label)(this.FindName("lbl_NumCaisse")));
            this.lbl_fondCaisseActuel = ((System.Windows.Controls.Label)(this.FindName("lbl_fondCaisseActuel")));
            this.lbl_NouveauFondCaisse = ((System.Windows.Controls.Label)(this.FindName("lbl_NouveauFondCaisse")));
            this.cbo_MoisComptable = ((System.Windows.Controls.ComboBox)(this.FindName("cbo_MoisComptable")));
            this.lbl_MoisComptable = ((System.Windows.Controls.Label)(this.FindName("lbl_MoisComptable")));
            this.txtNumCaisse = ((System.Windows.Controls.TextBox)(this.FindName("txtNumCaisse")));
            this.txtFondActuel = ((System.Windows.Controls.TextBox)(this.FindName("txtFondActuel")));
            this.txtFondNouveau = ((System.Windows.Controls.TextBox)(this.FindName("txtFondNouveau")));
        }
    }
}

