﻿#pragma checksum "F:\SOURCES\AQUATECH\Galatee_save\Galatee.Silverlight\Parametrage\Parametrage\UcListAppareils.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EB2C10DFEA671221457BEFBF44BBBBA0"
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


namespace Galatee.Silverlight.Parametrage {
    
    
    public partial class UcListAppareils : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Button btnDelete;
        
        internal System.Windows.Controls.Button btnPrint;
        
        internal System.Windows.Controls.DataGrid dtgrdParametre;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Galatee.Silverlight;component/Parametrage/Parametrage/UcListAppareils.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.btnDelete = ((System.Windows.Controls.Button)(this.FindName("btnDelete")));
            this.btnPrint = ((System.Windows.Controls.Button)(this.FindName("btnPrint")));
            this.dtgrdParametre = ((System.Windows.Controls.DataGrid)(this.FindName("dtgrdParametre")));
        }
    }
}

