﻿#pragma checksum "D:\PROJET IWEBS\IWEB\Galatee\Galatee.Silverlight\Parametrage\UcListTaxe.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9AC5A85BBA6305A44D878E7BD8B7C014"
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
    
    
    public partial class UcListTaxe : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.ProgressBar progressBar1;
        
        internal SilverlightContrib.Controls.GroupBox groupBox1;
        
        internal System.Windows.Controls.DataGrid dtgrdParametre;
        
        internal System.Windows.Controls.ContextMenu MenuContextuel;
        
        internal System.Windows.Controls.MenuItem MenuContextuelCreer;
        
        internal System.Windows.Controls.MenuItem MenuContextuelConsulter;
        
        internal System.Windows.Controls.MenuItem MenuContextuelEditer;
        
        internal System.Windows.Controls.MenuItem MenuContextuelModifier;
        
        internal System.Windows.Controls.MenuItem MenuContextuelSupprimer;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Galatee.Silverlight;component/Parametrage/UcListTaxe.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.progressBar1 = ((System.Windows.Controls.ProgressBar)(this.FindName("progressBar1")));
            this.groupBox1 = ((SilverlightContrib.Controls.GroupBox)(this.FindName("groupBox1")));
            this.dtgrdParametre = ((System.Windows.Controls.DataGrid)(this.FindName("dtgrdParametre")));
            this.MenuContextuel = ((System.Windows.Controls.ContextMenu)(this.FindName("MenuContextuel")));
            this.MenuContextuelCreer = ((System.Windows.Controls.MenuItem)(this.FindName("MenuContextuelCreer")));
            this.MenuContextuelConsulter = ((System.Windows.Controls.MenuItem)(this.FindName("MenuContextuelConsulter")));
            this.MenuContextuelEditer = ((System.Windows.Controls.MenuItem)(this.FindName("MenuContextuelEditer")));
            this.MenuContextuelModifier = ((System.Windows.Controls.MenuItem)(this.FindName("MenuContextuelModifier")));
            this.MenuContextuelSupprimer = ((System.Windows.Controls.MenuItem)(this.FindName("MenuContextuelSupprimer")));
        }
    }
}

