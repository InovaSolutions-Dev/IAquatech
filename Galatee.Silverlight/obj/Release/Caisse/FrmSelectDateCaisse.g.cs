﻿#pragma checksum "F:\SOURCES\AQUATECH\Galatee_save\Galatee.Silverlight\Caisse\FrmSelectDateCaisse.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F236F248C613C7E4163EF7FE28B34918"
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
    
    
    public partial class FrmSelectDateCaisse : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Button Btn_Abort;
        
        internal System.Windows.Controls.Button Btn_Update;
        
        internal System.Windows.Controls.DatePicker dtpDate;
        
        internal System.Windows.Controls.Label label1;
        
        internal System.Windows.Controls.Button btn_Caissier;
        
        internal System.Windows.Controls.TextBox txtMatriculeCaissier;
        
        internal System.Windows.Controls.TextBox txt_CashierName;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Galatee.Silverlight;component/Caisse/FrmSelectDateCaisse.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.Btn_Abort = ((System.Windows.Controls.Button)(this.FindName("Btn_Abort")));
            this.Btn_Update = ((System.Windows.Controls.Button)(this.FindName("Btn_Update")));
            this.dtpDate = ((System.Windows.Controls.DatePicker)(this.FindName("dtpDate")));
            this.label1 = ((System.Windows.Controls.Label)(this.FindName("label1")));
            this.btn_Caissier = ((System.Windows.Controls.Button)(this.FindName("btn_Caissier")));
            this.txtMatriculeCaissier = ((System.Windows.Controls.TextBox)(this.FindName("txtMatriculeCaissier")));
            this.txt_CashierName = ((System.Windows.Controls.TextBox)(this.FindName("txt_CashierName")));
        }
    }
}

