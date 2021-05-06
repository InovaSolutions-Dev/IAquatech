using Galatee.DataAccess;
using Galatee.Structure;
using Galatee.WorkflowManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfService.Workflow
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Workflow" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Workflow.svc or Workflow.svc.cs at the Solution Explorer and start debugging.
    public class Workflow : IWorkflow
    {
        //public string InsererMaDemande(int centreId, Guid workflowId, Guid OpId, string IDVotreLigne, string MatriculeUser,
        //                               string CodeDeVotreDemande)
        //{
        //    string _CodeDemande = string.Empty;
        //    bool _result = true;
        //    try
        //    {
        //        //On obtient les valeurs des paramètres
        //        string pk_IDLine = IDVotreLigne;
        //        int cId = centreId;
        //        Guid _wkfId = workflowId;
        //        Guid _opId = OpId;
        //        string _matUser = MatriculeUser;
        //        string _codeDemandeTravail = CodeDeVotreDemande;

        //        //On recherche les infos sur le circuit 
        //        CsRWorkflow rWKFCentre = null;
        //        rWKFCentre = new DB_WORKFLOW().SelectAllRWorkflowCentre(_wkfId, cId, _opId)
        //            .FirstOrDefault();
        //        if (null != rWKFCentre)
        //        {
        //            //Récupération des infos
        //            CsCentre centre = new DB_Centre().SelectAllCentre().Where(c => c.PK_ID == cId).FirstOrDefault();
        //            CsWorkflow workflow = new DB_WORKFLOW().SelectAllWorkflows().Where(w => w.PK_ID == _wkfId)
        //                .FirstOrDefault();
        //            CsOperation operation = new DB_WORKFLOW().SelectAllOperation2().Where(o => o.PK_ID == _opId)
        //                .FirstOrDefault();

        //            //Récupération du circuit
        //            Dictionary<CsRAffectationEtapeWorkflow, CsConditionBranchement> lsRAffCircuit = new Dictionary<CsRAffectationEtapeWorkflow, CsConditionBranchement>();
        //            lsRAffCircuit = new DB_WORKFLOW().SelectAllAffectationEtapeWorkflow(rWKFCentre.PK_ID);

        //            List<CsRAffectationEtapeWorkflow> leCircuitNormal = lsRAffCircuit.Keys.Where(aff => !aff.FK_IDRETAPEWORKFLOWORIGINE.HasValue ||
        //                aff.FK_IDRETAPEWORKFLOWORIGINE.Value == Guid.Empty)
        //                .OrderBy(aff => aff.ORDRE)
        //                .ToList();

        //            CsRAffectationEtapeWorkflow _1sStep = leCircuitNormal.FirstOrDefault();
        //            CsRAffectationEtapeWorkflow _2ndStep = leCircuitNormal.Where(step => step.ORDRE == _1sStep.ORDRE + 1)
        //                .FirstOrDefault();
        //            if (!string.IsNullOrEmpty(_1sStep.CONDITION))
        //            {

        //                string msgErr = string.Empty;
        //                CsConditionBranchement laContion = new CsConditionBranchement();
        //                foreach (var item in lsRAffCircuit)
        //                {
        //                    if (item.Key.PK_ID == _1sStep.PK_ID)
        //                    {
        //                        laContion = item.Value;
        //                        break;
        //                    }
        //                }

        //                //On utilise la condition pour transmettre
        //                bool onABienTeste = true;
        //                CsDemandeBase dmds = new DBAccueil().GetDemandeByNumIdDemande(int.Parse(IDVotreLigne));
        //                bool conditionRespecte = ConditionChecker.CheckIfConditionIsRespected<CsDemandeBase>(laContion.NOM, dmds,
        //                    ref msgErr, ref onABienTeste);
        //                if (onABienTeste)
        //                {
        //                    if (laContion.FK_IDETAPEVRAIE.HasValue && laContion.FK_IDETAPEFAUSE.HasValue)
        //                    {

        //                    }
        //                    else if (conditionRespecte && laContion.FK_IDETAPEVRAIE.HasValue && 0 != laContion.FK_IDETAPEVRAIE.Value)
        //                    {
        //                        CsRAffectationEtapeWorkflow leEtape = leCircuitNormal.FirstOrDefault(t => t.FK_IDETAPE == laContion.FK_IDETAPEVRAIE);
        //                        if (null == leEtape)
        //                            msgErr = "ERR : Aucune étape n'a été configurée avec cette ID";
        //                        else
        //                        {
        //                            _1sStep.FK_IDETAPE = leEtape.FK_IDETAPE;
        //                            CsRAffectationEtapeWorkflow EtapeSuiv = leCircuitNormal.FirstOrDefault(t => t.ORDRE == leEtape.ORDRE + 1);
        //                            _2ndStep.FK_IDETAPE = EtapeSuiv == null ? 0 : EtapeSuiv.FK_IDETAPE;
        //                        }
        //                    }
        //                }
        //            }
        //            //Création de la demande

        //            CsDemandeWorkflow dmd = new CsDemandeWorkflow();

        //            dmd.PK_ID = Guid.NewGuid();
        //            dmd.DATECREATION = DateTime.Today.Date;
        //            dmd.MATRICULEUSERCREATION = _matUser;
        //            dmd.ALLCENTRE = false;
        //            dmd.FK_IDCENTRE = cId;
        //            dmd.FK_IDOPERATION = _opId;
        //            dmd.FK_IDRWORKLOW = rWKFCentre.PK_ID;
        //            dmd.FK_IDSTATUS = (int)STATUSDEMANDE.Initiee;
        //            dmd.FK_IDWORKFLOW = _wkfId;
        //            dmd.FK_IDLIGNETABLETRAVAIL = pk_IDLine;
        //            dmd.FK_IDETAPEPRECEDENTE = 0;
        //            dmd.FK_IDETAPEACTUELLE = _1sStep.FK_IDETAPE;
        //            dmd.FK_IDETAPESUIVANTE = null != _2ndStep ? _2ndStep.FK_IDETAPE : 0;
        //            dmd.CODE = centre.CODESITE + centre.CODE + DateTime.Today.Year + DateTime.Today.Month +
        //                    DateTime.Now.Minute +
        //                    DateTime.Now.Millisecond;
        //            dmd.FK_IDTABLETRAVAIL = workflow.FK_IDTABLE_TRAVAIL.Value;
        //            dmd.CODE_DEMANDE_TABLETRAVAIL = _codeDemandeTravail;
        //            dmd.DATEDERNIEREMODIFICATION = DateTime.Today.Date;


        //            _result = new DB_WORKFLOW().InsertDemande(new List<CsDemandeWorkflow>() { dmd });

        //            if (_result) /* tout es bon */
        //            {
        //                _CodeDemande = dmd.CODE;

        //                //On récupère les emails pour notifier les utilisateurs de l'arrivée de la demande
        //                KeyValuePair<CsGroupeValidation, List<CsRHabilitationGrouveValidation>> grpValidation = new DB_WORKFLOW().SelectAllGroupeValidation()
        //                    .Where(g => g.Key.PK_ID == _1sStep.FK_IDGROUPEVALIDATIOIN)
        //                    .FirstOrDefault();

        //                #region Pour la gestion des mails
        //                //if (null != grpValidation.Key)
        //                //{
        //                //    if (string.Empty != grpValidation.Key.EMAILDIFFUSION)
        //                //        Emails.Set(context, grpValidation.Key.EMAILDIFFUSION + ";");
        //                //    else
        //                //    {
        //                //        string _email = string.Empty;
        //                //        foreach (var habilUser in grpValidation.Value) _email += habilUser.EMAIL + ";";

        //                //        Emails.Set(context, _email);
        //                //    }
        //                //}
        //                #endregion

        //                #region Création de la copie

        //                _result = new DB_WORKFLOW().CopieCicruitEtapeDemande(rWKFCentre.PK_ID, dmd.PK_ID, _CodeDemande);
        //                if (!_result) _CodeDemande = "Une erreur s'est produite";

        //                #endregion
        //            }
        //        }
        //        else
        //        {
        //            _result = false;

        //            _CodeDemande = "Aucun circuit n'a été configuré pour cette opération et ce centre";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _result = false;
        //        _CodeDemande = ex.Message;
        //    }

        //    if (!_result) _CodeDemande = "ERR : " + _CodeDemande;

        //    return _CodeDemande;
        //}

        public string InsererMaDemande(int centreId, Guid workflowId, Guid OpId, string IDVotreLigne, string MatriculeUser,
                               string CodeDeVotreDemande)
        {
            string _CodeDemande = string.Empty;
            bool _result = true;
            try
            {
                return new DbWorkFlow().InsererMaDemande(centreId, workflowId, OpId, IDVotreLigne, MatriculeUser, CodeDeVotreDemande); 
            }
            catch (Exception ex)
            {
                _result = false;
                _CodeDemande = ex.Message;
            }

            if (!_result) _CodeDemande = "ERR : " + _CodeDemande;

            return _CodeDemande;
        }

        public string InsererMaDemandeToGroupeValidation(int centreId, Guid workflowId, Guid OpId, Guid IdGroupeValidation, string IDVotreLigne, string MatriculeUser,
    string CodeDeVotreDemande)
        {
            string _CodeDemande = string.Empty;
            bool _result = true;
            try
            {
                return new DbWorkFlow().InsererMaDemandeToGroupeValidation(centreId, workflowId, OpId, IdGroupeValidation, IDVotreLigne, MatriculeUser, CodeDeVotreDemande); 
            }
            catch (Exception ex)
            {
                _result = false;
                _CodeDemande = ex.Message;
            }

            if (!_result) _CodeDemande = "ERR : " + _CodeDemande;

            return _CodeDemande;
        }

 
         
        public string ExecuterActionSurDemande(string CodeDemande, int CodeAction, string MatriculeUser, string Commentaire)
        {
            return new DbWorkFlow().ExecuterActionSurDemande(CodeDemande, CodeAction, MatriculeUser, Commentaire); 

        }
        public string AllerALEtape(string CodeDemande, int CodeAction, Guid EtapeId, string MatriculeUser, string Commentaire)
        {
            Galatee.DataAccess.RESULTACTION _result = Galatee.DataAccess.RESULTACTION.ERREURINCONNUE;
            string Reponse = string.Empty;

            try
            {
                return new DbWorkFlow().AllerALEtape(CodeDemande, CodeAction, EtapeId,MatriculeUser, Commentaire); 
            }
            catch (Exception ex)
            {
                _result = Galatee.DataAccess.RESULTACTION.ERREURINCONNUE;
                Reponse = "ERR : " + ex.Message;
            }

            return Reponse;
        }


        public string ExecuterActionSurPlusieursDemandes(List<string> CodesDemandes, int CodeAction, string MatriculeUser, string Commentaire)
        {
            return new DbWorkFlow().ExecuterActionSurPlusieursDemandes(CodesDemandes, CodeAction, MatriculeUser, Commentaire); 
        }

        public string ExecuterActionSurDemandeParPkIDLigne(List<int> pkIds, int FkidEtapeActuelle, int CodeAction, string MatriculeUser, string Commentaire)
        {
            return new DbWorkFlow().ExecuterActionSurDemandeParPkIDLigne(pkIds, FkidEtapeActuelle, CodeAction, MatriculeUser, Commentaire); 
        }

        public bool VerifierConditionDemande(string codeDemande, int FKIDTableTravail, string PKIDLigne)
        {
            try
            {
                //Récupération des infos de la table de travail
                return new DbWorkFlow().VerifierConditionDemande(codeDemande, FKIDTableTravail, PKIDLigne); 
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public CsInfoDemandeWorkflow RecupererInfoDemandeParOperationId(string codeDemande, Guid Operation)
        {
            try
            {
                return new DbWorkFlow().RecupererInfoDemandeParOperationId(codeDemande, Operation); 
                 
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public CsInfoDemandeWorkflow RecupererInfoDemandeParCodeTDem(CsDemandeBase laDemande)
        {
            try
            {
                //On sélection l'opération
                return new DB_WORKFLOW().RecupererInfoDemandeParCodeTDem(laDemande);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void  NotificationMail(List<string > lstDestinataire, string CodeTypeMail)
        {
            CsParametreSMTP leServerMail = new DB_NOTIFICATION().SelectAllSMTP().FirstOrDefault();
            CsNotificaton  leMAil = new DB_NOTIFICATION().SelectNotificationByTypeMail(CodeTypeMail).FirstOrDefault();
            if (leServerMail != null && leMAil != null )
            {
                leMAil.SERVEURSMTP = leServerMail.PASSWORD;
                leMAil.PASSWORD  = leServerMail.SERVEURSMTP;
                leMAil.PORT = leServerMail.PORT;
                leMAil.SSL = leServerMail.SSL;
                leMAil.LOGIN = leServerMail.LOGIN;
                //Galatee.Tools.Utility.EnvoiMail(leMAil.SERVEURSMTP, leMAil.LOGIN, leMAil.PORT, leMAil.PASSWORD, leMAil.OBJET, leMAil.MESSAGE, leMAil.SSL.Value, lstDestinataire);
            }
        }
        public void NotificationMailDemande(List<string> lstDestinataire, string NumeroDemande, string TypeDemande, string CodeTypeMail)
        {
            try
            {
                foreach (var item in lstDestinataire)
                    ErrorManager.WriteInLogFile(this, item); 
  
                 new DbWorkFlow().NotificationMailDemande(lstDestinataire, NumeroDemande, TypeDemande, CodeTypeMail);
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
            }
        }
    }
}
