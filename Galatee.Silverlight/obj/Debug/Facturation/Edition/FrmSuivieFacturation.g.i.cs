﻿#pragma checksum "C:\Users\EDMSA\Documents\Galatee\Galatee.Silverlight\Facturation\Edition\FrmSuivieFacturation.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8E68AC07216AC8F9208A7E2096A5E217"
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


namespace Galatee.Silverlight.Facturation {
    
    
    public partial class FrmSuivieFacturation : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Button CancelButton;
        
        internal System.Windows.Controls.Button OKButton;
        
        internal System.Windows.Controls.DataGrid dtg_Action;
        
        internal System.Windows.Controls.Button btn_batch;
        
        internal System.Windows.Controls.TextBox Txt_NumBatch;
        
        internal System.Windows.Controls.Button btn_Rechercher;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Galatee.Silverlight;component/Facturation/Edition/FrmSuivieFacturation.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.CancelButton = ((System.Windows.Controls.Button)(this.FindName("CancelButton")));
            this.OKButton = ((System.Windows.Controls.Button)(this.FindName("OKButton")));
            this.dtg_Action = ((System.Windows.Controls.DataGrid)(this.FindName("dtg_Action")));
            this.btn_batch = ((System.Windows.Controls.Button)(this.FindName("btn_batch")));
            this.Txt_NumBatch = ((System.Windows.Controls.TextBox)(this.FindName("Txt_NumBatch")));
            this.btn_Rechercher = ((System.Windows.Controls.Button)(this.FindName("btn_Rechercher")));
        }
    }
}

