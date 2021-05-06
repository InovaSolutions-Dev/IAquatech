﻿using System;
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
using Galatee.Silverlight.ServiceRecouvrement ;
using Galatee.Silverlight.MainView;
using Galatee.Silverlight.Shared;
using Galatee.Silverlight.Resources.Index;


namespace Galatee.Silverlight.Recouvrement
{
    public partial class FrmAffectationPIATournee : ChildWindow
    {

        public FrmAffectationPIATournee()
        {
            InitializeComponent();
            Translate();
            ChargerDonneeDuSite();
        }
        List<ServiceAccueil.CsCentre> lesCentre = new List<ServiceAccueil.CsCentre>();
        List<ServiceAccueil.CsSite> lstSite = new List<ServiceAccueil.CsSite>();

        private void ChargerDonneeDuSite()
        {
            try
            {
                if (SessionObject.LstCentre != null && SessionObject.LstCentre.Count != 0)
                {
                    List<int> IdDesCentre = new List<int>();
                     lesCentre = Shared.ClasseMEthodeGenerique.RetourCentreByPerimetre(SessionObject.LstCentre, UserConnecte.listeProfilUser);
                     lstSite = Shared.ClasseMEthodeGenerique.RetourneSiteByCentre(lesCentre);
                     if (lstSite != null && lstSite.Count == 1)
                     {
                         this.Txt_Site.Text = lstSite.First().CODE;
                         this.txt_LibelleSite.Text = lstSite.First().LIBELLE;
                         this.Txt_Site.Tag = lstSite.First().PK_ID;

                     }
                     if (lesCentre != null && lesCentre.Count == 1)
                     {
                         this.Txt_Centre.Text = lesCentre.First().CODE;
                         this.txt_libellecentre.Text = lesCentre.First().LIBELLE;
                         this.Txt_Centre.Tag = lesCentre.First().PK_ID;
                         ChargerListeAgentPIA(lesCentre.First().PK_ID, "260");

                     }
                    foreach (ServiceAccueil.CsCentre item in lesCentre)
                        IdDesCentre.Add(item.PK_ID);
                    ChargerListeTourneePIA(this.Txt_Site.Text);
                    return;
                }

                Galatee.Silverlight.ServiceAccueil.AcceuilServiceClient service = new Galatee.Silverlight.ServiceAccueil.AcceuilServiceClient(Utility.ProtocoleFacturation(), Utility.EndPoint("Accueil"));
                service.ListeDesDonneesDesSiteCompleted += (s, args) =>
                {
                    if (args != null && args.Cancelled)
                        return;
                    SessionObject.LstCentre = args.Result;
                    List<int> IdDesCentre = new List<int>();
                    lesCentre = Shared.ClasseMEthodeGenerique.RetourCentreByPerimetre(SessionObject.LstCentre, UserConnecte.listeProfilUser);
                    lstSite = Shared.ClasseMEthodeGenerique.RetourneSiteByCentre(lesCentre);
                    foreach (ServiceAccueil.CsCentre item in lesCentre)
                        IdDesCentre.Add(item.PK_ID);


                    if (lstSite != null && lstSite.Count == 1)
                    {
                        this.Txt_Site.Text = lstSite.First().CODE;
                        this.txt_LibelleSite .Text = lstSite.First().LIBELLE ;
                        this.Txt_Site.Tag  = lstSite.First().PK_ID ;

                    }
                    if (lesCentre != null && lesCentre.Count == 1)
                    {
                        this.Txt_Centre.Text = lesCentre.First().CODE ;
                        this.txt_libellecentre.Text = lesCentre.First().LIBELLE;
                        this.Txt_Centre.Tag = lesCentre.First().PK_ID;
                        ChargerListeAgentPIA(lesCentre.First().PK_ID, "260");


                    }
                    foreach (ServiceAccueil.CsCentre item in lesCentre)
                        IdDesCentre.Add(item.PK_ID);
                    ChargerListeTourneePIA(this.Txt_Site.Text);
                };
                service.ListeDesDonneesDesSiteAsync(true);
                service.CloseAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        List<CsTournee> ListeTournee;
        private void ChargerListeTourneePIA(string CodeSite)
        {
            ListeTournee = new List<CsTournee>();
            Galatee.Silverlight.ServiceRecouvrement.RecouvrementServiceClient service = new Galatee.Silverlight.ServiceRecouvrement.RecouvrementServiceClient(Utility.ProtocoleFacturation(), Utility.EndPoint("Recouvrement"));
            service.RetourneTourneeParPIAAsync(CodeSite);
            service.RetourneTourneeParPIACompleted += (s, args) =>
            {
                try
                {
                    if (args.Cancelled || args.Error != null)
                    {
                        Message.ShowError("Erreur survenue à l'appel du service.", "Erreur");
                        return;
                    }

                    if (args.Result == null || args.Result.Count == 0)
                    {
                        Message.ShowError("Aucune tournée retournée par le système.", "Info");
                        return;
                    }
                    ListeTournee = args.Result;
                    
                }
                catch (Exception ex)
                {
                    Message.ShowError(ex, "Erreur");
                }
            };
        }

        List<CsUtilisateur > ListeUtilisateurPia;
        private void ChargerListeAgentPIA(int idCentre,string CodeFonction)
        {
            ListeUtilisateurPia = new List<CsUtilisateur>();
            Galatee.Silverlight.ServiceRecouvrement.RecouvrementServiceClient service = new Galatee.Silverlight.ServiceRecouvrement.RecouvrementServiceClient(Utility.ProtocoleFacturation(), Utility.EndPoint("Recouvrement"));
            service.RetourneListeUtiliasteurPiaAsync(idCentre, CodeFonction);
            service.RetourneListeUtiliasteurPiaCompleted += (s, args) =>
            {
                try
                {
                    if (args.Cancelled || args.Error != null)
                    {
                        Message.ShowError("Erreur survenue à l'appel du service.", "Erreur");
                        return;
                    }

                    if (args.Result == null || args.Result.Count == 0)
                    {
                        Message.ShowError("Aucune tournée retournée par le système.", "Info");
                        return;
                    }
                    ListeUtilisateurPia = args.Result;

                    this.CboAgentPia.ItemsSource = null;
                    this.CboAgentPia.ItemsSource = ListeUtilisateurPia;
                    this.CboAgentPia.DisplayMemberPath = "LIBELLE";
                    this.CboAgentPia.ItemsSource = ListeUtilisateurPia.Where(t => t.FK_IDCENTRE == (int)this.Txt_Centre.Tag);
                }
                catch (Exception ex)
                {
                    Message.ShowError(ex, "Erreur");
                }
            };
        }
        private void btn_Centre_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                List<string> _LstColonneAffich = new List<string>();
                _LstColonneAffich.Add("CODE");
                _LstColonneAffich.Add("LIBELLE");
                List<object> obj = Shared.ClasseMEthodeGenerique.RetourneListeObjet(lesCentre.Where(t => t.FK_IDCODESITE == (int)this.Txt_Site.Tag).ToList());
                MainView.UcListeGenerique ctrl = new MainView.UcListeGenerique(obj, _LstColonneAffich, false, "Lots");
                ctrl.Closed += new EventHandler(galatee_OkClickedCentre);
                ctrl.Show();
            }
            catch (Exception ex)
            {
                Message.ShowError(ex, "Erreur");
            }
        }

