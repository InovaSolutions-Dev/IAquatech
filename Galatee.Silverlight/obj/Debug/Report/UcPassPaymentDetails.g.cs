﻿#pragma checksum "D:\PROJET IWEBS\IWEB\Galatee\Galatee.Silverlight\Report\UcPassPaymentDetails.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BEA7C0B8817F52DD8E97F891C1EBB126"
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


namespace Galatee.Silverlight.Report {
    
    
    public partial class UcPassPaymentDetails : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Button CancelButton;
        
        internal System.Windows.Controls.Button OKButton;
        
        internal System.Windows.Controls.RadioButton rdbTypeResumer;
        
        internal System.Windows.Controls.RadioButton rdbTypeResumer2;
        
        internal System.Windows.Controls.RadioButton rdbTypeDetail;
        
        internal System.Windows.Controls.DatePicker Txt_DateDebut;
        
        internal System.Windows.Controls.TextBox Txt_year;
        
        internal System.Windows.Controls.ComboBox ddbMois;
        
        internal System.Windows.Controls.ComboBox ddbCollecter;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Galatee.Silverlight;component/Report/UcPassPaymentDetails.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.CancelButton = ((System.Windows.Controls.Button)(this.FindName("CancelButton")));
            this.OKButton = ((System.Windows.Controls.Button)(this.FindName("OKButton")));
            this.rdbTypeResumer = ((System.Windows.Controls.RadioButton)(this.FindName("rdbTypeResumer")));
            this.rdbTypeResumer2 = ((System.Windows.Controls.RadioButton)(this.FindName("rdbTypeResumer2")));
            this.rdbTypeDetail = ((System.Windows.Controls.RadioButton)(this.FindName("rdbTypeDetail")));
            this.Txt_DateDebut = ((System.Windows.Controls.DatePicker)(this.FindName("Txt_DateDebut")));
            this.Txt_year = ((System.Windows.Controls.TextBox)(this.FindName("Txt_year")));
            this.ddbMois = ((System.Windows.Controls.ComboBox)(this.FindName("ddbMois")));
            this.ddbCollecter = ((System.Windows.Controls.ComboBox)(this.FindName("ddbCollecter")));
        }
    }
}
