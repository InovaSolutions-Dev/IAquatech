#pragma checksum "D:\PROJET IWEBS\IWEB\Galatee\Galatee.Silverlight\Parametrage\UcWKFCondition.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D8E5223B569205E4084CBC154BA396D9"
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


namespace Galatee.Silverlight.Parametrage {
    
    
    public partial class UcWKFCondition : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Label lblEtape;
        
        internal System.Windows.Controls.ComboBox cmbColonne;
        
        internal System.Windows.Controls.ComboBox cmbOperateur;
        
        internal System.Windows.Controls.ComboBox cmbEtapeConditionVrai;
        
        internal System.Windows.Controls.TextBox txtValeur;
        
        internal System.Windows.Controls.Label lblGroupe;
        
        internal System.Windows.Controls.ComboBox cmbGroupeValidation;
        
        internal System.Windows.Controls.Button CancelButton;
        
        internal System.Windows.Controls.Button OKButton;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Galatee.Silverlight;component/Parametrage/UcWKFCondition.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.lblEtape = ((System.Windows.Controls.Label)(this.FindName("lblEtape")));
            this.cmbColonne = ((System.Windows.Controls.ComboBox)(this.FindName("cmbColonne")));
            this.cmbOperateur = ((System.Windows.Controls.ComboBox)(this.FindName("cmbOperateur")));
            this.cmbEtapeConditionVrai = ((System.Windows.Controls.ComboBox)(this.FindName("cmbEtapeConditionVrai")));
            this.txtValeur = ((System.Windows.Controls.TextBox)(this.FindName("txtValeur")));
            this.lblGroupe = ((System.Windows.Controls.Label)(this.FindName("lblGroupe")));
            this.cmbGroupeValidation = ((System.Windows.Controls.ComboBox)(this.FindName("cmbGroupeValidation")));
            this.CancelButton = ((System.Windows.Controls.Button)(this.FindName("CancelButton")));
            this.OKButton = ((System.Windows.Controls.Button)(this.FindName("OKButton")));
        }
    }
}

