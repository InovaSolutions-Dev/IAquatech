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
    public partial class FrmStatistiquesEncaissement : ChildWindow
    {
        public FrmStatistiquesEncaissement()
        {
            InitializeComponent();
            ChargerModeReglement();
            ChargerCategorie();
            RemplirListeDesSecteur();
            ChargerDonneeDuSite();
            prgBar.Visibility = System.Windows.Visibility.Collapsed;
        }
        string leEtatExecuter = string.Empty;
        public FrmStatistiquesEncaissement(string typeEtat)
        {
            InitializeComponent();
            ChargerModeReglement();
            ChargerCategorie();
            RemplirListeDesSecteur();
            ChargerDonneeDuSite();
            leEtatExecuter = typeEtat;
            prgBar.Visibility = System.Windows.Visibility.Collapsed;
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


                            this.cbo_Mode.ItemsSource = null;
                            this.cbo_Mode.ItemsSource = SessionObject.LstDesModereg;
                            cbo_Mode.DisplayMemberPath = "LIBELLE";
                            cbo_Mode.SelectedValuePath = "PK_ID";

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


                            this.cbo_Mode.ItemsSource = null;
                            this.cbo_Mode.ItemsSource = SessionObject.LstDesModereg;
                            cbo_Mode.DisplayMemberPath = "LIBELLE";
                            cbo_Mode.SelectedValuePath = "PK_ID";

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


                            this.cbo_Mode.ItemsSource = null;
                            this.cbo_Mode.ItemsSource = SessionObject.LstDesModereg;
                            cbo_Mode.DisplayMemberPath = "LIBELLE";
                            cbo_Mode.SelectedValuePath = "PK_ID";

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




        private void ChargerModeReglement()
        {
            try
            {
                if (SessionObject.LstDesModereg != null && SessionObject.LstDesModereg.Count != 0)
                    return;
                Galatee.Silverlight.ServiceCaisse.CaisseServiceClient service = new Galatee.Silverlight.ServiceCaisse.CaisseServiceClient(Utility.ProtocoleFacturation(), Utility.EndPoint("Caisse"));
                service.RetourneModesReglementCompleted += (s, args) =>
                {
                    if (args != null && args.Cancelled)
                        return;
                    SessionObject.LstDesModereg = args.Result;
                };
                service.RetourneModesReglementAsync();
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


        private void RemplirListeDesSecteur()
        {
            try
            {
                if (SessionObject.LstSecteur != null && SessionObject.LstSecteur.Count != 0)
                    return;

                Galatee.Silverlight.ServiceAccueil.AcceuilServiceClient service = new Galatee.Silverlight.ServiceAccueil.AcceuilServiceClient(Utility.ProtocoleFacturation(), Utility.EndPoint("Accueil"));
                service.ChargerLesSecteursAsync();
                service.ChargerLesSecteursCompleted += (s, args) =>
                {
                    if (args != null && args.Cancelled)
                        return;
                    SessionObject.LstSecteur = args.Result;
                };
                service.CloseAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btn_Site_Click(object sender, RoutedEventArgs e)
        {
            try
            {
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

            try
            {
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
            DateTime DateDebut = System.DateTime.Today;
            DateTime DateFin = System.DateTime.Today;


            lesDeCentre.Add(lSiteSelect.PK_ID);


            string key = Utility.getKey();
            
            if (leEtatExecuter == SessionObject.VolumeEncaissement)
            {
                prgBar.Visibility = System.Windows.Visibility.Visible;

                DateDebut = string.IsNullOrEmpty(this.dtpDebut.Text) ? DateDebut : Convert.ToDateTime(this.dtpDebut.Text);
                DateFin = string.IsNullOrEmpty(this.dtpFin.Text) ? DateFin : Convert.ToDateTime(this.dtpFin.Text);

                int idSite = 0;
                if (this.cbo_Site.SelectedItem != null)
                    idSite = ((ServiceAccueil.CsSite)this.cbo_Site.SelectedItem).PK_ID;

                int idCentre = 0;
                if (this.cbo_Centre.SelectedItem != null)
                    idCentre = ((ServiceAccueil.CsCentre)this.cbo_Centre.SelectedItem).PK_ID;

                int idSecteur = 0;
                //if (this.cbo_Secteur.SelectedItem != null)
                //    idSecteur = ((ServiceAccueil.CsSecteur)this.cbo_Secteur.SelectedItem).PK_ID;

                int idMode = 0;
                if (this.cbo_Mode.SelectedItem != null)
                    idMode = ((ServiceCaisse.CsModereglement)this.cbo_Mode.SelectedItem).PK_ID;

                int idCategorie = 0;
                if (this.cbo_Catégorie.SelectedItem != null)
                    idCategorie = ((ServiceAccueil.CsCategorieClient)this.cbo_Catégorie.SelectedItem).PK_ID;

                Galatee.Silverlight.ServiceReport.ReportServiceClient service = new Galatee.Silverlight.ServiceReport.ReportServiceClient(Utility.ProtocoleFacturation(), Utility.EndPoint("Report"));
                service.VolumeEncaissementCompleted += (s, args) =>
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

                    param.Add("pPeriode", "");

                    if (idSite == 0)
                        param.Add("pAgence", "Tous les centres");
                    else
                        param.Add("pAgence", lstSite.FirstOrDefault(a => a.PK_ID == idSite).LIBELLE);

                    
                    List<ServiceReport.CsLclient> lstStatfact = args.Result;


                    if (OptionImpression == SessionObject.EnvoiPrinter)
                    {
                        if (args.Result.Where(a => a.STATUS == "1") != null && args.Result.Where(a => a.STATUS == "1").ToList().Count > 0)
                            Utility.ActionDirectOrientation<ServicePrintings.CsLclient, ServiceReport.CsLclient>(args.Result.Where(a => a.STATUS == "1").ToList(), param, SessionObject.CheminImpression, "VolumeEncaissements", "Report", true);
                        if (args.Result.Where(a => a.STATUS == "2") != null && args.Result.Where(a => a.STATUS == "2").ToList().Count > 0)
                            Utility.ActionDirectOrientation<ServicePrintings.CsLclient, ServiceReport.CsLclient>(args.Result.Where(a => a.STATUS == "2").ToList(), param, SessionObject.CheminImpression, "VolumeEncaissementsDem", "Report", true);
                    }
                    else if (OptionImpression == SessionObject.EnvoiExecl)
                    {
                        if (args.Result.Where(a => a.STATUS == "1") != null && args.Result.Where(a => a.STATUS == "1").ToList().Count > 0)
                            Utility.ActionExportation<ServicePrintings.CsLclient, ServiceReport.CsLclient>(args.Result.Where(a => a.STATUS == "1").ToList(), param, string.Empty, SessionObject.CheminImpression, "VolumeEncaissements", "Report", true, "xlsx");
                        if (args.Result.Where(a => a.STATUS == "2") != null && args.Result.Where(a => a.STATUS == "2").ToList().Count > 0)
                            Utility.ActionExportation<ServicePrintings.CsLclient, ServiceReport.CsLclient>(args.Result.Where(a => a.STATUS == "2").ToList(), param, string.Empty, SessionObject.CheminImpression, "VolumeEncaissementsDem", "Report", true, "xlsx");
                    }
                    //Utility.ActionExportation<ServicePrintings.CsLclient, ServiceReport.CsLclient>(args.Result, param, string.Empty, SessionObject.CheminImpression, Rdlc, "Report", true, "xlsx");

                    else if (OptionImpression == SessionObject.EnvoiWord)
                    {
                        if (args.Result.Where(a => a.STATUS == "1") != null && args.Result.Where(a => a.STATUS == "1").ToList().Count > 0)
                            Utility.ActionExportation<ServicePrintings.CsLclient, ServiceReport.CsLclient>(args.Result.Where(a => a.STATUS == "1").ToList(), param, string.Empty, SessionObject.CheminImpression, "VolumeEncaissements", "Report", true, "doc");
                        if (args.Result.Where(a => a.STATUS == "2") != null && args.Result.Where(a => a.STATUS == "2").ToList().Count > 0)
                            Utility.ActionExportation<ServicePrintings.CsLclient, ServiceReport.CsLclient>(args.Result.Where(a => a.STATUS == "2").ToList(), param, string.Empty, SessionObject.CheminImpression, "VolumeEncaissementsDem", "Report", true, "doc");
                    }
                    else if (OptionImpression == SessionObject.EnvoiPdf)
                    {
                        if (args.Result.Where(a => a.STATUS == "1") != null && args.Result.Where(a => a.STATUS == "1").ToList().Count > 0)
                            Utility.ActionExportation<ServicePrintings.CsLclient, ServiceReport.CsLclient>(args.Result.Where(a => a.STATUS == "1").ToList(), param, string.Empty, SessionObject.CheminImpression, "VolumeEncaissements", "Report", true, "pdf");
                        if (args.Result.Where(a => a.STATUS == "2") != null && args.Result.Where(a => a.STATUS == "2").ToList().Count > 0)
                            Utility.ActionExportation<ServicePrintings.CsLclient, ServiceReport.CsLclient>(args.Result.Where(a => a.STATUS == "2").ToList(), param, string.Empty, SessionObject.CheminImpression, "VolumeEncaissementsDem", "Report", true, "pdf");
                    }
                };
                service.VolumeEncaissementAsync(idSite, idCentre, idMode, idCategorie, DateDebut, DateFin);
                service.CloseAsync();
            }


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

