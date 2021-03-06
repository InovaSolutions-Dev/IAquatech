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
using Galatee.Silverlight.Library;
using Galatee.Silverlight.ServiceParametrage;
using Galatee.Silverlight.Resources.Parametrage;
namespace Galatee.Silverlight.Parametrage
{
    public partial class UcTypeMessage : ChildWindow
    {
       List<CsTypeMessage> listForInsertOrUpdate = null;
       ObservableCollection<CsTypeMessage> donnesDatagrid = new ObservableCollection<CsTypeMessage>();
        private CsTypeMessage ObjetSelectionnee = null;
        private Object ModeExecution = null;
        private DataGrid dataGrid = null;

        public UcTypeMessage()
        {
            try
            {
                InitializeComponent();
                Translate();
            }
            catch (Exception ex)
            {
                Message.ShowError(ex.Message, Languages.TypeMessage);
            }
        }
        public UcTypeMessage(object pObjects, SessionObject.ExecMode pExecMode, DataGrid pGrid)
        {
            try
            {
                InitializeComponent();
                Translate();
                var categorieClient = new CsTypeMessage();
                if (pObjects != null)
                    ObjetSelectionnee = Utility.ParseObject(categorieClient, pObjects as CsTypeMessage);
                ModeExecution = pExecMode;
                dataGrid = pGrid;
                if (dataGrid != null) donnesDatagrid = dataGrid.ItemsSource as ObservableCollection<CsTypeMessage>;
                if ((SessionObject.ExecMode)ModeExecution == SessionObject.ExecMode.Modification || (SessionObject.ExecMode)ModeExecution == SessionObject.ExecMode.Consultation)
                {
                    if (ObjetSelectionnee != null)
                    {
                        Txt_Code.Text = ObjetSelectionnee.IDTYPEMESSAGE;
                        Txt_Libelle.Text = ObjetSelectionnee.LIBELLE;
                        btnOk.IsEnabled = false;

                        //Txt_Code.IsReadOnly = true;
                    }
                }
                if ((SessionObject.ExecMode)ModeExecution == SessionObject.ExecMode.Consultation)
                {
                    AllInOne.ActivateControlsFromXaml(LayoutRoot,false);
                }
                VerifierSaisie();
            }
            catch (Exception ex)
            {
                Message.ShowError(ex.Message, Languages.TypeMessage);
            }
        }

