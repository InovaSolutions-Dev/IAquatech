﻿#pragma checksum "C:\SOURCES NOUVELLES\Galatee.Silverlight\Reclamation\UcMotifReprise.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A9CA3136ABC374D2DD2EFF3108B42FE7"
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


namespace Galatee.Silverlight.Accueil {
    
    
    public partial class UcMotifReprise : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TabControl tbControleClient;
        
        internal System.Windows.Controls.TabItem tabItemPersonnePhysique;
        
        internal SilverlightContrib.Controls.GroupBox Gbo_InformationsClient;
        
        internal System.Windows.Controls.TextBox Txt_Nom;
        
        internal System.Windows.Controls.TextBox Txt_Portable;
        
        internal System.Windows.Controls.TextBox Txt_NumeroFixe;
        
        internal System.Windows.Controls.TextBox Txt_Adress;
        
        internal System.Windows.Controls.TextBox Txt_Email;
        
        internal SilverlightContrib.Controls.GroupBox Gbo_InformationsServiceEmetteur;
        
        internal System.Windows.Controls.TextBox Txt_EtablirPar;
        
        internal System.Windows.Controls.TextBox Txt_Object;
        
        internal System.Windows.Controls.TextBox Txt_Observation;
        
        internal System.Windows.Controls.TextBox Txt_Client;
        
        internal System.Windows.Controls.TextBox Txt_TypeReclamation;
        
        internal System.Windows.Controls.TextBox Txt_DateRendezVous;
        
        internal System.Windows.Controls.TextBox Txt_DateOuverture;
        
        internal System.Windows.Controls.TextBox Txt_DateRetourSouhaiter;
        
        internal System.Windows.Controls.DataGrid dgListePiece;
        
        internal System.Windows.Controls.TabItem tabItemtraitement;
        
        internal SilverlightContrib.Controls.GroupBox Gbo_ActionsMenees;
        
        internal System.Windows.Controls.TextBox Txt_ActionMennes;
        
        internal System.Windows.Controls.TextBox Txt_AgentTraiteur;
        
        internal System.Windows.Controls.DatePicker Dtp_DateTraitement;
        
        internal System.Windows.Controls.Label labMotif;
        
        internal System.Windows.Controls.TextBox Txt_MotifRejet;
        
        internal System.Windows.Controls.TextBox Txt_NumDemande;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Galatee.Silverlight;component/Reclamation/UcMotifReprise.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.tbControleClient = ((System.Windows.Controls.TabControl)(this.FindName("tbControleClient")));
            this.tabItemPersonnePhysique = ((System.Windows.Controls.TabItem)(this.FindName("tabItemPersonnePhysique")));
            this.Gbo_InformationsClient = ((SilverlightContrib.Controls.GroupBox)(this.FindName("Gbo_InformationsClient")));
            this.Txt_Nom = ((System.Windows.Controls.TextBox)(this.FindName("Txt_Nom")));
            this.Txt_Portable = ((System.Windows.Controls.TextBox)(this.FindName("Txt_Portable")));
            this.Txt_NumeroFixe = ((System.Windows.Controls.TextBox)(this.FindName("Txt_NumeroFixe")));
            this.Txt_Adress = ((System.Windows.Controls.TextBox)(this.FindName("Txt_Adress")));
            this.Txt_Email = ((System.Windows.Controls.TextBox)(this.FindName("Txt_Email")));
            this.Gbo_InformationsServiceEmetteur = ((SilverlightContrib.Controls.GroupBox)(this.FindName("Gbo_InformationsServiceEmetteur")));
            this.Txt_EtablirPar = ((System.Windows.Controls.TextBox)(this.FindName("Txt_EtablirPar")));
            this.Txt_Object = ((System.Windows.Controls.TextBox)(this.FindName("Txt_Object")));
            this.Txt_Observation = ((System.Windows.Controls.TextBox)(this.FindName("Txt_Observation")));
            this.Txt_Client = ((System.Windows.Controls.TextBox)(this.FindName("Txt_Client")));
            this.Txt_TypeReclamation = ((System.Windows.Controls.TextBox)(this.FindName("Txt_TypeReclamation")));
            this.Txt_DateRendezVous = ((System.Windows.Controls.TextBox)(this.FindName("Txt_DateRendezVous")));
            this.Txt_DateOuverture = ((System.Windows.Controls.TextBox)(this.FindName("Txt_DateOuverture")));
            this.Txt_DateRetourSouhaiter = ((System.Windows.Controls.TextBox)(this.FindName("Txt_DateRetourSouhaiter")));
            this.dgListePiece = ((System.Windows.Controls.DataGrid)(this.FindName("dgListePiece")));
            this.tabItemtraitement = ((System.Windows.Controls.TabItem)(this.FindName("tabItemtraitement")));
            this.Gbo_ActionsMenees = ((SilverlightContrib.Controls.GroupBox)(this.FindName("Gbo_ActionsMenees")));
            this.Txt_ActionMennes = ((System.Windows.Controls.TextBox)(this.FindName("Txt_ActionMennes")));
            this.Txt_AgentTraiteur = ((System.Windows.Controls.TextBox)(this.FindName("Txt_AgentTraiteur")));
            this.Dtp_DateTraitement = ((System.Windows.Controls.DatePicker)(this.FindName("Dtp_DateTraitement")));
            this.labMotif = ((System.Windows.Controls.Label)(this.FindName("labMotif")));
            this.Txt_MotifRejet = ((System.Windows.Controls.TextBox)(this.FindName("Txt_MotifRejet")));
            this.Txt_NumDemande = ((System.Windows.Controls.TextBox)(this.FindName("Txt_NumDemande")));
            this.CancelButton = ((System.Windows.Controls.Button)(this.FindName("CancelButton")));
            this.OKButton = ((System.Windows.Controls.Button)(this.FindName("OKButton")));
        }
    }
}

