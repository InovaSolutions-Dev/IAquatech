﻿#pragma checksum "F:\SOURCES\AQUATECH\Galatee_save\Galatee.Silverlight\Fraude\UcSaisiePvControle.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "318FC28AA293B56C82CBBFAF77F4282B"
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


namespace Galatee.Silverlight.Fraude {
    
    
    public partial class UcSaisiePvControle : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Button CancelButton;
        
        internal System.Windows.Controls.Button BtnTRansfert;
        
        internal SilverlightContrib.Controls.GroupBox Gbo_Traitement;
        
        internal System.Windows.Controls.TextBox txt_Numerotraitement;
        
        internal System.Windows.Controls.CheckBox chck_fraudAve;
        
        internal SilverlightContrib.Controls.GroupBox Gbo_InformationAbonne;
        
        internal System.Windows.Controls.TextBox txt_Nom;
        
        internal System.Windows.Controls.TextBox txt_refclient;
        
        internal System.Windows.Controls.TextBox txt_IdentUnique;
        
        internal System.Windows.Controls.TextBox txt_ContactAbonne;
        
        internal System.Windows.Controls.TextBox txt_contarBrachement;
        
        internal System.Windows.Controls.TextBox txt_porte;
        
        internal System.Windows.Controls.TextBox txt_telephone;
        
        internal System.Windows.Controls.TextBox txt_email;
        
        internal System.Windows.Controls.DatePicker DateBranchemnt;
        
        internal System.Windows.Controls.DatePicker DateAbonnemnt;
        
        internal SilverlightContrib.Controls.GroupBox Gbo_Controle;
        
        internal System.Windows.Controls.TextBox txt_Nomexpert;
        
        internal System.Windows.Controls.TextBox txt_courantAdmn;
        
        internal System.Windows.Controls.TextBox txt_ordinateur;
        
        internal System.Windows.Controls.TextBox txt_FichControle;
        
        internal System.Windows.Controls.DatePicker DateControle;
        
        internal System.Windows.Controls.ComboBox Cbo_QualiteExpert;
        
        internal System.Windows.Controls.TextBox txt_Commissarial;
        
        internal System.Windows.Controls.CheckBox chck_abonne;
        
        internal System.Windows.Controls.CheckBox chck_convocation;
        
        internal System.Windows.Controls.CheckBox chck_anomalie;
        
        internal System.Windows.Controls.Label label3;
        
        internal System.Windows.Controls.TextBox txtCentre;
        
        internal System.Windows.Controls.ComboBox Cbo_Centre;
        
        internal System.Windows.Controls.Label label13;
        
        internal System.Windows.Controls.TextBox txt_Commune;
        
        internal System.Windows.Controls.ComboBox Cbo_Commune;
        
        internal System.Windows.Controls.Label label14;
        
        internal System.Windows.Controls.TextBox txt_Quartier;
        
        internal System.Windows.Controls.ComboBox Cbo_Quartier;
        
        internal System.Windows.Controls.Label label15;
        
        internal System.Windows.Controls.TextBox txt_NumRue;
        
        internal System.Windows.Controls.ComboBox Cbo_Rue;
        
        internal System.Windows.Controls.Label label15_Copy;
        
        internal System.Windows.Controls.TextBox txt_NumSecteur;
        
        internal System.Windows.Controls.ComboBox Cbo_Secteur;
        
        internal System.Windows.Controls.ComboBox Cbo_Produit;
        
        internal System.Windows.Controls.ComboBox Cbo_usage;
        
        internal SilverlightContrib.Controls.GroupBox Gbo_branchement;
        
        internal System.Windows.Controls.TextBox txt_numero;
        
        internal System.Windows.Controls.ComboBox Cbo_AnormlieCompteur;
        
        internal System.Windows.Controls.ComboBox Cbo_typeCompteur;
        
        internal System.Windows.Controls.TextBox txt_reference_plombs;
        
        internal System.Windows.Controls.TextBox txt_certifiplombage;
        
        internal System.Windows.Controls.ComboBox Cbo_ActionEntreprise;
        
        internal System.Windows.Controls.ComboBox Cbo_MarqueCmpt;
        
        internal System.Windows.Controls.TextBox txt_Index;
        
        internal System.Windows.Controls.TextBox txt_Numbrepince;
        
        internal System.Windows.Controls.ComboBox Cbo_Fils;
        
        internal System.Windows.Controls.ComboBox Cbo_CalibreCompteur;
        
        internal SilverlightContrib.Controls.GroupBox Gbo_Djistonct;
        
        internal System.Windows.Controls.TextBox txt_refeplombs;
        
        internal System.Windows.Controls.ComboBox Cbo_AnormalieCacheb;
        
        internal System.Windows.Controls.ComboBox Cbo_AnorBranchmnt;
        
        internal SilverlightContrib.Controls.GroupBox Gbo_Cache;
        
