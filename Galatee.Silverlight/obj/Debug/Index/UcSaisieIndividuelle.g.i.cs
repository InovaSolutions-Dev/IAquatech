﻿#pragma checksum "D:\PROJET IWEBS\IWEB\Galatee\Galatee.Silverlight\Index\UcSaisieIndividuelle.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E32F9B59B0E2E927588016D0E946EDAE"
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


namespace Galatee.Silverlight.Facturation {
    
    
    public partial class UcSaisieIndividuelle : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Button CancelButton;
        
        internal System.Windows.Controls.Button btn_Valider;
        
        internal SilverlightContrib.Controls.GroupBox groupBox1_Copy;
        
        internal System.Windows.Controls.Border border17;
        
        internal System.Windows.Controls.Label label10;
        
        internal System.Windows.Controls.Label label1;
        
        internal System.Windows.Controls.Border border1;
        
        internal System.Windows.Controls.Label lb_Batch;
        
        internal System.Windows.Controls.Border border2;
        
        internal System.Windows.Controls.Label lb_Centre;
        
        internal System.Windows.Controls.Border border3;
        
        internal System.Windows.Controls.Label lb_Releveur;
        
        internal System.Windows.Controls.Label label4;
        
        internal System.Windows.Controls.Border border4;
        
        internal System.Windows.Controls.Label lb_Client;
        
        internal System.Windows.Controls.Border border5;
        
        internal System.Windows.Controls.Label lb_Produit;
        
        internal System.Windows.Controls.Border border6;
        
        internal System.Windows.Controls.Label lb_point;
        
        internal System.Windows.Controls.Label label3;
        
        internal System.Windows.Controls.Label label2;
        
        internal System.Windows.Controls.Label label5;
        
        internal System.Windows.Controls.DataGrid dataGrid1;
        
        internal SilverlightContrib.Controls.GroupBox groupBox1;
        
        internal System.Windows.Controls.Label label6;
        
        internal System.Windows.Controls.Label label7;
        
        internal System.Windows.Controls.TextBox Txt_CasLibelle;
        
        internal System.Windows.Controls.TextBox Txt_periodePrec;
        
        internal System.Windows.Controls.Label label8;
        
        internal System.Windows.Controls.TextBox Txt_ReadingPrec;
        
        internal System.Windows.Controls.Label label9;
        
        internal System.Windows.Controls.TextBox txt_coef;
        
        internal SilverlightContrib.Controls.GroupBox groupBox2;
        
        internal System.Windows.Controls.TextBox Txt_DateEvt;
        
        internal System.Windows.Controls.TextBox Txt_periode;
        
        internal System.Windows.Controls.TextBox Txt_Diametre;
        
        internal System.Windows.Controls.TextBox Txt_Compteur;
        
        internal System.Windows.Controls.TextBox Txt_IndexEvt;
        
        internal System.Windows.Controls.TextBox Txt_ConsoCalc;
        
        internal System.Windows.Controls.TextBox Txt_ConsoSaisie;
        
        internal System.Windows.Controls.TextBox Txt_Enquete;
        
        internal System.Windows.Controls.Button btn_creation;
        
        internal System.Windows.Controls.Button Btn_Detail;
        
        internal System.Windows.Controls.Button btn_supprime;
        
