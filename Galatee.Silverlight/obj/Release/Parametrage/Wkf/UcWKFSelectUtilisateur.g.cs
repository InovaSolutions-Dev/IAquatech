#pragma checksum "F:\SOURCES\AQUATECH\Galatee_save\Galatee.Silverlight\Parametrage\Wkf\UcWKFSelectUtilisateur.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A8D1F12AB03364216057D24234202C96"
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


namespace Galatee.Silverlight.Parametrage {
    
    
    public partial class UcWKFSelectUtilisateur : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal SilverlightContrib.Controls.GroupBox GroupBox_Copy;
        
        internal System.Windows.Controls.DataGrid lvwResultat;
        
        internal System.Windows.Controls.Button CancelButton;
        
        internal System.Windows.Controls.Button OKButton;
        
        internal System.Windows.Controls.Button btn_Afficher;
        
        internal System.Windows.Controls.TextBox txt_Matricule;
        
        internal System.Windows.Controls.TextBox txt_Nom;
        
        internal System.Windows.Controls.CheckBox IsConsultation;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Galatee.Silverlight;component/Parametrage/Wkf/UcWKFSelectUtilisateur.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.GroupBox_Copy = ((SilverlightContrib.Controls.GroupBox)(this.FindName("GroupBox_Copy")));
            this.lvwResultat = ((System.Windows.Controls.DataGrid)(this.FindName("lvwResultat")));
            this.CancelButton = ((System.Windows.Controls.Button)(this.FindName("CancelButton")));
            this.OKButton = ((System.Windows.Controls.Button)(this.FindName("OKButton")));
            this.btn_Afficher = ((System.Windows.Controls.Button)(this.FindName("btn_Afficher")));
            this.txt_Matricule = ((System.Windows.Controls.TextBox)(this.FindName("txt_Matricule")));
            this.txt_Nom = ((System.Windows.Controls.TextBox)(this.FindName("txt_Nom")));
            this.IsConsultation = ((System.Windows.Controls.CheckBox)(this.FindName("IsConsultation")));
        }
    }
}

