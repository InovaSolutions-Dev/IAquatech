#pragma checksum "D:\PROJET IWEBS\IWEB\Galatee\Galatee.Silverlight\Parametrage\UcWKF.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5A701B81A9CFDD039A5BA5B15EA5E39D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
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
    
    
    public partial class UcWKF : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal SilverlightContrib.Controls.GroupBox GroupBox;
        
        internal System.Windows.Controls.TextBox txtCode;
        
        internal System.Windows.Controls.TextBox txtDescription;
        
        internal System.Windows.Controls.TextBox txtNom;
        
        internal System.Windows.Controls.ComboBox cmbTable;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Galatee.Silverlight;component/Parametrage/UcWKF.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.GroupBox = ((SilverlightContrib.Controls.GroupBox)(this.FindName("GroupBox")));
            this.txtCode = ((System.Windows.Controls.TextBox)(this.FindName("txtCode")));
            this.txtDescription = ((System.Windows.Controls.TextBox)(this.FindName("txtDescription")));
            this.txtNom = ((System.Windows.Controls.TextBox)(this.FindName("txtNom")));
            this.cmbTable = ((System.Windows.Controls.ComboBox)(this.FindName("cmbTable")));
            this.CancelButton = ((System.Windows.Controls.Button)(this.FindName("CancelButton")));
            this.OKButton = ((System.Windows.Controls.Button)(this.FindName("OKButton")));
        }
    }
}