        internal System.Windows.Controls.TextBox Txt_Cas;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Galatee.Silverlight;component/Index/UcSaisieIndividuelle.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.CancelButton = ((System.Windows.Controls.Button)(this.FindName("CancelButton")));
            this.btn_Valider = ((System.Windows.Controls.Button)(this.FindName("btn_Valider")));
            this.groupBox1_Copy = ((SilverlightContrib.Controls.GroupBox)(this.FindName("groupBox1_Copy")));
            this.border17 = ((System.Windows.Controls.Border)(this.FindName("border17")));
            this.label10 = ((System.Windows.Controls.Label)(this.FindName("label10")));
            this.label1 = ((System.Windows.Controls.Label)(this.FindName("label1")));
            this.border1 = ((System.Windows.Controls.Border)(this.FindName("border1")));
            this.lb_Batch = ((System.Windows.Controls.Label)(this.FindName("lb_Batch")));
            this.border2 = ((System.Windows.Controls.Border)(this.FindName("border2")));
            this.lb_Centre = ((System.Windows.Controls.Label)(this.FindName("lb_Centre")));
            this.border3 = ((System.Windows.Controls.Border)(this.FindName("border3")));
            this.lb_Releveur = ((System.Windows.Controls.Label)(this.FindName("lb_Releveur")));
            this.label4 = ((System.Windows.Controls.Label)(this.FindName("label4")));
            this.border4 = ((System.Windows.Controls.Border)(this.FindName("border4")));
            this.lb_Client = ((System.Windows.Controls.Label)(this.FindName("lb_Client")));
            this.border5 = ((System.Windows.Controls.Border)(this.FindName("border5")));
            this.lb_Produit = ((System.Windows.Controls.Label)(this.FindName("lb_Produit")));
            this.border6 = ((System.Windows.Controls.Border)(this.FindName("border6")));
            this.lb_point = ((System.Windows.Controls.Label)(this.FindName("lb_point")));
            this.label3 = ((System.Windows.Controls.Label)(this.FindName("label3")));
            this.label2 = ((System.Windows.Controls.Label)(this.FindName("label2")));
            this.label5 = ((System.Windows.Controls.Label)(this.FindName("label5")));
            this.dataGrid1 = ((System.Windows.Controls.DataGrid)(this.FindName("dataGrid1")));
            this.groupBox1 = ((SilverlightContrib.Controls.GroupBox)(this.FindName("groupBox1")));
            this.label6 = ((System.Windows.Controls.Label)(this.FindName("label6")));
            this.label7 = ((System.Windows.Controls.Label)(this.FindName("label7")));
            this.Txt_CasLibelle = ((System.Windows.Controls.TextBox)(this.FindName("Txt_CasLibelle")));
            this.Txt_periodePrec = ((System.Windows.Controls.TextBox)(this.FindName("Txt_periodePrec")));
            this.label8 = ((System.Windows.Controls.Label)(this.FindName("label8")));
            this.Txt_ReadingPrec = ((System.Windows.Controls.TextBox)(this.FindName("Txt_ReadingPrec")));
            this.label9 = ((System.Windows.Controls.Label)(this.FindName("label9")));
            this.txt_coef = ((System.Windows.Controls.TextBox)(this.FindName("txt_coef")));
            this.groupBox2 = ((SilverlightContrib.Controls.GroupBox)(this.FindName("groupBox2")));
            this.Txt_DateEvt = ((System.Windows.Controls.TextBox)(this.FindName("Txt_DateEvt")));
            this.Txt_periode = ((System.Windows.Controls.TextBox)(this.FindName("Txt_periode")));
            this.Txt_Diametre = ((System.Windows.Controls.TextBox)(this.FindName("Txt_Diametre")));
            this.Txt_Compteur = ((System.Windows.Controls.TextBox)(this.FindName("Txt_Compteur")));
            this.Txt_IndexEvt = ((System.Windows.Controls.TextBox)(this.FindName("Txt_IndexEvt")));
            this.Txt_ConsoCalc = ((System.Windows.Controls.TextBox)(this.FindName("Txt_ConsoCalc")));
            this.Txt_ConsoSaisie = ((System.Windows.Controls.TextBox)(this.FindName("Txt_ConsoSaisie")));
            this.Txt_Enquete = ((System.Windows.Controls.TextBox)(this.FindName("Txt_Enquete")));
            this.btn_creation = ((System.Windows.Controls.Button)(this.FindName("btn_creation")));
            this.Btn_Detail = ((System.Windows.Controls.Button)(this.FindName("Btn_Detail")));
            this.btn_supprime = ((System.Windows.Controls.Button)(this.FindName("btn_supprime")));
            this.Txt_Cas = ((System.Windows.Controls.TextBox)(this.FindName("Txt_Cas")));
        }
    }
}

