using Galatee.Silverlight.ServiceReport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Galatee.Silverlight.Report
{
    public partial class FrmStatistiquesVentes : ChildWindow
    {
        public FrmStatistiquesVentes()
        {
            InitializeComponent();
            ChargerCategorie();
            ChargerDonneeDuSite();
            prgBar.Visibility = System.Windows.Visibility.Collapsed;
        }
        string leEtatExecuter = string.Empty;
        public FrmStatistiquesVentes(string typeEtat)
        {
            InitializeComponent();
            ChargerCategorie();
            ChargerDonneeDuSite();
            leEtatExecuter = typeEtat;
            prgBar.Visibility = System.Windows.Visibility.Collapsed;

            if (typeEtat == SessionObject.Statfacturation || typeEtat == SessionObject.StatfacturationIsolee)
                this.ckbAnnee.Visibility = System.Windows.Visibility.Visible;
        }

        List<int> lesCentreCaisse = new List<int>();
        List<ServiceAccueil.CParametre> ListeDesSites;
        List<ServiceAccueil.CParametre> ListCheckeditems;
        List<Galatee.Silverlight.ServiceAccueil.CsCentre> LstCentrePerimetre = new List<ServiceAccueil.CsCentre>();
        List<Galatee.Silverlight.ServiceAccueil.CsSite> lstSite = new List<Galatee.Silverlight.ServiceAccueil.CsSite>();
        Galatee.Silverlight.ServiceAccueil.CsSite lSiteSelect = new Galatee.Silverlight.ServiceAccueil.CsSite();
        List<Galatee.Silverlight.ServiceAccueil.CsProduit> lProduitSelect = new List<Galatee.Silverlight.ServiceAccueil.CsProduit>();
        List<int> lesDeCentre = new List<int>();
        List<int> lesDeSite = new List<int>();

        private void ChargerDonneeDuSite()
        {
            try
            {
                if (SessionObject.LstCentre != null && SessionObject.LstCentre.Count > 0)
                {
                    LstCentrePerimetre = Shared.ClasseMEthodeGenerique.RetourCentreByPerimetre(SessionObject.LstCentre.Where(p => p.CODE != SessionObject.Enumere.Generale).ToList(), UserConnecte.listeProfilUser);
                    lstSite = Galatee.Silverlight.Shared.ClasseMEthodeGenerique.RetourneSiteByCentre(LstCentrePerimetre);
                    foreach (Galatee.Silverlight.ServiceAccueil.CsCentre item in LstCentrePerimetre)
                        lesCentreCaisse.Add(item.PK_ID);

                    if (lstSite != null && lstSite.Count != 0)
                    {
                        if (lstSite.Count == 1)
                        {
                            lSiteSelect = lstSite.First();
                            // this.cbo_Site.ItemsSource = lSiteSelect.LIBELLE;
                            this.cbo_Site.Tag = lSiteSelect.PK_ID;
                            lProduit = LstCentrePerimetre.FirstOrDefault(t => t.FK_IDCODESITE == (int)this.cbo_Site.Tag).LESPRODUITSDUSITE.First();


                            this.cbo_Site.ItemsSource = null;
                            this.cbo_Site.ItemsSource = lstSite;
                            cbo_Site.DisplayMemberPath = "LIBELLE";
                            cbo_Site.SelectedValuePath = "PK_ID";

                            this.cbo_Centre.ItemsSource = null;
                            this.cbo_Centre.ItemsSource = LstCentrePerimetre;
                            cbo_Centre.DisplayMemberPath = "LIBELLE";
                            cbo_Centre.SelectedValuePath = "PK_ID";


                            this.cbo_Catégorie.ItemsSource = null;
                            this.cbo_Catégorie.ItemsSource = SessionObject.LstCategorie;
                            cbo_Catégorie.DisplayMemberPath = "LIBELLE";
                            cbo_Catégorie.SelectedValuePath = "PK_ID";


                        }
                        else
                        {
                            this.cbo_Site.ItemsSource = null;
                            this.cbo_Site.ItemsSource = lstSite;
                            cbo_Site.DisplayMemberPath = "LIBELLE";
                            cbo_Site.SelectedValuePath = "PK_ID";


                            this.cbo_Catégorie.ItemsSource = null;
                            this.cbo_Catégorie.ItemsSource = SessionObject.LstCategorie;
                            cbo_Catégorie.DisplayMemberPath = "LIBELLE";
                            cbo_Catégorie.SelectedValuePath = "PK_ID";

                        }
                    }
                    return;
                }
                Galatee.Silverlight.ServiceAccueil.AcceuilServiceClient service = new Galatee.Silverlight.ServiceAccueil.AcceuilServiceClient(Utility.ProtocoleFacturation(), Utility.EndPoint("Accueil"));
                service.ListeDesDonneesDesSiteCompleted += (s, args) =>
                {
                    if (args != null && args.Cancelled)
                        return;
                    SessionObject.LstCentre = args.Result;
                    LstCentrePerimetre = Shared.ClasseMEthodeGenerique.RetourCentreByPerimetre(SessionObject.LstCentre.Where(p => p.CODE != SessionObject.Enumere.Generale).ToList(), UserConnecte.listeProfilUser);
                    lstSite = Galatee.Silverlight.Shared.ClasseMEthodeGenerique.RetourneSiteByCentre(LstCentrePerimetre);
                    foreach (Galatee.Silverlight.ServiceAccueil.CsCentre item in LstCentrePerimetre)
                        lesCentreCaisse.Add(item.PK_ID);
                    if (lstSite != null && lstSite.Count != 0)
                    {
                        if (lstSite.Count == 1)
                        {
                            lSiteSelect = lstSite.First();
                            this.cbo_Site.ItemsSource = null;
                            this.cbo_Site.ItemsSource = lstSite;
                            cbo_Site.DisplayMemberPath = "LIBELLE";
                            cbo_Site.SelectedValuePath = "PK_ID";

                            this.cbo_Centre.ItemsSource = null;
                            this.cbo_Centre.ItemsSource = LstCentrePerimetre;
                            cbo_Centre.DisplayMemberPath = "LIBELLE";
                            cbo_Centre.SelectedValuePath = "PK_ID";



                            this.cbo_Catégorie.ItemsSource = null;
                            this.cbo_Catégorie.ItemsSource = SessionObject.LstCategorie;
                            cbo_Catégorie.DisplayMemberPath = "LIBELLE";
                            cbo_Catégorie.SelectedValuePath = "PK_ID";
                        }
                    }
                };
                service.ListeDesDonneesDesSiteAsync(false);
                service.CloseAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        private void ChargerCategorie()
        {
            try
            {
                if (SessionObject.LstCategorie.Count != 0)
                    return;
                Galatee.Silverlight.ServiceAccueil.AcceuilServiceClient service = new Galatee.Silverlight.ServiceAccueil.AcceuilServiceClient(Utility.ProtocoleFacturation(), Utility.EndPoint("Accueil"));
                service.RetourneCategorieCompleted += (s, args) =>
                {
                    if (args != null && args.Cancelled)
                        return;
                    SessionObject.LstCategorie = args.Result;

                    this.cbo_Catégorie.ItemsSource = null;
                    this.cbo_Catégorie.ItemsSource = SessionObject.LstCategorie;
                    cbo_Catégorie.DisplayMemberPath = "LIBELLE";
                    cbo_Catégorie.SelectedValuePath = "PK_ID";

                };
                service.RetourneCategorieAsync();
                service.CloseAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        private void btn_Site_Click(object sender, RoutedEventArgs e)
        {
              try{
                List<ServiceAccueil.CParametre> lstParametre = Shared.ClasseMEthodeGenerique.RetourneValueFromClasse<ServiceAccueil.CsSite>(lstSite);
                Shared.UcListeParametre ctr = new Galatee.Silverlight.Shared.UcListeParametre(lstParametre, true, "Site");
                LstParametresInit = lstParametre;

                ctr.Closed += new EventHandler(galatee_OkClickedSite);
                ctr.Show();

            }
            catch (Exception ex)
            {
                Message.ShowError(ex, "Erreur");
            }
        }
        ServiceAccueil.CsProduit lProduit = new ServiceAccueil.CsProduit();
        void galatee_OkClickedSite(object sender, EventArgs e)
        {

            try { 
             Shared.UcListeParametre ctrs = sender as Shared.UcListeParametre;
                if (ctrs.isOkClick)
                {
                    ListeDesSites = ctrs.MyObjectList as List<ServiceAccueil.CParametre>;
                    List<string> lstSites = ListeDesSites.Select(t => t.LIBELLE).ToList();
                 
                    cbo_Site.ItemsSource = lstSites;
                }

            }
            catch (Exception ex)
            {
                Message.ShowError(ex, "Erreur");
            }


        }

        public void retourneFacture(bool IsGroup)
        {
            try
            {
                prgBar.Visibility = System.Windows.Visibility.Visible;

                string Compte = string.Empty;
                Galatee.Silverlight.ServiceReport.ReportServiceClient service = new Galatee.Silverlight.ServiceReport.ReportServiceClient(Utility.ProtocoleFacturation(), Utility.EndPoint("Report"));
                service.ReturneCompabilisationRecapAsync(LstCentrePerimetre.Where(t => t.FK_IDCODESITE == lSiteSelect.PK_ID).Select(o => o.PK_ID).ToList(), Shared.ClasseMEthodeGenerique.FormatPeriodeAAAAMM(this.txt_Periode.Text), IsGroup);
                service.ReturneCompabilisationRecapCompleted += (s, args) =>
                {
                    try
                    {
                        prgBar.Visibility = System.Windows.Visibility.Collapsed;

                        if (args.Cancelled || args.Error != null)
                        {
                            string error = args.Error.InnerException.ToString();
                            return;
                        }
                        if (args.Result != null && args.Result.Count == 0)
                        {
                            Message.ShowInformation("Aucune données trouvées", "Comptabilisation");
                            return;
                        }
                        else
                        {
                            string Rdlc = string.Empty;
                            if (leEtatExecuter == SessionObject.ComptaFacturation) Rdlc = "ComptabilisationFac";
                            else if (leEtatExecuter == SessionObject.RecapComptaFacturation) Rdlc = "RecapFacturationGroup";

                            if (OptionImpression == SessionObject.EnvoiPrinter)
                                Utility.ActionDirectOrientation<ServicePrintings.CsComptabilisation, ServiceReport.CsComptabilisation>(args.Result, param, SessionObject.CheminImpression, Rdlc, "Report", true);
                            else if (OptionImpression == SessionObject.EnvoiExecl)
                                Utility.ActionExportation<ServicePrintings.CsComptabilisation, ServiceReport.CsComptabilisation>(args.Result, param, string.Empty, SessionObject.CheminImpression, Rdlc, "Report", true, "xlsx");

                            else if (OptionImpression == SessionObject.EnvoiWord)
                                Utility.ActionExportation<ServicePrintings.CsComptabilisation, ServiceReport.CsComptabilisation>(args.Result, param, string.Empty, SessionObject.CheminImpression, Rdlc, "Report", true, "doc");

                            else if (OptionImpression == SessionObject.EnvoiPdf)
                                Utility.ActionExportation<ServicePrintings.CsComptabilisation, ServiceReport.CsComptabilisation>(args.Result, param, string.Empty, SessionObject.CheminImpression, Rdlc, "Report", true, "pdf");

                        }
                    }
                    catch (Exception ex)
                    {
                        Message.ShowError(ex, Galatee.Silverlight.Resources.Caisse.Langue.errorTitle);
                    }
                };


            }
            catch (Exception)
            {

                throw;
            }

        }
        private void RetourneEncaissemntMoisComptat(List<int> lesDeCentre, string Periode)
        {
            prgBar.Visibility = System.Windows.Visibility.Visible;

            Galatee.Silverlight.ServiceReport.ReportServiceClient service1 = new Galatee.Silverlight.ServiceReport.ReportServiceClient(Utility.ProtocoleFacturation(), Utility.EndPoint("Report"));
            service1.ReturneEncaissementParMoisComptableCompleted += (sr, res) =>
            {
                prgBar.Visibility = System.Windows.Visibility.Collapsed;

                if (res != null && res.Cancelled)
                    return;

                if (res.Result != null && res.Result.Count != 0)
                {
                    string Rdlc = "FacEncaissementParMoisComptable";
                    if (OptionImpression == SessionObject.EnvoiPrinter)
                        Utility.ActionDirectOrientation<ServicePrintings.CsTranscaisse, ServiceReport.CsTranscaisse>(res.Result, null, SessionObject.CheminImpression, Rdlc, "Report", true);
                    else if (OptionImpression == SessionObject.EnvoiExecl)
                        Utility.ActionExportation<ServicePrintings.CsTranscaisse, ServiceReport.CsTranscaisse>(res.Result, null, string.Empty, SessionObject.CheminImpression, Rdlc, "Report", true, "xlsx");

                    else if (OptionImpression == SessionObject.EnvoiWord)
                        Utility.ActionExportation<ServicePrintings.CsTranscaisse, ServiceReport.CsTranscaisse>(res.Result, null, string.Empty, SessionObject.CheminImpression, Rdlc, "Report", true, "doc");

                    else if (OptionImpression == SessionObject.EnvoiPdf)
                        Utility.ActionExportation<ServicePrintings.CsTranscaisse, ServiceReport.CsTranscaisse>(res.Result, null, string.Empty, SessionObject.CheminImpression, Rdlc, "Report", true, "pdf");
                }
                else
                {
                    Message.ShowInformation("Aucune information trouvée", "Report");
                    return;
                }
            };
            service1.ReturneEncaissementParMoisComptableAsync(lesDeCentre, Periode);
            service1.CloseAsync();


        }
        Dictionary<string, string> param = new Dictionary<string, string>();
        string OptionImpression = SessionObject.EnvoiPdf;
        private void OKButton_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                Galatee.Silverlight.Shared.FrmOptionEditon ctrl = new Shared.FrmOptionEditon();
                ctrl.Closed += ctrl_Closed;
                this.IsEnabled = false;
                ctrl.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        void ctrl_Closed(object sender, EventArgs e)
        {
            this.IsEnabled = true;
            Galatee.Silverlight.Shared.FrmOptionEditon ctrs = sender as Galatee.Silverlight.Shared.FrmOptionEditon;
            if (ctrs.IsOptionChoisi)
            {
                OptionImpression = ctrs.OptionSelect;
                RechercherDonnee();

            }
        }

        private void RechercherDonnee()
        {
            lesDeCentre.Add(lSiteSelect.PK_ID);


            string key = Utility.getKey();
            if (leEtatExecuter == SessionObject.RecapComptaFacturation) retourneFacture(true);
            else if (leEtatExecuter == SessionObject.ComptaFacturation)
                retourneFacture(false);
            else if (leEtatExecuter == SessionObject.Statfacturation)
            {
                prgBar.Visibility = System.Windows.Visibility.Visible;

                if (string.IsNullOrEmpty(this.txt_Periode.Text))
                {
                    Message.ShowWarning("Veuillez saisir la période", "Vente");
                    return;
                }

                int idSite = 0;
                if (this.cbo_Site.SelectedItem != null)
                    idSite = ((ServiceAccueil.CsSite)this.cbo_Site.SelectedItem).PK_ID;

                int idCentre = 0;
                if (this.cbo_Centre.SelectedItem != null)
                    idCentre = ((ServiceAccueil.CsCentre)this.cbo_Centre.SelectedItem).PK_ID;

                int idSecteur = 0;
                //if (this.cbo_Secteur.SelectedItem != null)
                //    idSecteur = ((ServiceAccueil.CsSecteur)this.cbo_Secteur.SelectedItem).PK_ID;

                int idProduit = 0;
                //if (this.cbo_Produit.SelectedItem != null)
                //    idProduit = ((ServiceAccueil.CsProduit)this.cbo_Produit.SelectedItem).PK_ID;

                int idCategorie = 0;
                if (this.cbo_Catégorie.SelectedItem != null)
                    idCategorie = ((ServiceAccueil.CsCategorieClient)this.cbo_Catégorie.SelectedItem).PK_ID;

                Galatee.Silverlight.ServiceReport.ReportServiceClient service = new Galatee.Silverlight.ServiceReport.ReportServiceClient(Utility.ProtocoleFacturation(), Utility.EndPoint("Report"));
                service.ReturneStatistiqueCompleted += (s, args) =>
                {
                    prgBar.Visibility = System.Windows.Visibility.Collapsed;

                    if (args != null && args.Cancelled)
                    {
                        Message.ShowInformation("Problème d'accès aux données", "Report");
                        return;
                    }

                    if (args.Result == null || args.Result.Count == 0)
                    {
                        Message.ShowInformation("Aucune information trouvée", "Report");
                        return;
                    }


                    if (param != null && param.Count() != 0) param.Clear();

                    if (this.ckbAnnee.IsChecked.Value)
                        param.Add("pPeriode", this.txt_Periode.Text.Substring(3,4));
                    else
                        param.Add("pPeriode", this.txt_Periode.Text);
                    param.Add("pAgence", this.cbo_Site.ItemsSource.ToString());
                    string Rdlc = string.Empty;
                    
                    List<ServiceReport.CsStatFact> lstStatfact = args.Result;


                    if (OptionImpression == SessionObject.EnvoiPrinter)
                    {
                        if (args.Result.Where(a => a.CONSOMATIONREACTIVE == 1) != null && args.Result.Where(a => a.CONSOMATIONREACTIVE == 1).ToList().Count > 0)
                            Utility.ActionDirectOrientation<ServicePrintings.CsStatFact, ServiceReport.CsStatFact>(args.Result.Where(a => a.CONSOMATIONREACTIVE == 1).ToList(), param, SessionObject.CheminImpression, "RecapStatFacturation", "Report", true);
                        if (args.Result.Where(a => a.CONSOMATIONREACTIVE == 2) != null && args.Result.Where(a => a.CONSOMATIONREACTIVE == 2).ToList().Count > 0)
                            Utility.ActionDirectOrientation<ServicePrintings.CsStatFact, ServiceReport.CsStatFact>(args.Result.Where(a => a.CONSOMATIONREACTIVE == 2).ToList(), param, SessionObject.CheminImpression, "RecapStatDemande", "Report", true);
                    }
                    else if (OptionImpression == SessionObject.EnvoiExecl)
                    {
                        if (args.Result.Where(a => a.CONSOMATIONREACTIVE == 1) != null && args.Result.Where(a => a.CONSOMATIONREACTIVE == 1).ToList().Count > 0)
                            Utility.ActionExportation<ServicePrintings.CsStatFact, ServiceReport.CsStatFact>(args.Result.Where(a => a.CONSOMATIONREACTIVE == 1).ToList(), param, string.Empty, SessionObject.CheminImpression, "RecapStatFacturation", "Report", true, "xlsx");
                        if (args.Result.Where(a => a.CONSOMATIONREACTIVE == 2) != null && args.Result.Where(a => a.CONSOMATIONREACTIVE == 2).ToList().Count > 0)
                            Utility.ActionExportation<ServicePrintings.CsStatFact, ServiceReport.CsStatFact>(args.Result.Where(a => a.CONSOMATIONREACTIVE == 2).ToList(), param, string.Empty, SessionObject.CheminImpression, "RecapStatDemande", "Report", true, "xlsx");
                    }

                    else if (OptionImpression == SessionObject.EnvoiWord)
                    {
                        if (args.Result.Where(a => a.CONSOMATIONREACTIVE == 1) != null && args.Result.Where(a => a.CONSOMATIONREACTIVE == 1).ToList().Count > 0)
                            Utility.ActionExportation<ServicePrintings.CsStatFact, ServiceReport.CsStatFact>(args.Result.Where(a => a.CONSOMATIONREACTIVE == 1).ToList(), param, string.Empty, SessionObject.CheminImpression, "RecapStatFacturation", "Report", true, "doc");
                        if (args.Result.Where(a => a.CONSOMATIONREACTIVE == 2) != null && args.Result.Where(a => a.CONSOMATIONREACTIVE == 2).ToList().Count > 0)
                            Utility.ActionExportation<ServicePrintings.CsStatFact, ServiceReport.CsStatFact>(args.Result.Where(a => a.CONSOMATIONREACTIVE == 2).ToList(), param, string.Empty, SessionObject.CheminImpression, "RecapStatDemande", "Report", true, "doc");
                    }
                    else if (OptionImpression == SessionObject.EnvoiPdf)
                    {
                        if (args.Result.Where(a => a.CONSOMATIONREACTIVE == 1) != null && args.Result.Where(a => a.CONSOMATIONREACTIVE == 1).ToList().Count > 0)
                            Utility.ActionExportation<ServicePrintings.CsStatFact, ServiceReport.CsStatFact>(args.Result.Where(a => a.CONSOMATIONREACTIVE == 1).ToList(), param, string.Empty, SessionObject.CheminImpression, "RecapStatFacturation", "Report", true, "pdf");
                        if (args.Result.Where(a => a.CONSOMATIONREACTIVE == 2) != null && args.Result.Where(a => a.CONSOMATIONREACTIVE == 2).ToList().Count > 0)
                            Utility.ActionExportation<ServicePrintings.CsStatFact, ServiceReport.CsStatFact>(args.Result.Where(a => a.CONSOMATIONREACTIVE == 2).ToList(), param, string.Empty, SessionObject.CheminImpression, "RecapStatDemande", "Report", true, "pdf");
                    }
                };
                service.ReturneStatistiqueAsync(idSite, idCentre, idSecteur, idProduit, idCategorie, Shared.ClasseMEthodeGenerique.FormatPeriodeAAAAMM(this.txt_Periode.Text), false, this.ckbAnnee.IsChecked.Value);
                service.CloseAsync();
            }


            else if (leEtatExecuter == SessionObject.StatfacturationIsolee)
            {
                prgBar.Visibility = System.Windows.Visibility.Visible;

                if (string.IsNullOrEmpty(this.txt_Periode.Text))
                {
                    Message.ShowWarning("Veuillez saisir la période", "Vente");
                    return;
                }

                int idSite = 0;
                if (this.cbo_Site.SelectedItem != null)
                    idSite = ((ServiceAccueil.CsSite)this.cbo_Site.SelectedItem).PK_ID;

                int idCentre = 0;
                if (this.cbo_Centre.SelectedItem != null)
                    idCentre = ((ServiceAccueil.CsCentre)this.cbo_Centre.SelectedItem).PK_ID;

                int idSecteur = 0;
                //if (this.cbo_Secteur.SelectedItem != null)
                //    idSecteur = ((ServiceAccueil.CsSecteur)this.cbo_Secteur.SelectedItem).PK_ID;

                int idProduit = 0;
                //if (this.cbo_Produit.SelectedItem != null)
                //    idProduit = ((ServiceAccueil.CsProduit)this.cbo_Produit.SelectedItem).PK_ID;

                int idCategorie = 0;
                if (this.cbo_Catégorie.SelectedItem != null)
                    idCategorie = ((ServiceAccueil.CsCategorieClient)this.cbo_Catégorie.SelectedItem).PK_ID;

                Galatee.Silverlight.ServiceReport.ReportServiceClient service = new Galatee.Silverlight.ServiceReport.ReportServiceClient(Utility.ProtocoleFacturation(), Utility.EndPoint("Report"));
                service.ReturneStatistiqueCompleted += (s, args) =>
                {
                    prgBar.Visibility = System.Windows.Visibility.Collapsed;

                    if (args != null && args.Cancelled)
                        return;

                    if (param != null && param.Count() != 0) param.Clear();
                    if (this.ckbAnnee.IsChecked.Value)
                        param.Add("pPeriode", this.txt_Periode.Text.Substring(3, 4));
                    else
                        param.Add("pPeriode", this.txt_Periode.Text);
                    param.Add("pAgence", this.cbo_Site.ItemsSource.ToString());
                    string Rdlc = string.Empty;

                    List<ServiceReport.CsStatFact> lstStatfact = args.Result;

                    Rdlc = "RecapStatFacturationIsolee";


                    if (OptionImpression == SessionObject.EnvoiPrinter)
                        Utility.ActionDirectOrientation<ServicePrintings.CsStatFact, ServiceReport.CsStatFact>(args.Result, param, SessionObject.CheminImpression, Rdlc, "Report", true);
                    else if (OptionImpression == SessionObject.EnvoiExecl)
                        Utility.ActionExportation<ServicePrintings.CsStatFact, ServiceReport.CsStatFact>(args.Result, param, string.Empty, SessionObject.CheminImpression, Rdlc, "Report", true, "xlsx");

                    else if (OptionImpression == SessionObject.EnvoiWord)
                        Utility.ActionExportation<ServicePrintings.CsStatFact, ServiceReport.CsStatFact>(args.Result, param, string.Empty, SessionObject.CheminImpression, Rdlc, "Report", true, "doc");

                    else if (OptionImpression == SessionObject.EnvoiPdf)
                        Utility.ActionExportation<ServicePrintings.CsStatFact, ServiceReport.CsStatFact>(args.Result, param, string.Empty, SessionObject.CheminImpression, Rdlc, "Report", true, "pdf");
                };
                service.ReturneStatistiqueAsync(idSite, idCentre, idSecteur, idProduit, idCategorie, Shared.ClasseMEthodeGenerique.FormatPeriodeAAAAMM(this.txt_Periode.Text), true, this.ckbAnnee.IsChecked.Value);
                service.CloseAsync();
            }


            else if (leEtatExecuter == SessionObject.CompteurFacturePeriode)
            {
              
                if (this.cbo_Site.ItemsSource != null)
                // lstIdAnomalie = this.Txt_LibelleAnomalie.Tag != null ? (List<int>)this.Txt_LibelleAnomalie.Tag : new List<int>();
                {
                    foreach (ServiceAccueil.CParametre st in this.ListeDesSites)
                    {
                        lesDeSite.Add(st.PK_ID);
                    }
                    
                }

                else
                {
                    Message.ShowWarning("Veuillez sélectionnez le site", "Validation");
                    return;
                }
               // lesDeCentre.Add(lSiteSelect.CODE, LstCentrePerimetre.Where(i => i.CODESITE == lSiteSelect.CODE).Select(p => p.PK_ID).ToList());
                lesDeCentre.Add(lSiteSelect.PK_ID);
            }
            else if (leEtatExecuter == SessionObject.EncaissementCumule)
                RetourneEncaissemntMoisComptat(LstCentrePerimetre.Where(i => i.CODESITE == lSiteSelect.CODE).Select(p => p.PK_ID).ToList(), Shared.ClasseMEthodeGenerique.FormatPeriodeAAAAMM(this.txt_Periode.Text));
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }


        #region Y2R 21/02/2019 garder les élements cocher en memoire
        List<ServiceAccueil.CParametre> LstParametresInit = new List<ServiceAccueil.CParametre>();
        #endregion

        private void cbo_Secteur_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cbo_Site_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.cbo_Site.SelectedItem != null)
            {
                //this.cbo_Centre.ItemsSource = LstCentrePerimetre.Where(a => a.FK_IDCODESITE == ((ServiceAccueil.CsSite)this.cbo_Site.SelectedItem).PK_ID).ToList();
                //cbo_Site.DisplayMemberPath = "LIBELLE";
                //cbo_Site.SelectedValuePath = "PK_ID";

                this.cbo_Centre.ItemsSource = null;
                this.cbo_Centre.ItemsSource = LstCentrePerimetre.Where(a => a.FK_IDCODESITE == ((ServiceAccueil.CsSite)this.cbo_Site.SelectedItem).PK_ID).ToList();
                cbo_Centre.DisplayMemberPath = "LIBELLE";
                cbo_Centre.SelectedValuePath = "PK_ID";
            }

        }



    }
}