        void galatee_OkClickedCentre(object sender, EventArgs e)
        {
            try
            {
                MainView.UcListeGenerique ctrs = sender as MainView.UcListeGenerique;
                ServiceAccueil.CsCentre param = (ServiceAccueil.CsCentre)ctrs.MyObject;//.VALEUR;
                this.Txt_Centre.Text = param.CODE;
                txt_libellecentre.Text = param.LIBELLE;
                this.Txt_Centre.Tag = param.PK_ID;
                ChargerListeAgentPIA(param.PK_ID, "260");
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
                List<string> _LstColonneAffich = new List<string>();
                _LstColonneAffich.Add("CODE");
                _LstColonneAffich.Add("LIBELLE");
                List<object> obj = Shared.ClasseMEthodeGenerique.RetourneListeObjet(lstSite);
                MainView.UcListeGenerique ctrl = new MainView.UcListeGenerique(obj, _LstColonneAffich, false, "Site");
                ctrl.Closed += new EventHandler(galatee_OkClickedSite);
                ctrl.Show();
            }
            catch (Exception ex)
            {
                Message.ShowError(ex, "Erreur");
            }
        }

        void galatee_OkClickedSite(object sender, EventArgs e)
        {
            try
            {
                MainView.UcListeGenerique ctrs = sender as MainView.UcListeGenerique;
                ServiceAccueil.CsSite param = (ServiceAccueil.CsSite)ctrs.MyObject;//.VALEUR;
                this.Txt_Site.Text = param.CODE;
                txt_LibelleSite.Text = param.LIBELLE;
                this.Txt_Site.Tag = param.PK_ID;
                this.btn_Centre.IsEnabled = true;
                ChargerListeTourneePIA(this.Txt_Site.Text);
            }
            catch (Exception ex)
            {
                Message.ShowError(ex, "Erreur");
            }
        }
        private void OKButton_Click(object sender, RoutedEventArgs e)
        {

            List<CsTournee> lstTournee = (List<CsTournee>)this.dataGrid2.ItemsSource;
            if (this.CboAgentPia .SelectedItem != null)
            {
                foreach (CsTournee item in lstTournee)
                {
                  item.FK_IDADMUTILISATEUR  = ((CsUtilisateur )this.CboAgentPia.SelectedItem).PK_ID  ;
                  item.FK_IDTOURNEE = item.PK_ID ;
                  item.DATEDEBUT = System.DateTime.Today.Date;
                  item.MATRICULEPIA = ((CsUtilisateur)this.CboAgentPia.SelectedItem).MATRICULE;
                }
                ValiderAffectation(lstTournee);
            }

            this.DialogResult = true;
        }
        private void ValiderAffectation(List<CsTournee> lstTournee)
        {
            try
            {
                Galatee.Silverlight.ServiceRecouvrement.RecouvrementServiceClient service = new Galatee.Silverlight.ServiceRecouvrement.RecouvrementServiceClient(Utility.ProtocoleFacturation(), Utility.EndPoint("Recouvrement"));
                service.SaveAffectationTourneAsync(lstTournee);
                service.SaveAffectationTourneCompleted += (s, args) =>
                {
                    try
                    {
                        if (args != null && args.Cancelled)
                        {
                            Message.ShowError("Erreur survenue lors de l'appel du service.", "Erreur");
                            return;
                        }

                        if (args.Result == false )
                        {
                        }
                        else
                            Message.ShowInformation ("Mise à jour validée", "Affectation");
                    }
                    catch (Exception ex)
                    {
                        Message.ShowError(ex, "Erreur");
                    }
                };

                this.dataGrid1.IsEnabled = true;
            }
            catch (Exception ex)
            {
                Message.ShowError(ex, "Erreur");
            }
        }



        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void ChildWindow_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                OKButton.IsEnabled = false;
            }
            catch (Exception ex)
            {
                Message.ShowError(ex, "Erreur");
            }
        }

        private void Translate()
        {
        }

        private void btn_Recherche_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (this.Txt_Centre.Tag != null && this.CboAgentPia .SelectedItem != null)
                {
                    List<int> lstidCentre = new List<int>();
                    lstidCentre.Add((int)this.Txt_Centre.Tag);
                    if (ListeTournee != null && ListeTournee.Count != 0)
                    {
                        this.dataGrid1.ItemsSource = null;
                        this.dataGrid1.ItemsSource = ListeTournee.Where(t => t.FK_IDCENTRE == (int)this.Txt_Centre.Tag && t.MATRICULEPIA   != ((CsUtilisateur)this.CboAgentPia.SelectedItem).MATRICULE ).ToList();

                        this.dataGrid2.ItemsSource = null;
                        this.dataGrid2.ItemsSource = ListeTournee.Where(t => t.FK_IDCENTRE == (int)this.Txt_Centre.Tag && t.MATRICULEPIA  == ((CsUtilisateur)this.CboAgentPia.SelectedItem).MATRICULE ).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                Message.ShowError(ex, "Erreur");
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<CsTournee> ListeSelect = ((List<CsTournee>)this.dataGrid1.ItemsSource).Where(t => t.IsSelect  == true).ToList();
            foreach (CsTournee item in ListeSelect)
            {
                item.IsSelect = false;
                //item.NOMRELEVEUR = ((CsReleveur)this.CboReleveur.SelectedItem).NOMRELEVEUR;
                //item.FK_IDRELEVEUR  = ((CsReleveur)this.CboReleveur.SelectedItem).PK_ID ;
                dataGrid1.SelectedItems.Add(item);
            }
            Galatee.Silverlight.Shared.CommonMethode.TransfertDataGrid<CsTournee>(dataGrid1, dataGrid2);
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            List<CsTournee> ListeSelect = ((List<CsTournee>)this.dataGrid2.ItemsSource).Where(t => t.IsSelect == true).ToList();
            foreach (CsTournee item in ListeSelect)
            {
                item.IsSelect = false;
                dataGrid2.SelectedItems.Add(item);
            }
            Galatee.Silverlight.Shared.CommonMethode.TransfertDataGrid<CsTournee>(dataGrid2, dataGrid1);
            if (this.dataGrid1.ItemsSource != null)
            {
                List<CsTournee> lstNouvelle = ((List<CsTournee>)this.dataGrid1.ItemsSource).ToList();
                this.dataGrid1.ItemsSource = null;
                this.dataGrid1.ItemsSource = lstNouvelle.OrderBy(o => o.CODE).ToList();
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid2.ItemsSource != null)
            {
                List<CsTournee> lesCasSelect = ((List<CsTournee>)dataGrid2.ItemsSource);
                lesCasSelect.ForEach(t => t.IsSelect = true);
                this.OKButton.IsEnabled = true;

            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid1.ItemsSource != null)
            {
                List<CsTournee> lesCasSelect = ((List<CsTournee>)dataGrid1.ItemsSource);
                lesCasSelect.ForEach(t => t.IsSelect = false);

                this.OKButton.IsEnabled = true;
            }
        }

 

 
        private void dataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.dataGrid1.SelectedItem != null)
            {
                if (((CsTournee)this.dataGrid1.SelectedItem).IsSelect  == false)
                    ((CsTournee)this.dataGrid1.SelectedItem).IsSelect = true;
                else
                    ((CsTournee)this.dataGrid1.SelectedItem).IsSelect = false;
            }
        }

        private void dataGrid2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.dataGrid2.SelectedItem != null)
            {
                if (((CsTournee)this.dataGrid2.SelectedItem).IsSelect == false)
                    ((CsTournee)this.dataGrid2.SelectedItem).IsSelect = true;
                else
                    ((CsTournee)this.dataGrid2.SelectedItem).IsSelect = false;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            List<CsTournee> ListeSelect = ((List<CsTournee>)this.dataGrid2.ItemsSource).ToList();
            foreach (CsTournee item in ListeSelect)
            {
                item.IsSelect = false;
                dataGrid2.SelectedItems.Add(item);
            }
            Galatee.Silverlight.Shared.CommonMethode.TransfertDataGrid<CsTournee>(dataGrid2, dataGrid1);
        }
        //private void ValiderAffectation()
        //{
        //    try
        //    {
        //        List<CsTournee> lstTourneAffecter = (List<CsTournee>)this.dataGrid2.ItemsSource;
        //        foreach (CsTournee item in lstTourneAffecter)
        //        {
        //            item.FK_IDTOURNEE = item.PK_ID;
        //            item.FK_IDRELEVEUR = ((CsReleveur)this.CboReleveur.SelectedItem).PK_ID;
        //        }
        //        IndexServiceClient service = new IndexServiceClient(Utility.ProtocoleFacturation(), Utility.EndPoint("Index"));
        //        service.ValiderAffectationAsync(lstTourneAffecter);
        //        service.ValiderAffectationCompleted += (s, args) =>
        //        {
        //            try
        //            {
        //                if (args != null && args.Cancelled)
        //                {
        //                    Message.ShowError("Erreur survenue lors de l'appel du service.", "Erreur");
        //                    return;
        //                }
        //                if (args.Result == false )
        //                {
        //                    Message.ShowError("Aucun releveur retourné par le système.", "Information");
        //                    return;
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                Message.ShowError(ex, "Erreur");
        //            }
        //        };
        //        this.dataGrid1.IsEnabled = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        Message.ShowError(ex, "Erreur");
        //    }
        //}
       
    }
}

