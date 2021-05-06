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
    public partial class FrmVolumeEncaissement : ChildWindow
    {
        public FrmVolumeEncaissement()
        {
            InitializeComponent();
            ChargerDonneeDuSite();
            ChargerListeDeProduit();
            ChargerTournee();
            ChargerCategorie();
            ChargerListeAgent();
            RemplirListeDesSecteur();
            DecocherLesEltsInitialisation();
        }
        string leEtatExecuter = string.Empty;
      
        List<ServiceAccueil.CParametre> ListeCategorie;
        List<ServiceAccueil.CParametre> _LesTypeDemandeSelect;
        List<ServiceAccueil.CParametre> _LesSecteurSelect;
        Shared.UcListeParametre ListCheckeditems = new Shared.UcListeParametre();
        List<ServiceAccueil.CParametre> _LesCentreSelect;
        //  List<ServiceAccueil.CsTournee> lstTourneCentre;
        List<ServiceAccueil.CParametre> ListeDesTournee;
        List<ServiceAccueil.CParametre> _LesAgentSelect;
        List<ServiceAccueil.CParametre> _LesSiteSelect;
        public FrmVolumeEncaissement(string typeEtat)
        {
            InitializeComponent();
            leEtatExecuter = typeEtat;
            ChargerDonneeDuSite();
            ChargerModeReglement();
            ChargerListeDeProduit();
            ChargerTournee();
            ChargerCategorie();
            ChargerListeAgent();
            RemplirListeDesSecteur();
            DecocherLesEltsInitialisation();
            prgBar.Visibility = System.Windows.Visibility.Collapsed;
            switch (leEtatExecuter)
            {


                case SessionObject.VOLUMEIMPAYE:
                    //Txt_LibelleSite.Visibility = System.Windows.Visibility.Collapsed;
                    //btn_Site.Visibility = System.Windows.Visibility.Collapsed;
                    //lbl_site.Visibility = System.Windows.Visibility.Collapsed;

                    Txt_LibelleSite.IsEnabled = false;
                    btn_Site.IsEnabled = false;
                    lbl_site.IsEnabled = false;

                    //champs Secteur a afficher sur frmDemande
                    cbo_comboSecteur.Visibility = System.Windows.Visibility.Visible;
                    btn_Secteur.Visibility = System.Windows.Visibility.Visible;
                    lbl_Secteur.Visibility = System.Windows.Visibility.Visible;

                    cbo_comboTournee.IsEnabled = false;
                    btn_Tournee.IsEnabled = false;
                    lbl_Tournee.IsEnabled = false;

                    cbo_comboAgent.IsEnabled = false;
                    btn_Agent.IsEnabled = false;
                    lbl_Agent.IsEnabled = false;

                    cbo_comboAgent.IsEnabled = false;
                    btn_Agent.IsEnabled = false;
                    lbl_Agent.IsEnabled = false;

                    cbo_comboCategorie.Visibility = System.Windows.Visibility.Visible;
                    btn_Categorie.Visibility = System.Windows.Visibility.Visible;
                    lbl_Categorie.Visibility = System.Windows.Visibility.Visible;

                    cbo_comboSite.Visibility = System.Windows.Visibility.Visible;
                    btn_Centre.Visibility = System.Windows.Visibility.Visible;
                    lbl_Centre.Visibility = System.Windows.Visibility.Visible;

                    //cbo_comboProduit.IsEnabled = false;
                    //btn_Produit.IsEnabled = false;
                    //lbl_Produit.IsEnabled = false;

                    lbl_Centre_Copy3.Visibility = System.Windows.Visibility.Visible;
                    dtp_DateDebut.Visibility = System.Windows.Visibility.Visible;
                    dtp_DateDebut.IsEnabled = false;
                    lbl_Centre_Copy4.Visibility = System.Windows.Visibility.Visible;
                    dtp_DateFin.Visibility = System.Windows.Visibility.Visible;

                    break;

                case SessionObject.ENCAISSEMENTENCOURS:
                    //Txt_LibelleSite.Visibility = System.Windows.Visibility.Collapsed;
                    //btn_Site.Visibility = System.Windows.Visibility.Collapsed;
                    //lbl_site.Visibility = System.Windows.Visibility.Collapsed;

                    Txt_LibelleSite.IsEnabled = false;
                    btn_Site.IsEnabled = false;
                    lbl_site.IsEnabled = false;

                    //champs Secteur a afficher sur frmDemande
                    cbo_comboSecteur.Visibility = System.Windows.Visibility.Visible;
                    btn_Secteur.Visibility = System.Windows.Visibility.Visible;
                    lbl_Secteur.Visibility = System.Windows.Visibility.Visible;

                    cbo_comboTournee.IsEnabled = false;
                    btn_Tournee.IsEnabled = false;
                    lbl_Tournee.IsEnabled = false;

                    cbo_comboAgent.IsEnabled = false;
                    btn_Agent.IsEnabled = false;
                    lbl_Agent.IsEnabled = false;

                    cbo_comboAgent.IsEnabled = false;
                    btn_Agent.IsEnabled = false;
                    lbl_Agent.IsEnabled = false;

                    cbo_comboCategorie.Visibility = System.Windows.Visibility.Visible;
                    btn_Categorie.Visibility = System.Windows.Visibility.Visible;
                    lbl_Categorie.Visibility = System.Windows.Visibility.Visible;

                    cbo_comboSite.Visibility = System.Windows.Visibility.Visible;
                    btn_Centre.Visibility = System.Windows.Visibility.Visible;
                    lbl_Centre.Visibility = System.Windows.Visibility.Visible;

                    cbo_comboProduit.IsEnabled = false;
                    btn_Produit.IsEnabled = false;
                    lbl_Produit.IsEnabled = false;

                    lbl_Centre_Copy3.Visibility = System.Windows.Visibility.Visible;
                    dtp_DateDebut.Visibility = System.Windows.Visibility.Visible;
                    lbl_Centre_Copy4.Visibility = System.Windows.Visibility.Visible;
                    dtp_DateFin.Visibility = System.Windows.Visibility.Visible;

                    break;


            }


        }


        private void ChargerModeReglement()
        {
            try
            {
                if (SessionObject.ListeDesReglement.Count != 0)
                    return;
                Galatee.Silverlight.ServiceAccueil.AcceuilServiceClient service = new Galatee.Silverlight.ServiceAccueil.AcceuilServiceClient(Utility.ProtocoleFacturation(), Utility.EndPoint("Accueil"));
                service.ListeDesReglementCompleted += (s, args) =>
                {
                    if (args != null && args.Cancelled)
                        return;
                    SessionObject.ListeDesReglement = args.Result;
                };
                service.ListeDesReglementAsync();
                service.CloseAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



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



        //private void OKButton_Click(object sender, RoutedEventArgs e)
        private void RechercherDonnee()
        {
            //this.DialogResult = true;


            List<int> lstIdCentre = new List<int>();
            List<int> lstIdSecteur = new List<int>();
            List<int> lstIdCategorie = new List<int>();
            List<int> lstIdProduit = new List<int>();
            List<int> lstIdTournee = new List<int>();
            List<int> lstIdAgent = new List<int>();
            DateTime DateFin = System.DateTime.Today;
            DateTime DateDebut = DateFin.AddYears(-100);

            switch (leEtatExecuter)
            {

                case SessionObject.RETABLISSEMENTEFFECTUE:

                    if (this.cbo_comboSite.ItemsSource != null)
                    {
                        foreach (ServiceAccueil.CParametre st in this._LesCentreSelect)
                        {
                            lstIdCentre.Add(st.PK_ID);
                        }
                    }

                    else
                    {
                        Message.ShowWarning("Veuillez sélectionnez le Centre", "Validation");
                        return;
                    }

                    if (this.cbo_comboCategorie.ItemsSource != null)
                    //  lstIdCategorie = this.Txt_LibelleCategorie.Tag != null ? (List<int>)this.Txt_LibelleCategorie.Tag : new List<int>();
                    {

                        foreach (ServiceAccueil.CParametre st in this.ListeCategorie)
                        {
                            lstIdCategorie.Add(st.PK_ID);
                        }
                    }


                    else
                    {
                        Message.ShowWarning("Veuillez sélectionnez la categorie", "Validation");
                        return;
                    }


                    DateDebut = string.IsNullOrEmpty(this.dtp_DateDebut.Text) ? DateDebut : Convert.ToDateTime(this.dtp_DateDebut.Text);
                    DateFin = string.IsNullOrEmpty(this.dtp_DateFin.Text) ? DateFin : Convert.ToDateTime(this.dtp_DateFin.Text);

                    prgBar.Visibility = System.Windows.Visibility.Visible;

                    RetablissementEffectue(lstIdCategorie, lstIdSecteur, lstIdCentre, lstIdTournee, lstIdProduit, lstIdAgent, DateDebut, DateFin);


                    break;




            }


        }

        private void RetablissementEffectue(List<int> lstIdCategorie, List<int> lstIdSecteur, List<int> lstIdCentre, List<int> lstIdTournee, List<int> lstIdProduit, List<int> lstIdAgent, DateTime DateDebut, DateTime DateFin)
        {
            Galatee.Silverlight.ServiceReport.ReportServiceClient service1 = new Galatee.Silverlight.ServiceReport.ReportServiceClient(Utility.ProtocoleFacturation(), Utility.EndPoint("Report"));
            service1.RetourneRetablissementEffectueCompleted += (sr, res) =>
            {
                prgBar.Visibility = System.Windows.Visibility.Collapsed;
                //Txt_LibelleSite.Visibility = System.Windows.Visibility.Collapsed;
                //btn_Site.Visibility = System.Windows.Visibility.Collapsed;
                //lbl_site.Visibility = System.Windows.Visibility.Collapsed;
                if (res != null && res.Cancelled)
                    return;

                if (res.Result != null && res.Result.Count != 0)
                {
                    Dictionary<string, string> param = new Dictionary<string, string>();
                    param.Add("pParametre", "LISTE DE RETABLISSEMENTS EFFECTUES");
                    Utility.ActionExportation<ServicePrintings.CsLclient, ServiceReport.CsLclient>(res.Result, param, "EtatRetablissementEffectue", SessionObject.CheminImpression, "RetablissementEffectue", "Report", true, OptionImpression);

                }
                else
                {
                    Message.ShowInformation("Aucune information trouvée", "Report");
                    return;
                }
            };
            service1.RetourneRetablissementEffectueAsync(lstIdCategorie, lstIdSecteur, lstIdCentre, lstIdTournee, lstIdProduit, lstIdAgent, DateDebut, DateFin);
            service1.CloseAsync();

        }
        private void NbreRetablisementAutorises(List<int> lstIdCentre, List<int> lstIdSecteur, List<int> lstIdAgent, List<int> lstIdCategorie, List<int> lstIdTournee, List<int> lstIdProduit, DateTime DateDebut, DateTime DateFin)
        {
            Galatee.Silverlight.ServiceReport.ReportServiceClient service1 = new Galatee.Silverlight.ServiceReport.ReportServiceClient(Utility.ProtocoleFacturation(), Utility.EndPoint("Report"));
            service1.RetourneNbreRetablisementAutorisesCompleted += (sr, res) =>
            {
                prgBar.Visibility = System.Windows.Visibility.Collapsed;
                //Txt_LibelleSite.Visibility = System.Windows.Visibility.Collapsed;
                //btn_Site.Visibility = System.Windows.Visibility.Collapsed;
                //lbl_site.Visibility = System.Windows.Visibility.Collapsed;
                if (res != null && res.Cancelled)
                    return;

                if (res.Result != null && res.Result.Count != 0)
                {
                    Dictionary<string, string> param = new Dictionary<string, string>();
                    param.Add("pParametre", "NOMBRE DE RETABLISSEMENTS AUTORISES");
                    Utility.ActionExportation<ServicePrintings.CsClient, ServiceReport.CsClient>(res.Result, param, "EtatNbreRetablisementAutorises", SessionObject.CheminImpression, "NbreRetablisementAutorises", "Report", true, OptionImpression);

                }
                else
                {
                    Message.ShowInformation("Aucune information trouvée", "Report");
                    return;
                }
            };
            service1.RetourneNbreRetablisementAutorisesAsync(lstIdCentre, lstIdSecteur, lstIdAgent, lstIdCategorie, lstIdTournee, lstIdProduit, DateDebut, DateFin);
            service1.CloseAsync();

        }


        private void RetourneFactureIsole(List<int> lstIdCentre, List<int> lstIdSecteur, List<int> lstIdCategorie, List<int> lstIdProduit, DateTime? DateDebut, DateTime? DateFin)
        {
            string periode = null;
            if (!string.IsNullOrEmpty(this.Txt_Periode.Text))
                periode = Shared.ClasseMEthodeGenerique.FormatPeriodeAAAAMM(this.Txt_Periode.Text);

            if (string.IsNullOrEmpty(this.dtp_DateDebut.Text))
                DateDebut = null;
            if (string.IsNullOrEmpty(this.dtp_DateFin.Text))
                DateFin = null;

            Galatee.Silverlight.ServiceReport.ReportServiceClient service1 = new Galatee.Silverlight.ServiceReport.ReportServiceClient(Utility.ProtocoleFacturation(), Utility.EndPoint("Report"));
            service1.ReturneFactureIsoleCompleted += (sr, res) =>
            {
                if (res != null && res.Cancelled)
                    return;

                if (res.Result != null && res.Result.Count != 0)
                {
                    string Rdlc = "FactureIsole";

                    Dictionary<string, string> param = new Dictionary<string, string>();
                    if (!string.IsNullOrEmpty(periode))
                        param.Add("pPeriode", periode);
                    else
                        param.Add("pPeriode", "");

                    if (!string.IsNullOrEmpty(this.dtp_DateDebut.Text))
                        param.Add("pDebut", DateDebut.Value.ToShortDateString());
                    else
                        param.Add("pDebut", "");

                    if (!string.IsNullOrEmpty(this.dtp_DateFin.Text))
                        param.Add("pFin", DateFin.Value.ToShortDateString());
                    else
                        param.Add("pFin", "");


                    if (OptionImpression == SessionObject.EnvoiPrinter)
                        Utility.ActionDirectOrientation<ServicePrintings.CsLclient, ServiceReport.CsLclient>(res.Result, param, SessionObject.CheminImpression, Rdlc, "Report", true);
                    else if (OptionImpression == SessionObject.EnvoiExecl)
                        Utility.ActionExportation<ServicePrintings.CsLclient, ServiceReport.CsLclient>(res.Result, param, string.Empty, SessionObject.CheminImpression, Rdlc, "Report", true, "xlsx");

                    else if (OptionImpression == SessionObject.EnvoiWord)
                        Utility.ActionExportation<ServicePrintings.CsLclient, ServiceReport.CsLclient>(res.Result, param, string.Empty, SessionObject.CheminImpression, Rdlc, "Report", true, "doc");

                    else if (OptionImpression == SessionObject.EnvoiPdf)
                        Utility.ActionExportation<ServicePrintings.CsLclient, ServiceReport.CsLclient>(res.Result, param, string.Empty, SessionObject.CheminImpression, Rdlc, "Report", true, "pdf");
                }
                else
                {
                    Message.ShowInformation("Aucune information trouvée", "Report");
                    return;
                }
            };
            service1.ReturneFactureIsoleAsync(lstIdCentre, lstIdSecteur, lstIdCategorie, lstIdProduit, DateDebut, DateFin, periode);
            service1.CloseAsync();


        }




 

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DecocherLesEltsInitialisation();
            this.DialogResult = false;
        }

        List<int> lesCentreCaisse = new List<int>();
        List<Galatee.Silverlight.ServiceAccueil.CsCentre> LstCentrePerimetre = new List<ServiceAccueil.CsCentre>();
        List<Galatee.Silverlight.ServiceAccueil.CsSite> lstSite = new List<Galatee.Silverlight.ServiceAccueil.CsSite>();
        Galatee.Silverlight.ServiceAccueil.CsSite lSiteSelect = new Galatee.Silverlight.ServiceAccueil.CsSite();
        List<Galatee.Silverlight.ServiceAccueil.CsProduit> lProduitSelect = new List<Galatee.Silverlight.ServiceAccueil.CsProduit>();
        List<Galatee.Silverlight.ServiceAccueil.CsTournee> lstTourneCentre = new List<Galatee.Silverlight.ServiceAccueil.CsTournee>();

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
                };
                service.RetourneCategorieAsync();
                service.CloseAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ChargerDonneeDuSite()
        {
            try
            {
                if (SessionObject.LstCentre != null && SessionObject.LstCentre.Count > 0)
                {
                    LstCentrePerimetre = Shared.ClasseMEthodeGenerique.RetourCentreByPerimetre(SessionObject.LstCentre.Where(p => p.LIBELLE != SessionObject.Enumere.Generale).ToList(), UserConnecte.listeProfilUser);
                    lstSite = Galatee.Silverlight.Shared.ClasseMEthodeGenerique.RetourneSiteByCentre(LstCentrePerimetre);
                    foreach (Galatee.Silverlight.ServiceAccueil.CsCentre item in LstCentrePerimetre)
                        lesCentreCaisse.Add(item.PK_ID);



                    if (lstSite != null && lstSite.Count != 0)
                    {
                        if (lstSite.Count == 1)
                        {
                            lSiteSelect = lstSite.First();
                           // this.Txt_LibelleSite.Text = lstSite.First().LIBELLE;
                          //  this.cbo_comboSite.ItemsSource = lstSite.First().LIBELLE;
                        }
                    }
                    if (LstCentrePerimetre.Count == 1)
                    {
                        this.cbo_comboForage.ItemsSource = LstCentrePerimetre;

                    }

                    lProduitSelect = LstCentrePerimetre.First().LESPRODUITSDUSITE;

                    //if (lProduitSelect != null && lProduitSelect.Count != 0)
                    //{
                    //    if (lProduitSelect.Count == 1)
                    //    {
                    //        this.Txt_Produit.Text = lProduitSelect.First().LIBELLE;
                    //        this.Txt_Produit.Tag = lProduitSelect.First().CODE;
                    //    }
                    //}
                    return;
                }
                Galatee.Silverlight.ServiceAccueil.AcceuilServiceClient service = new Galatee.Silverlight.ServiceAccueil.AcceuilServiceClient(Utility.ProtocoleFacturation(), Utility.EndPoint("Accueil"));
                service.ListeDesDonneesDesSiteCompleted += (s, args) =>
                {
                    if (args != null && args.Cancelled)
                        return;
                    SessionObject.LstCentre = args.Result;
                    LstCentrePerimetre = Shared.ClasseMEthodeGenerique.RetourCentreByPerimetre(SessionObject.LstCentre.Where(p => p.LIBELLE != SessionObject.Enumere.Generale).ToList(), UserConnecte.listeProfilUser);
                    lstSite = Galatee.Silverlight.Shared.ClasseMEthodeGenerique.RetourneSiteByCentre(LstCentrePerimetre);
                    foreach (Galatee.Silverlight.ServiceAccueil.CsCentre item in LstCentrePerimetre)
                        lesCentreCaisse.Add(item.PK_ID);


                    if (lstSite != null && lstSite.Count != 0)
                    {
                        if (lstSite.Count == 1)
                        {
                            lSiteSelect = lstSite.First();
                            //this.Txt_LibelleSite.Text = lstSite.First().LIBELLE;
                            this.cbo_comboSite.ItemsSource = lstSite.First().LIBELLE;
                        }
                    }
                    if (LstCentrePerimetre != null && LstCentrePerimetre.Count != 0)
                    {

                        if (LstCentrePerimetre.Count == 1)
                        {
                            this.cbo_comboForage.ItemsSource = LstCentrePerimetre.First().LIBELLE;
                            this.btn_Forage.IsEnabled = false;
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


        private void ChargerListeDeProduit()
        {
            try
            {
                if (SessionObject.ListeDesProduit != null && SessionObject.ListeDesProduit.Count != 0)
                    return;
                Galatee.Silverlight.ServiceAccueil.AcceuilServiceClient service1 = new Galatee.Silverlight.ServiceAccueil.AcceuilServiceClient(Utility.ProtocoleFacturation(), Utility.EndPoint("Accueil"));
                service1.ListeDesProduitCompleted += (sr, res) =>
                {
                    if (res != null && res.Cancelled)
                        return;
                    SessionObject.ListeDesProduit = res.Result;
                };
                service1.ListeDesProduitAsync();
                service1.CloseAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void ChargerTournee()
        {
            if (SessionObject.LstZone.Count != 0)
                return;
            Galatee.Silverlight.ServiceAccueil.AcceuilServiceClient service = new Galatee.Silverlight.ServiceAccueil.AcceuilServiceClient(Utility.ProtocoleFacturation(), Utility.EndPoint("Accueil"));
            service.ChargerLesTourneesCompleted += (s, args) =>
            {
                if (args != null && args.Cancelled)
                    return;
                SessionObject.LstZone = args.Result;
            };
            service.ChargerLesTourneesAsync();
            service.CloseAsync();
        }

        private void btn_Centre_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (LstCentrePerimetre.Count != 0)
                {
                    List<ServiceAccueil.CParametre> lstParametre = Shared.ClasseMEthodeGenerique.RetourneValueFromClasse<ServiceAccueil.CsCentre>(LstCentrePerimetre);

                    Shared.UcListeParametre ctr = new Galatee.Silverlight.Shared.UcListeParametre(lstParametre, true, "Centre");
                    LstParametresInit = lstParametre;

                    #region Y2R 21/02/2019 garder les élements cocher en memoire
                    SessionObject.ListCheckeditems = SessionObject.ListCheckedItemsSessionCentre;
                    if (null != ListCheckeditems && SessionObject.ListCheckeditems.Count > 0)
                        foreach (ServiceAccueil.CParametre lE in SessionObject.ListDesElts)
                        {
                            foreach (ServiceAccueil.CParametre lC in SessionObject.ListCheckeditems)
                            {
                                if (lC.CODE == lE.CODE && lC.LIBELLE == lE.LIBELLE)
                                    lE.IsSelect = lC.IsSelect;
                            }
                        }
                    #endregion
                    
                    ctr.Closed += new EventHandler(galatee_OkClickedCentre);
                    ctr.Show();
                }
            }
            catch (Exception ex)
            {
                Message.ShowError(ex, "Erreur");
            }
        }
        private void galatee_OkClickedCentre(object sender, EventArgs e)
        {
            try
            {

                Shared.UcListeParametre ctrs = sender as Shared.UcListeParametre;
                if (ctrs.isOkClick)
                {
                    _LesCentreSelect = ctrs.MyObjectList as List<ServiceAccueil.CParametre>;
                    List<string> lstCentre = _LesCentreSelect.Select(t => t.LIBELLE).ToList();
                    cbo_comboForage.ItemsSource = lstCentre;
                }
            }
            catch (Exception ex)
            {
                Message.ShowError(ex, "Erreur");
            }
        }

        private void btn_Site_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (lstSite.Count > 0)
                {
                    this.btn_Site.IsEnabled = false;

                    List<ServiceAccueil.CParametre> lstParametre = Shared.ClasseMEthodeGenerique.RetourneValueFromClasse<ServiceAccueil.CsSite>(lstSite);
                    Shared.UcListeParametre ctr = new Galatee.Silverlight.Shared.UcListeParametre(lstParametre, true, "Liste de centres");
                    LstParametresInit = lstParametre;

                    ctr.Closed += new EventHandler(galatee_OkClickedSite);
                    ctr.Show();
                }
            }
            catch (Exception ex)
            {
                Message.ShowError(ex.Message, "Report");
            }

        }
        void galatee_OkClickedSite(object sender, EventArgs e)
        {
            Shared.UcListeParametre ctrs = sender as Shared.UcListeParametre;
            if (ctrs.isOkClick)
            {
                _LesSiteSelect = ctrs.MyObjectList as List<ServiceAccueil.CParametre>;
                List<string> lstSite = _LesSiteSelect.Select(t => t.LIBELLE).ToList();
                cbo_comboSite.ItemsSource = lstSite;
                cbo_comboForage.ItemsSource = null;
            }
            this.btn_Site.IsEnabled = true;

        }



        private void btn_Categorie_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                List<ServiceAccueil.CParametre> lstParametre = Shared.ClasseMEthodeGenerique.RetourneValueFromClasse<ServiceAccueil.CsCategorieClient>(SessionObject.LstCategorie);
                Shared.UcListeParametre ctr = new Galatee.Silverlight.Shared.UcListeParametre(lstParametre, true, "Liste de catégorie");
                LstParametresInit = lstParametre;

                #region Y2R 21/02/2019 garder les élements cocher en memoire
                SessionObject.ListCheckeditems = SessionObject.ListCheckedItemsSessionCategorie;
                if (null != ListCheckeditems && SessionObject.ListCheckeditems.Count > 0)
                    foreach (ServiceAccueil.CParametre lE in SessionObject.ListDesElts)
                    {
                        foreach (ServiceAccueil.CParametre lC in SessionObject.ListCheckeditems)
                        {
                            if (lC.CODE == lE.CODE && lC.LIBELLE == lE.LIBELLE)
                                lE.IsSelect = lC.IsSelect;
                        }
                    }
                #endregion
                
                
                ctr.Closed += new EventHandler(categorie_OkClicked);
                ctr.Show();
            }
            catch (Exception ex)
            {
                Message.ShowError(ex, "Erreur");
            }

        }
        private void categorie_OkClicked(object sender, EventArgs e)
        {
            try
            {
                Shared.UcListeParametre ctrs = sender as Shared.UcListeParametre;
                if (ctrs.isOkClick)
                {
                    ListeCategorie = ctrs.MyObjectList as List<ServiceAccueil.CParametre>;
                    List<string> lstCategorie = ListeCategorie.Select(t => t.LIBELLE).ToList();
                    cbo_combCategorie.ItemsSource = lstCategorie;
                }
            }
            catch (Exception ex)
            {
                Message.ShowError(ex, "Erreur");
            }
        }

        private void btn_Mode_Click(object sender, RoutedEventArgs e)
        {
            if (SessionObject.ListeModesReglement != null && SessionObject.ListeModesReglement.Count > 0)
            {
                //this.btn_Produit.IsEnabled = false;
                //List<object> _Listgen = Galatee.Silverlight.Shared.ClasseMEthodeGenerique.RetourneListeObjet(lProduitSelect);
                //Galatee.Silverlight.MainView.UcListeGenerique ctr = new Galatee.Silverlight.MainView.UcListeGenerique(_Listgen, "CODE", "LIBELLE", "Liste");
                //ctr.Closed += new EventHandler(galatee_OkClickedProduit);
                //ctr.Show();
               

                //this.btn_Produit.IsEnabled = false;
                List<ServiceAccueil.CParametre> lstParametre = Shared.ClasseMEthodeGenerique.RetourneValueFromClasse<ServiceAccueil.CsProduit>(SessionObject.ListeModesReglement.);
                Shared.UcListeParametre ctr = new Galatee.Silverlight.Shared.UcListeParametre(lstParametre, true, "Produit");
                LstParametresInit = lstParametre;


                #region Y2R 21/02/2019 garder les élements cocher en memoire
                SessionObject.ListCheckeditems = SessionObject.ListCheckedItemsSessionProduit;
                if (null != ListCheckeditems && SessionObject.ListCheckeditems.Count > 0)
                    foreach (ServiceAccueil.CParametre lE in SessionObject.ListDesElts)
                    {
                        foreach (ServiceAccueil.CParametre lC in SessionObject.ListCheckeditems)
                        {
                            if (lC.CODE == lE.CODE && lC.LIBELLE == lE.LIBELLE)
                                lE.IsSelect = lC.IsSelect;
                        }
                    }
                #endregion
                
                ctr.Closed += new EventHandler(galatee_OkClickedProduit);
                ctr.Show();
            }
        }
        void galatee_OkClickedProduit(object sender, EventArgs e)
        {
            //Galatee.Silverlight.MainView.UcListeGenerique ctrs = sender as Galatee.Silverlight.MainView.UcListeGenerique;
            //if (ctrs.isOkClick)
            //{
            //    ServiceAccueil.CsProduit leProduit = (ServiceAccueil.CsProduit)ctrs.MyObject;
            //    this.Txt_Produit.Text = leProduit.LIBELLE;
            //    this.Txt_Produit.Tag = leProduit.CODE;
            //}
            //this.btn_Produit.IsEnabled = true;

            //if (cbo_comboProduit.ItemsSource == null)
            //{

            //}
            //else
            //{

            //}
          
            this.btn_Produit.IsEnabled = true;
            Shared.UcListeParametre ctrs = sender as Shared.UcListeParametre;
            if (ctrs.isOkClick)
            {


                _LesTypeDemandeSelect = ctrs.MyObjectList as List<ServiceAccueil.CParametre>;
                List<string> lstProduit = _LesTypeDemandeSelect.Select(t => t.LIBELLE).ToList();
                //foreach (string item in lstCentre)
                //    this.Txt_LibelleProduit.Text = item + " " + this.Txt_LibelleProduit.Text;
                //this.Txt_LibelleProduit.Tag = _LesTypeDemandeSelect.Select(t => t.CODE).ToList();
               
               cbo_comboProduit.ItemsSource = lstProduit;
            }

        }

        private void btn_Agent_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                this.btn_Agent.IsEnabled = false;
                foreach (var agent in SessionObject.lstAgent)
                    agent.CODE = agent.MATRICULE;
                List<ServiceAccueil.CParametre> lstParametre = Shared.ClasseMEthodeGenerique.RetourneValueFromClasse<ServiceAccueil.CsUtilisateur>(SessionObject.lstAgent);
                Shared.UcListeParametre ctr = new Galatee.Silverlight.Shared.UcListeParametre(lstParametre, true, "UTILISATEUR");
                LstParametresInit = lstParametre;

                #region Y2R 21/02/2019 garder les élements cocher en memoire
                SessionObject.ListCheckeditems = SessionObject.ListCheckedItemsSessionUTILISATEUR;
                if (null != ListCheckeditems && SessionObject.ListCheckeditems.Count > 0)
                    foreach (ServiceAccueil.CParametre lE in SessionObject.ListDesElts)
                    {
                        foreach (ServiceAccueil.CParametre lC in SessionObject.ListCheckeditems)
                        {
                            if (lC.CODE == lE.CODE && lC.LIBELLE == lE.LIBELLE)
                                lE.IsSelect = lC.IsSelect;
                        }
                    }
                #endregion
                
                ctr.Closed += new EventHandler(galatee_OkClickedAgent);
                ctr.Show();
            }
            catch (Exception ex)
            {
                Message.ShowError(ex, "Erreur");
            }
        }



        private void ChargerListeAgent()
        {
            try
            {
                if (SessionObject.lstAgent!=null &&   SessionObject.lstAgent.Count != 0)
                    return;
                Galatee.Silverlight.ServiceAccueil.AcceuilServiceClient service = new Galatee.Silverlight.ServiceAccueil.AcceuilServiceClient(Utility.ProtocoleFacturation(), Utility.EndPoint("Accueil"));
                service.ChargerListeAgentCompleted += (s, args) =>
                {
                    if (args != null && args.Cancelled)
                        return;
                    SessionObject.lstAgent = args.Result;
                };
                service.ChargerListeAgentAsync();
                service.CloseAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void galatee_OkClickedAgent(object sender, EventArgs e)
        {

            //try
            //    {
            this.btn_Agent.IsEnabled = true;
            Shared.UcListeParametre ctrs = sender as Shared.UcListeParametre;
            if (ctrs.isOkClick)
            {
                _LesAgentSelect = ctrs.MyObjectList as List<ServiceAccueil.CParametre>;
                List<string> lstAgent = _LesAgentSelect.Select(t => t.LIBELLE).ToList();
                cbo_comboAgent.ItemsSource = lstAgent;
                //foreach (string item in lstAgent)
                //    this.Txt_LibelleAgent.Text = item + " " + this.Txt_LibelleAgent.Text;

                //this.Txt_LibelleAgent.Tag = _LesAgentSelect.Select(t => t.PK_ID).ToList();
                ////}
                ////catch (Exception ex)
                ////{
                ////    Message.ShowError(ex, "Erreur");
                //}
            }


        }



        List<ServiceAccueil.CsSecteur> ListSecteur = new List<ServiceAccueil.CsSecteur>();
        private void RemplirListeDesSecteur()
        {
            try
            {
                if (SessionObject.LstSecteur != null && SessionObject.LstSecteur.Count != 0)
                {
                    //ListSecteur = Shared.ClasseMEthodeGenerique.RetourneListCopy<ServiceAccueil.CsSecteur>(SessionObject.LstSecteur);
                    return;
                }
                Galatee.Silverlight.ServiceAccueil.AcceuilServiceClient service = new Galatee.Silverlight.ServiceAccueil.AcceuilServiceClient(Utility.ProtocoleFacturation(), Utility.EndPoint("Accueil"));
                service.ChargerLesSecteursAsync();
                service.ChargerLesSecteursCompleted += (s, args) =>
                {
                    if (args != null && args.Cancelled)
                        return;
                    SessionObject.LstSecteur = args.Result;
                    //ListSecteur = Shared.ClasseMEthodeGenerique.RetourneListCopy<ServiceAccueil.CsSecteur>(SessionObject.LstSecteur);
                };
                service.CloseAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        private void btn_Secteur_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                this.btn_Secteur.IsEnabled = false;
                List<ServiceAccueil.CParametre> lstParametre = Shared.ClasseMEthodeGenerique.RetourneValueFromClasse<ServiceAccueil.CsSecteur>(SessionObject.LstSecteur);
                //List<object> _Listgen = Galatee.Silverlight.Shared.ClasseMEthodeGenerique.RetourneListeObjet(SessionObject.LstSecteur.Where(t => t.FK_IDCENTRE == (int)this.Txt_LibelleCentre.Tag).ToList());
                Shared.UcListeParametre ctr = new Galatee.Silverlight.Shared.UcListeParametre(lstParametre, true, "Secteur");
                LstParametresInit = lstParametre;


                #region Y2R 21/02/2019 garder les élements cocher en memoire
                SessionObject.ListCheckeditems = SessionObject.ListCheckedItemsSessionSecteur;
                if (null != ListCheckeditems && SessionObject.ListCheckeditems.Count > 0)
                    foreach (ServiceAccueil.CParametre lE in SessionObject.ListDesElts)
                    {
                        foreach (ServiceAccueil.CParametre lC in SessionObject.ListCheckeditems)
                        {
                            if (lC.CODE == lE.CODE && lC.LIBELLE == lE.LIBELLE)
                                lE.IsSelect = lC.IsSelect;
                        }
                    }
                #endregion
                
                ctr.Closed += new EventHandler(galatee_OkClickedbtnSecteur);
                ctr.Show();
            }
            catch (Exception ex)
            {
                Message.ShowError(ex, "Erreur");
            }
        }
        void galatee_OkClickedbtnSecteur(object sender, EventArgs e)
        {

            this.btn_Secteur.IsEnabled = true;
            Shared.UcListeParametre ctrs = sender as Shared.UcListeParametre;
            if (ctrs.isOkClick)
            {
                _LesSecteurSelect = ctrs.MyObjectList as List<ServiceAccueil.CParametre>;
                List<string> lstSecteur = _LesSecteurSelect.Select(t => t.LIBELLE).ToList();
                cbo_comboSecteur.ItemsSource = lstSecteur;
                //foreach (string item in lstSecteur)
                //    this.Txt_LibelleSecteur.Text = item + " " + this.Txt_LibelleSecteur.Text;

                //this.Txt_LibelleSecteur.Tag = _LesSecteurSelect.Select(t => t.CODE).ToList();
                ////List<int> lstModeReg = _LesModeRegSelect.Select(t => t.PK_ID).ToList();
                ////foreach (int item in lstModeReg)
                ////    this.Txt_LibelleModeReg.Text = item + " " + this.Txt_LibelleModeReg.Text;

                //this.Txt_LibelleSecteur.Tag = _LesSecteurSelect.Select(t => t.PK_ID).ToList();
            }

        }
        //sceteur 13-11-2018
        #region Y2R 21/02/2019 garder les élements cocher en memoire
                List<ServiceAccueil.CParametre> LstParametresInit = new List<ServiceAccueil.CParametre>();
        private void DecocherLesEltsInitialisation()
        {
            if (SessionObject.ListCheckedItemsSessionCentre != null && null != LstParametresInit)
                SessionObject.ListCheckedItemsSessionCentre = LstParametresInit;

            if (SessionObject.ListCheckedItemsSessionSecteur != null && null != LstParametresInit)
                SessionObject.ListCheckedItemsSessionSecteur = LstParametresInit;

            if (SessionObject.ListCheckedItemsSessionUTILISATEUR != null && null != LstParametresInit)
                SessionObject.ListCheckedItemsSessionUTILISATEUR = LstParametresInit;

            if (SessionObject.ListCheckedItemsSessionPHASECOMPTEUR != null && null != LstParametresInit)
                SessionObject.ListCheckedItemsSessionPHASECOMPTEUR = LstParametresInit;

            if (SessionObject.ListCheckedItemsSessionTournee != null && null != LstParametresInit)
                SessionObject.ListCheckedItemsSessionTournee = LstParametresInit;

            if (SessionObject.ListCheckedItemsSessionCategorie != null && null != LstParametresInit)
                SessionObject.ListCheckedItemsSessionCategorie = LstParametresInit;

            if (SessionObject.ListCheckedItemsSessionProduit != null && null != LstParametresInit)
                SessionObject.ListCheckedItemsSessionProduit = LstParametresInit;
            //{
            //    SessionObject.ListCheckeditems = SessionObject.ListCheckedItemsSessionProduit;
            //    if (null != ListCheckeditems && SessionObject.ListCheckeditems.Count > 0)
            //        foreach (ServiceAccueil.CParametre lE in SessionObject.ListDesElts)
            //        {
            //            foreach (ServiceAccueil.CParametre lC in SessionObject.ListCheckeditems)
            //            {
            //                if (lC.CODE == lE.CODE && lC.LIBELLE == lE.LIBELLE)
            //                    lC.IsSelect = false;
            //                lE.IsSelect = lC.IsSelect;
            //            }
            //        }

            //}

        }
        #endregion





    }
}

