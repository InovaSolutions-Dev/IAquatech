using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Collections.ObjectModel;
using Galatee.Silverlight.Classes;
using Galatee.Silverlight.ServiceAdministration;
using Galatee.Silverlight.Resources.Administration;

namespace Galatee.Silverlight.Administration
{
    public partial class UcListeReglement : ChildWindow
    {

        public UcListeReglement(string type)
        {
            try
            {
                InitializeComponent();
                prgBar.Visibility = System.Windows.Visibility.Collapsed;

                GetData();
            }
            catch (Exception ex)
            {

                Message.Show(ex.Message, "Liste règlements");
            }
        }

        List<CsLclient> affichage = new List<CsLclient>();
        private void GetData()
        {
            try
            {
                prgBar.Visibility = System.Windows.Visibility.Visible;
                this.btnValider.IsEnabled = false;


 /*               List<CsLclient> Factures = LireFichierReglement();



                if (Factures == null || Factures.Count == 0)
                    throw new Exception("Ce fichier ne contient aucune ligne de règlement.");

                if (Factures.Count != this.totalFactureAnnonce)
                    throw new Exception("Le nombre de ligne annonné dans le recapitulatif est différent du nombre réel de ligne du fichier.");


                if (Factures.Sum(a => a.MONTANT) != this.totalMontantAnnonce)
                    throw new Exception("Le montant total des règlements annonné dans le recapitulatif est différent de la somme des règlements du fichier.");

                this.txtNombre.Text = this.totalFactureAnnonce.ToString();
                this.txtMontant.Text = this.totalMontantAnnonce.Value.ToString(SessionObject.FormatMontant);

                affichage.Clear();
                affichage.AddRange(Factures);
                dtgrdParametre.ItemsSource = null;
                dtgrdParametre.ItemsSource = affichage;
                */
                AdministrationServiceClient client = new AdministrationServiceClient(Utility.ProtocoleFacturation(), Utility.EndPoint("Administration"));
                client.SelectSoldeFactureCompleted += (ssender, args) =>
                {
                    prgBar.Visibility = System.Windows.Visibility.Collapsed;

                    if (args.Cancelled || args.Error != null)
                    {
                        string error = args.Error.Message;
                        Message.ShowError(error, "Liste règlements");
                        return;
                    }
                    if (args.Result == null || args.Result.Count == 0)
                    {
                        Message.ShowError("Aucune donnée correspondante dans le système", "Liste règlements");
                        return;
                    }
                    affichage = args.Result;
                    dtgrdParametre.ItemsSource = null;
                    dtgrdParametre.ItemsSource = affichage;

                    if (affichage.Count != affichage.FirstOrDefault().IDLOT)
                    {
                        Message.ShowWarning("Le nombre de ligne annonné dans le recapitulatif est différent du nombre réel de ligne du fichier.", "Liste règlements");
                        return;
                    }


                    if (affichage.Sum(a => a.MONTANT) != affichage.FirstOrDefault().MONTANTEXIGIBLE)
                    {
                        Message.ShowWarning("Le montant total des règlements annonné dans le recapitulatif est différent de la somme des règlements du fichier.", "Liste règlements");
                        return;
                    }

                    this.txtNombre.Text = affichage.FirstOrDefault().IDLOT.ToString();
                    this.txtMontant.Text = affichage.FirstOrDefault().MONTANTEXIGIBLE.Value.ToString(SessionObject.FormatMontant);

                    this.btnValider.IsEnabled = true;

                };
                //client.SelectSoldeFactureAsync(Factures);
                client.SelectSoldeFactureAsync(SessionObject.LePosteCourant.NOMPOSTE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        int totalFactureAnnonce = 0;
        decimal? totalMontantAnnonce = null;

        private List<CsLclient> LireFichierReglement()
        {
            System.IO.FileStream monFichier = null;
            System.IO.StreamReader entrée = null;

            try
            {
                List<CsLclient> reglements = new List<CsLclient>();

                // Create an instance of the open file dialog box.
                var openDialog = new OpenFileDialog();
                // Set filter options and filter index.
                openDialog.Filter =
                    "Image files (*.csv) | *.csv";
                openDialog.FilterIndex = 1;
                openDialog.Multiselect = false;
                // Call the ShowDialog method to show the dialog box.
                bool? userClickedOk = openDialog.ShowDialog();
                // Process input if the user clicked OK.
                if (userClickedOk == true)
                {

                    if (openDialog.Files != null && openDialog.Files.Count() > 0)
                    {
                        System.IO.FileInfo file = ((System.IO.FileInfo[])(openDialog.Files))[0];

                        string readText = System.IO.File.ReadAllText(file.FullName);


                        string ligneCourante;
                        string[] tableauString;
                        monFichier = new System.IO.FileStream(file.FullName, System.IO.FileMode.Open);
                        entrée = new System.IO.StreamReader(monFichier);



                        CsLclient reg = null;

                        while (!entrée.EndOfStream)
                        {

                            ligneCourante = entrée.ReadLine();

                            if (ligneCourante.StartsWith("3"))
                            {
                                string[] recap = ligneCourante.Split(';');
                                this.totalFactureAnnonce = int.Parse(recap[3]);
                                this.totalMontantAnnonce = decimal.Parse(recap[4]);
                            }

                            if (!ligneCourante.StartsWith("2"))
                                continue;

                            reg = new CsLclient();
                            tableauString = ligneCourante.Split(';');

                            reg.NDOC = tableauString[1];

                            if (tableauString[2].Length != 13)
                                throw new Exception("La référence client n'a pas la taille requise.");

                            reg.CENTRE = tableauString[2].Substring(0, 3);
                            reg.CLIENT = tableauString[2].Substring(0, 11);
                            reg.ORDRE = tableauString[2].Substring(11, 2);

                            if (tableauString[3] != null)
                            {
                                string date = tableauString[3];

                                if (date.Length == 8)
                                    reg.DENR = DateTime.Parse(date.Substring(0, 2) + "/" + date.Substring(2, 2) + "/" + date.Substring(4, 4));
                                if (date.Length == 6)
                                    reg.DENR = DateTime.Parse(date.Substring(0, 2) + "/" + date.Substring(2, 2) + "/20" + date.Substring(4, 2));
                            }
                            reg.MONTANT = decimal.Parse(tableauString[4]);

                            if (!string.IsNullOrEmpty(tableauString[7]))
                            {
                                string[] acquit = tableauString[7].Split('-');
                                if (!string.IsNullOrEmpty(acquit[1]))
                                    reg.ACQUIT = int.Parse(acquit[1]).ToString("000000000");
                            }

                            if (tableauString[8] != null)
                                reg.REFEM = tableauString[8];

                            reglements.Add(reg);
                        }

                        monFichier.Close();
                        monFichier.Dispose();
                        entrée.Close();
                        entrée.Dispose();
                    }
                }

                return reglements.Count > 0 ? reglements : null;

            }
            catch (Exception ex)
            {
                monFichier.Close();
                monFichier.Dispose();
                entrée.Close();
                entrée.Dispose();

                throw ex;
            }
        }


        private void btnValider_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (affichage.FirstOrDefault(a => a.SOLDEFACTURE > 0) == null)
                {
                    var messageBox = new MessageBoxControl.MessageBoxChildWindow("Attention", "Confirmez-vous que ce fichier n'est pas déjà intégré?", MessageBoxControl.MessageBoxButtons.YesNo, MessageBoxControl.MessageBoxIcon.Question);
                    messageBox.OnMessageBoxClosed += (_, result) =>
                    {
                        if (messageBox.Result == MessageBoxResult.OK)
                        {

                            prgBar.Visibility = System.Windows.Visibility.Visible;

                            affichage.ForEach(a => a.MATRICULE = UserConnecte.matricule);

                            AdministrationServiceClient client = new AdministrationServiceClient(Utility.ProtocoleFacturation(), Utility.EndPoint("Administration"));
                            client.InsererPaiementMobileCompleted += (ssender, args) =>
                            {
                                prgBar.Visibility = System.Windows.Visibility.Collapsed;

                                if (args.Cancelled || args.Error != null)
                                {
                                    string error = args.Error.Message;
                                    Message.ShowError(error, "Liste règlements");
                                    return;
                                }
                                if (!args.Result)
                                {
                                    Message.ShowWarning("Echec de mise à jour", "Liste règlements");
                                    return;
                                }

                                Message.ShowInformation("Mise à jour effectuée avec succès", "Liste règlements");
                                this.DialogResult = true;

                            };
                            client.InsererPaiementMobileAsync(affichage);
                        }
                        else
                        {
                            Message.ShowError("Veuillez vérifier la date du fichier", "Liste règlements");
                            return;
                        }
                    };
                    messageBox.Show();
                }
                else
                {

                    prgBar.Visibility = System.Windows.Visibility.Visible;

                    affichage.ForEach(a => a.MATRICULE = UserConnecte.matricule);

                    AdministrationServiceClient client = new AdministrationServiceClient(Utility.ProtocoleFacturation(), Utility.EndPoint("Administration"));
                    client.InsererPaiementMobileCompleted += (ssender, args) =>
                    {
                        prgBar.Visibility = System.Windows.Visibility.Collapsed;

                        if (args.Cancelled || args.Error != null)
                        {
                            string error = args.Error.Message;
                            Message.ShowError(error, "Liste règlements");
                            return;
                        }
                        if (!args.Result)
                        {
                            Message.ShowWarning("Echec de mise à jour", "Liste règlements");
                            return;
                        }

                        Message.ShowInformation("Mise à jour effectuée avec succès", "Liste règlements");
                        this.DialogResult = true;

                    };
                    client.InsererPaiementMobileAsync(affichage);

                }
            }
            catch (Exception ex)
            {
                Message.Show(ex.Message, "Liste des règlements");
            }
        }


        private void dtgrdParametre_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                SessionObject.objectSelected = dtgrdParametre.SelectedItem as CsLclient;
                SessionObject.gridUtilisateur = dtgrdParametre;
            }
            catch (Exception ex)
            {
                Message.ShowError(ex.Message, "Liste des règlements");
            }
        }

        private void dtgrdParametre_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                SessionObject.objectSelected = dtgrdParametre.SelectedItem as CsLclient;
                SessionObject.gridUtilisateur = dtgrdParametre;
            }
            catch (Exception ex)
            {
                Message.ShowError(ex.Message, "Liste des règlements");
            }
        }

        private void btnFermer_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }


        private void dgMyDataGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            try
            {
                var dmdRow = e.Row.DataContext as CsLclient;
                if (dmdRow != null)
                {
                    if (dmdRow.MONTANT > dmdRow.SOLDEFACTURE)
                    {
                        SolidColorBrush SolidColorBrush = new SolidColorBrush(Colors.Red);
                        e.Row.Foreground = SolidColorBrush;
                    }
                    else
                    {
                        SolidColorBrush SolidColorBrush = new SolidColorBrush(Colors.Black);
                        e.Row.Foreground = SolidColorBrush;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



    }
}