        internal System.Windows.Controls.ComboBox Cbo_MArqueDijoncteur;
        
        internal System.Windows.Controls.ComboBox Cbo_CalibreDijoncteur;
        
        internal System.Windows.Controls.ComboBox Cbo_ReglageCmpt;
        
        internal System.Windows.Controls.ComboBox Cbo_NbresfilsDijoncteur;
        
        internal SilverlightContrib.Controls.GroupBox Gbo_reference;
        
        internal System.Windows.Controls.TextBox txt_CoffreFusile;
        
        internal System.Windows.Controls.TextBox txtCoffreSeruite;
        
        internal SilverlightContrib.Controls.GroupBox Gbo_ListeAppareils;
        
        internal System.Windows.Controls.Label lab_ListeAppareils;
        
        internal System.Windows.Controls.ComboBox Cbo_ListeAppareils;
        
        internal System.Windows.Controls.Button Btn_ListeAppareils;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Galatee.Silverlight;component/Fraude/UcSaisiePvControle.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.CancelButton = ((System.Windows.Controls.Button)(this.FindName("CancelButton")));
            this.BtnTRansfert = ((System.Windows.Controls.Button)(this.FindName("BtnTRansfert")));
            this.Gbo_Traitement = ((SilverlightContrib.Controls.GroupBox)(this.FindName("Gbo_Traitement")));
            this.txt_Numerotraitement = ((System.Windows.Controls.TextBox)(this.FindName("txt_Numerotraitement")));
            this.chck_fraudAve = ((System.Windows.Controls.CheckBox)(this.FindName("chck_fraudAve")));
            this.Gbo_InformationAbonne = ((SilverlightContrib.Controls.GroupBox)(this.FindName("Gbo_InformationAbonne")));
            this.txt_Nom = ((System.Windows.Controls.TextBox)(this.FindName("txt_Nom")));
            this.txt_refclient = ((System.Windows.Controls.TextBox)(this.FindName("txt_refclient")));
            this.txt_IdentUnique = ((System.Windows.Controls.TextBox)(this.FindName("txt_IdentUnique")));
            this.txt_ContactAbonne = ((System.Windows.Controls.TextBox)(this.FindName("txt_ContactAbonne")));
            this.txt_contarBrachement = ((System.Windows.Controls.TextBox)(this.FindName("txt_contarBrachement")));
            this.txt_porte = ((System.Windows.Controls.TextBox)(this.FindName("txt_porte")));
            this.txt_telephone = ((System.Windows.Controls.TextBox)(this.FindName("txt_telephone")));
            this.txt_email = ((System.Windows.Controls.TextBox)(this.FindName("txt_email")));
            this.DateBranchemnt = ((System.Windows.Controls.DatePicker)(this.FindName("DateBranchemnt")));
            this.DateAbonnemnt = ((System.Windows.Controls.DatePicker)(this.FindName("DateAbonnemnt")));
            this.Gbo_Controle = ((SilverlightContrib.Controls.GroupBox)(this.FindName("Gbo_Controle")));
            this.txt_Nomexpert = ((System.Windows.Controls.TextBox)(this.FindName("txt_Nomexpert")));
            this.txt_courantAdmn = ((System.Windows.Controls.TextBox)(this.FindName("txt_courantAdmn")));
            this.txt_ordinateur = ((System.Windows.Controls.TextBox)(this.FindName("txt_ordinateur")));
            this.txt_FichControle = ((System.Windows.Controls.TextBox)(this.FindName("txt_FichControle")));
            this.DateControle = ((System.Windows.Controls.DatePicker)(this.FindName("DateControle")));
            this.Cbo_QualiteExpert = ((System.Windows.Controls.ComboBox)(this.FindName("Cbo_QualiteExpert")));
            this.txt_Commissarial = ((System.Windows.Controls.TextBox)(this.FindName("txt_Commissarial")));
            this.chck_abonne = ((System.Windows.Controls.CheckBox)(this.FindName("chck_abonne")));
            this.chck_convocation = ((System.Windows.Controls.CheckBox)(this.FindName("chck_convocation")));
            this.chck_anomalie = ((System.Windows.Controls.CheckBox)(this.FindName("chck_anomalie")));
            this.label3 = ((System.Windows.Controls.Label)(this.FindName("label3")));
            this.txtCentre = ((System.Windows.Controls.TextBox)(this.FindName("txtCentre")));
            this.Cbo_Centre = ((System.Windows.Controls.ComboBox)(this.FindName("Cbo_Centre")));
            this.label13 = ((System.Windows.Controls.Label)(this.FindName("label13")));
            this.txt_Commune = ((System.Windows.Controls.TextBox)(this.FindName("txt_Commune")));
            this.Cbo_Commune = ((System.Windows.Controls.ComboBox)(this.FindName("Cbo_Commune")));
            this.label14 = ((System.Windows.Controls.Label)(this.FindName("label14")));
            this.txt_Quartier = ((System.Windows.Controls.TextBox)(this.FindName("txt_Quartier")));
            this.Cbo_Quartier = ((System.Windows.Controls.ComboBox)(this.FindName("Cbo_Quartier")));
            this.label15 = ((System.Windows.Controls.Label)(this.FindName("label15")));
            this.txt_NumRue = ((System.Windows.Controls.TextBox)(this.FindName("txt_NumRue")));
            this.Cbo_Rue = ((System.Windows.Controls.ComboBox)(this.FindName("Cbo_Rue")));
            this.label15_Copy = ((System.Windows.Controls.Label)(this.FindName("label15_Copy")));
            this.txt_NumSecteur = ((System.Windows.Controls.TextBox)(this.FindName("txt_NumSecteur")));
            this.Cbo_Secteur = ((System.Windows.Controls.ComboBox)(this.FindName("Cbo_Secteur")));
            this.Cbo_Produit = ((System.Windows.Controls.ComboBox)(this.FindName("Cbo_Produit")));
            this.Cbo_usage = ((System.Windows.Controls.ComboBox)(this.FindName("Cbo_usage")));
            this.Gbo_branchement = ((SilverlightContrib.Controls.GroupBox)(this.FindName("Gbo_branchement")));
            this.txt_numero = ((System.Windows.Controls.TextBox)(this.FindName("txt_numero")));
            this.Cbo_AnormlieCompteur = ((System.Windows.Controls.ComboBox)(this.FindName("Cbo_AnormlieCompteur")));
            this.Cbo_typeCompteur = ((System.Windows.Controls.ComboBox)(this.FindName("Cbo_typeCompteur")));
            this.txt_reference_plombs = ((System.Windows.Controls.TextBox)(this.FindName("txt_reference_plombs")));
            this.txt_certifiplombage = ((System.Windows.Controls.TextBox)(this.FindName("txt_certifiplombage")));
            this.Cbo_ActionEntreprise = ((System.Windows.Controls.ComboBox)(this.FindName("Cbo_ActionEntreprise")));
            this.Cbo_MarqueCmpt = ((System.Windows.Controls.ComboBox)(this.FindName("Cbo_MarqueCmpt")));
            this.txt_Index = ((System.Windows.Controls.TextBox)(this.FindName("txt_Index")));
            this.txt_Numbrepince = ((System.Windows.Controls.TextBox)(this.FindName("txt_Numbrepince")));
            this.Cbo_Fils = ((System.Windows.Controls.ComboBox)(this.FindName("Cbo_Fils")));
            this.Cbo_CalibreCompteur = ((System.Windows.Controls.ComboBox)(this.FindName("Cbo_CalibreCompteur")));
            this.Gbo_Djistonct = ((SilverlightContrib.Controls.GroupBox)(this.FindName("Gbo_Djistonct")));
            this.txt_refeplombs = ((System.Windows.Controls.TextBox)(this.FindName("txt_refeplombs")));
            this.Cbo_AnormalieCacheb = ((System.Windows.Controls.ComboBox)(this.FindName("Cbo_AnormalieCacheb")));
            this.Cbo_AnorBranchmnt = ((System.Windows.Controls.ComboBox)(this.FindName("Cbo_AnorBranchmnt")));
            this.Gbo_Cache = ((SilverlightContrib.Controls.GroupBox)(this.FindName("Gbo_Cache")));
            this.Cbo_MArqueDijoncteur = ((System.Windows.Controls.ComboBox)(this.FindName("Cbo_MArqueDijoncteur")));
            this.Cbo_CalibreDijoncteur = ((System.Windows.Controls.ComboBox)(this.FindName("Cbo_CalibreDijoncteur")));
            this.Cbo_ReglageCmpt = ((System.Windows.Controls.ComboBox)(this.FindName("Cbo_ReglageCmpt")));
            this.Cbo_NbresfilsDijoncteur = ((System.Windows.Controls.ComboBox)(this.FindName("Cbo_NbresfilsDijoncteur")));
            this.Gbo_reference = ((SilverlightContrib.Controls.GroupBox)(this.FindName("Gbo_reference")));
            this.txt_CoffreFusile = ((System.Windows.Controls.TextBox)(this.FindName("txt_CoffreFusile")));
            this.txtCoffreSeruite = ((System.Windows.Controls.TextBox)(this.FindName("txtCoffreSeruite")));
            this.Gbo_ListeAppareils = ((SilverlightContrib.Controls.GroupBox)(this.FindName("Gbo_ListeAppareils")));
            this.lab_ListeAppareils = ((System.Windows.Controls.Label)(this.FindName("lab_ListeAppareils")));
            this.Cbo_ListeAppareils = ((System.Windows.Controls.ComboBox)(this.FindName("Cbo_ListeAppareils")));
            this.Btn_ListeAppareils = ((System.Windows.Controls.Button)(this.FindName("Btn_ListeAppareils")));
        }
    }
}

