﻿#pragma checksum "F:\SOURCES\AQUATECH\Galatee_save\Galatee.Silverlight\Devis\UcDevisMT.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9E6D263BF33EBA016ACD7E14CD7FBDD8"
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


namespace Galatee.Silverlight.Devis {
    
    
    public partial class UcDevisMT : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Button CancelButton;
        
        internal System.Windows.Controls.Button OKButton;
        
        internal System.Windows.Controls.DataGrid dataGridElementDevis;
        
        internal System.Windows.Controls.DataGrid dataGridRubriqueDevis;
        
        internal System.Windows.Controls.Button Btn_Ajouter;
        
        internal System.Windows.Controls.Button Btn_Modifier;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Galatee.Silverlight;component/Devis/UcDevisMT.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.CancelButton = ((System.Windows.Controls.Button)(this.FindName("CancelButton")));
            this.OKButton = ((System.Windows.Controls.Button)(this.FindName("OKButton")));
            this.dataGridElementDevis = ((System.Windows.Controls.DataGrid)(this.FindName("dataGridElementDevis")));
            this.dataGridRubriqueDevis = ((System.Windows.Controls.DataGrid)(this.FindName("dataGridRubriqueDevis")));
            this.Btn_Ajouter = ((System.Windows.Controls.Button)(this.FindName("Btn_Ajouter")));
            this.Btn_Modifier = ((System.Windows.Controls.Button)(this.FindName("Btn_Modifier")));
        }
    }
}

