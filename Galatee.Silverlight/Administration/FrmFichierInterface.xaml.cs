using Galatee.Silverlight.ServiceAdministration;
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

namespace Galatee.Silverlight.Administration
{
    public partial class FrmFichierInterface : ChildWindow
    {
        public FrmFichierInterface()
        {
            InitializeComponent();
            ChargerDonneeDuSite();
            prgBar.Visibility = System.Windows.Visibility.Collapsed;
        }
        string leEtatExecuter = string.Empty;
        public FrmFichierInterface(string typeEtat)
        {
            InitializeComponent();
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

                        }
                        else
                        {
                            this.cbo_Site.ItemsSource = null;
                            this.cbo_Site.ItemsSource = lstSite;
                            cbo_Site.DisplayMemberPath = "LIBELLE";
                            cbo_Site.SelectedValuePath = "PK_ID";


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


        private void btn_Site_Click(object sender, RoutedEventArgs e)
        {
              try{
                List<ServiceAccueil.CParametre> lstParametre = Shared.ClasseMEthodeGenerique.RetourneValueFromClasse<ServiceAccueil.CsSite>(lstSite);
                Shared.UcListeParametre ctr = new Galatee.Silverlight.Shared.UcListeParametre(lstParametre, true, "Site");

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


        private void OKButton_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                RechercherDonnee();
                //this.IsEnabled = false;
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
                RechercherDonnee();

            }
        }

        private void RechercherDonnee()
        {
            prgBar.Visibility = System.Windows.Visibility.Visible;


            int idSite = 0;
            if (this.cbo_Site.SelectedItem != null)
                idSite = ((ServiceAccueil.CsSite)this.cbo_Site.SelectedItem).PK_ID;

            int idCentre = 0;
            if (this.cbo_Centre.SelectedItem != null)
                idCentre = ((ServiceAccueil.CsCentre)this.cbo_Centre.SelectedItem).PK_ID;

            if (leEtatExecuter == SessionObject.InterfacePaiement) 
            {
                AdministrationServiceClient service1 = new AdministrationServiceClient(Utility.ProtocoleFacturation(), Utility.EndPoint("Administration"));
                service1.GenererFichierImpayesCompleted += (sr, res) =>
                {
                    if (res != null && res.Cancelled)
                    {
                        prgBar.Visibility = System.Windows.Visibility.Collapsed;
                        Message.ShowInformation("Problème d'accès aux données", "Interface");
                        return;
                    }

                    //if (res.Result == null || res.Result.Count == 0)
                    if (!res.Result)
                    {
                        prgBar.Visibility = System.Windows.Visibility.Collapsed;
                        Message.ShowInformation("Soit aucune donnée trouvée, soit le fichier existe déjà, \n ou alors un problème est survenu lors de la génération du fichier.", "Interface");
                        return;
                    }

                    //if (CreerFichier(res.Result))
                    if (res.Result)
                    {
                        Message.ShowInformation("Fichier des impayés généré avec succès", "Interface");
                        this.cbo_Site.SelectedItem = null;
                        prgBar.Visibility = System.Windows.Visibility.Collapsed;
                    }

                };
                service1.GenererFichierImpayesAsync(idSite, idCentre, SessionObject.LePosteCourant.NOMPOSTE);
                service1.CloseAsync();
            
            }
            else if (leEtatExecuter == SessionObject.InterfaceTSP)
            {
            }


        }



        private bool CreerFichier(List<CsLclient> Liste)
        {
            try
            {
                // Set the path and filename variable "path", filename being MyTest.csv in this example.
                // Change SomeGuy for your username.
                string date = DateTime.Now.Day.ToString("00") + DateTime.Now.Month.ToString("00") + DateTime.Now.Year.ToString("0000");
                string file = @"IMPAYES" + DateTime.Now.Year.ToString("0000") + DateTime.Now.Month.ToString("00") + DateTime.Now.Day.ToString("00") + ".csv";
                //string path = SessionObject.CheminImpression.Replace('[', '\\') + file;
                string path = @"C:\Impression\Interface\" + file;

                if (SessionObject.LePosteCourant != null && !string.IsNullOrEmpty(SessionObject.LePosteCourant.NOMPOSTE))
                    path = @"\\" + SessionObject.LePosteCourant.NOMPOSTE + "\\Impression\\Interface\\" + file;



                // Set the variable "delimiter" to ", ".
                string delimiter = ";";

                // This text is added only once to the file.
                if (System.IO.File.Exists(path))
                {
                    Message.ShowInformation("Un fichier a déjà été généré à cette date", "Interface");
                    return false;
                }


                if (!System.IO.File.Exists(path))
                {
                    // Create a file to write to.
                    string text;
                    Guid cle = Guid.NewGuid();

                    text = "1;2211010000;" + date + ";BILL;1;0;0;0;0;0;0;0;0;0" + Environment.NewLine;
                    System.IO.File.WriteAllText(path, text, System.Text.Encoding.UTF8);

                    decimal total = 0;

                    for (int i = 0; i < Liste.Count; i++)
                    {
                        total += Liste[i].SOLDEFACTURE.Value;

                        text = "2;" + Liste[i].NDOC + delimiter + Liste[i].CLIENT + Liste[i].ORDRE + delimiter + " " + delimiter + Liste[i].NOM + delimiter + Liste[i].TELEPHONE + delimiter + Liste[i].sDATEFAC + delimiter + Liste[i].sDATEEXIG + delimiter + Liste[i].SOLDEFACTURE + delimiter + "XOF;" + Liste[i].ADRESSE + delimiter + Liste[i].sDATEDEBUT + delimiter + Liste[i].sDATEFIN + delimiter + Liste[i].REFEM + Environment.NewLine;
                        System.IO.File.AppendAllText(path, text, System.Text.Encoding.UTF8);
                    }

                    text = "3;2211010000;" + date + delimiter + Liste.Count + delimiter + total + ";0;0;0;0;0;0;0;0;0" + Environment.NewLine;
                    System.IO.File.AppendAllText(path, text, System.Text.Encoding.UTF8);

                    text = "0;0;0;0;0;0;0;0;0;0;0;0;0;0";
                    System.IO.File.AppendAllText(path, text, System.Text.Encoding.UTF8);

                }


                return true;


                // Open the file to read from.
                //string readText = File.ReadAllText(path);
                //Console.WriteLine(readText);

            }
            catch (Exception ex)
            {
                Message.ShowInformation(ex.Message, "Interface");
                return false;
            }
        }





        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
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

