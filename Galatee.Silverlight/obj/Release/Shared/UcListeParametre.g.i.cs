﻿#pragma checksum "C:\Users\EDMSA\Documents\EDM\New\new\New\IWEB EN COURS\Galatee\Galatee.Silverlight\Shared\UcListeParametre.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2BE793AC33524A2EBFAD6DC6C7ACC42F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.36366
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


namespace Galatee.Silverlight.Shared {
    
    
    public partial class UcListeParametre : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Button CancelButton;
        
        internal System.Windows.Controls.Button OKButton;
        
        internal System.Windows.Controls.DataGrid Lst_Liste;
        
        internal System.Windows.Controls.Button btn_ToutCategorie;
        
        internal System.Windows.Controls.Button btn_rienCategorie;
        
        internal System.Windows.Controls.TextBox txt_Code_Rech;
        
        internal System.Windows.Controls.TextBox txt_Libelle_Rech;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Galatee.Silverlight;component/Shared/UcListeParametre.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.CancelButton = ((System.Windows.Controls.Button)(this.FindName("CancelButton")));
            this.OKButton = ((System.Windows.Controls.Button)(this.FindName("OKButton")));
            this.Lst_Liste = ((System.Windows.Controls.DataGrid)(this.FindName("Lst_Liste")));
            this.btn_ToutCategorie = ((System.Windows.Controls.Button)(this.FindName("btn_ToutCategorie")));
            this.btn_rienCategorie = ((System.Windows.Controls.Button)(this.FindName("btn_rienCategorie")));
            this.txt_Code_Rech = ((System.Windows.Controls.TextBox)(this.FindName("txt_Code_Rech")));
            this.txt_Libelle_Rech = ((System.Windows.Controls.TextBox)(this.FindName("txt_Libelle_Rech")));
        }
    }
}