        private void UpdateParentList(CsTypeMessage pTypeMessage)
        {
            try
            {
                if ((SessionObject.ExecMode)ModeExecution == SessionObject.ExecMode.Creation)
                {
                    donnesDatagrid.Add(pTypeMessage);
                }
                if ((SessionObject.ExecMode)ModeExecution == SessionObject.ExecMode.Modification)
                {
                    var TypeMessage = donnesDatagrid.First(p => p.PK_ID == pTypeMessage.PK_ID);
                    donnesDatagrid.Remove(TypeMessage);
                    donnesDatagrid.Add(pTypeMessage);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Translate()
        {
            try
            {
                Title = Languages.TypeMessage;
                btnOk.Content = Languages.OK;
                Btn_Annuler.Content = Languages.Annuler;
                lab_Code.Content = Languages.Code;
                lab_Libelle.Content = Languages.Libelle;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private List<CsTypeMessage> GetInformationsFromScreen()
        {
            var listObjetForInsertOrUpdate = new List<CsTypeMessage>();
            try
            {
                if ((SessionObject.ExecMode)ModeExecution == SessionObject.ExecMode.Creation)
                {
                    var TypeMessage = new CsTypeMessage
                    {
                        IDTYPEMESSAGE= Txt_Code.Text,
                        LIBELLE = Txt_Libelle.Text,
                        DATECREATION = DateTime.Now,
                        USERCREATION = UserConnecte.matricule
                    };
                    if (!string.IsNullOrEmpty(Txt_Code.Text) && donnesDatagrid.FirstOrDefault(p => p.IDTYPEMESSAGE == TypeMessage.IDTYPEMESSAGE) != null)
                    {
                        throw new Exception(Languages.CetElementExisteDeja);
                    }
                    listObjetForInsertOrUpdate.Add(TypeMessage);
                }
                if ((SessionObject.ExecMode)ModeExecution == SessionObject.ExecMode.Modification)
                {
                    ObjetSelectionnee.IDTYPEMESSAGE = Txt_Code.Text;
                    ObjetSelectionnee.LIBELLE = Txt_Libelle.Text;
                    ObjetSelectionnee.DATEMODIFICATION = DateTime.Now;
                    ObjetSelectionnee.USERMODIFICATION = UserConnecte.matricule;
                    listObjetForInsertOrUpdate.Add(ObjetSelectionnee);
                }
                return listObjetForInsertOrUpdate;
            }
            catch (Exception ex)
            {
                Message.ShowError(ex.Message, Languages.TypeMessage);
                return null;
            }
        }

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var messageBox = new MessageBoxControl.MessageBoxChildWindow(Languages.TypeMessage, Languages.QuestionEnregistrerDonnees, MessageBoxControl.MessageBoxButtons.YesNo, MessageBoxControl.MessageBoxIcon.Question);
                messageBox.OnMessageBoxClosed += (_, result) =>
                {
                    if (messageBox.Result == MessageBoxResult.OK)
                    {
                        listForInsertOrUpdate = GetInformationsFromScreen();
                        var service = new ParametrageClient(Utility.ProtocoleFacturation(), Utility.EndPoint("Parametrage"));

                        if (listForInsertOrUpdate != null && listForInsertOrUpdate.Count > 0)
                        {
                            if ((SessionObject.ExecMode)ModeExecution == SessionObject.ExecMode.Creation)
                            {
                                service.InsertTypeMessageCompleted += (snder, insertR) =>
                                {
                                    if (insertR.Cancelled ||
                                        insertR.Error != null)
                                    {
                                        Message.ShowError(insertR.Error.Message, Languages.TypeMessage);
                                        return;
                                    }
                                    if (!insertR.Result)
                                    {
                                        Message.ShowError(Languages.ErreurInsertionDonnees, Languages.TypeMessage);
                                        return;
                                    }
                                    DialogResult = true;
                                };
                                service.InsertTypeMessageAsync(listForInsertOrUpdate);
                            }
                            if ((SessionObject.ExecMode)ModeExecution == SessionObject.ExecMode.Modification)
                            {
                                service.UpdateTypeMessageCompleted += (snder, UpdateR) =>
                                {
                                    if (UpdateR.Cancelled ||
                                        UpdateR.Error != null)
                                    {
                                        Message.ShowError(UpdateR.Error.Message, Languages.TypeMessage);
                                        return;
                                    }
                                    if (!UpdateR.Result)
                                    {
                                        Message.ShowError(Languages.ErreurMiseAJourDonnees, Languages.TypeMessage);
                                        return;
                                    }
                                    DialogResult = true;
                                };
                                service.UpdateTypeMessageAsync(listForInsertOrUpdate);
                            }
                        }
                    }
                    else
                    {
                        return;
                    }
                };
                messageBox.Show();
            }
            catch (Exception ex)
            {
                Message.ShowError(ex.Message, Languages.TypeMessage);

            }
        }
        
        private void VerifierSaisie()
        {
            try
            {
                if (!string.IsNullOrEmpty(Txt_Code.Text) && !string.IsNullOrEmpty(Txt_Libelle.Text) && (SessionObject.ExecMode)ModeExecution != SessionObject.ExecMode.Consultation)
                    btnOk.IsEnabled = true;
                else
                {
                    btnOk.IsEnabled = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Btn_Annuler_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Reinitialiser();
                DialogResult = false;
            }
            catch (Exception ex)
            {
                Message.ShowError(ex.Message, Languages.TypeMessage);

            }
        }

        private void Reinitialiser()
        {
            try
            {
                Txt_Code.Text = string.Empty;
                Txt_Libelle.Text = string.Empty;
                btnOk.IsEnabled = false;
                Txt_Code.Focus();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void On_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                VerifierSaisie();
            }
            catch (Exception ex)
            {
                Message.ShowError(ex.Message, Languages.TypeMessage);

            }
        }
    }
}


