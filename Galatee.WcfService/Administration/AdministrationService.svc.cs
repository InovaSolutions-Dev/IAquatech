using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Galatee.Structure;
using Galatee.DataAccess;
using System.ServiceModel.Activation;
using System.Configuration;
using System.Data.SqlClient;
using System.Web;

namespace WcfService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "AdministrationService" à la fois dans le code, le fichier svc et le fichier de configuration.
   [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)] 
    public class AdministrationService : IAdministrationService
    {
       
       public bool saveProfilHabilitation(CsProfil csProfil, List<CsHabilitationProgram> menuProfil)
       {
           try
           {
               return new DBProfils().saveProfilHabilitation( csProfil, menuProfil);
           }
           catch (Exception zw)
           {
               ErrorManager.WriteInLogFile(this, zw.Message);
               return false;
           }
       }

       public List<CsCentreDuProfil> RetourneCentreDuProfil()
        {
           try
           {
               return new List<CsCentreDuProfil>() ;
           }
           catch (Exception zw)
           {
               ErrorManager.WriteInLogFile(this, zw.Message);
               return null;
           }
       }

       public List<CsModuleAdmMenu> RetourneCsModuleAdmMenu()
       {
           try
           {
               return new List<CsModuleAdmMenu>() ;///dd
           }
           catch (Exception zw)
           {
               ErrorManager.WriteInLogFile(this, zw.Message);
               return null;
           }
       }


       public List<CsProfil> RetourneListeAllProfilUser()
       {
           try
           {
               List<CsProfil> _profils =new DBProfils().GetAll() ;
              /* List<CsFonction> _functions = new DBFonction().SelectAllFonction();

               // convert function to profil liste

               foreach (var item in _functions)
               {
                   _profils.Add(new CsProfil() { 
                   
                    FK_IDFONCTION = item.PK_ID,
                    LIBELLE = item.ROLENAME,
                    PK_ID = item.PK_ID,
                    CODE = item.CODE
                   });
               }*/

               return _profils;

           }
           catch (Exception zw)
           {
               ErrorManager.WriteInLogFile(this, zw.Message);
               return null;
           }
       }


       public List<CsProfil> RetourneProfilByFonction( string fonction)
       {
           try
           {
               return new DBProfils().GetProfilByFonction(fonction);
           }
           catch (Exception zw)
           {
               ErrorManager.WriteInLogFile(this, zw.Message);
               return null;
           }
       }


       public List<CsProfil> RetourneProfilByID(int idprofil)
       {
           try
           {
               return new DBProfils().RetourneProfilByID(idprofil);
           }
           catch (Exception zw)
           {
               ErrorManager.WriteInLogFile(this, zw.Message);
               return null;
           }
       }


        public List<CsUtilisateur> RetourneListeAllUser()
        {
            try
            {
                ErrorManager.WriteInLogFile (this, "ok");
                return new DBAdmUsers().GetAll();
            }
            catch (Exception zw )
            {
                ErrorManager.WriteInLogFile(this, zw.Message);
                return null;
            }
        }
        public List<CsUtilisateur> RetourneListeAllUserPerimetre(List<int> lstCentrePerimetreAction)
        {
            try
            {
                return new DBAdmUsers().GetAllPerimetre(lstCentrePerimetreAction);
            }
            catch (Exception zw)
            {
                ErrorManager.WriteInLogFile(this, zw.Message);
                return null;
            }
        }

        public CsUtilisateur GetByLoginName(string LoginName)
        {
            try
            {
                return new DBAuthentification().GetByLoginName(LoginName);
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return null;
            }
        }

        public CsUtilisateur VerifieUserExist(string LoginName)
        {
            try
            {
                return new DBAuthentification().VerifieUserExist(LoginName);
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return null;
            }
        }

        public bool UpdateUser(CsUtilisateur admUsers, bool IsInitpassword)
        {
            try
            {
                return new DBAdmUsers().Update(admUsers, IsInitpassword);
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return false;
            }
        }


  
        public CParametre RetourneTa(string centre, int num, string code)
        {
            try
            {
                //List<CParametre> _Lstparam = new DBAccueil().ChargerTableDeReference(num, code, centre);
                //return _Lstparam[0];
                return null;
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return null;
            }
        }

        public List<CsUtilisateur> InsertUser(CsUtilisateur admUsers)
        {
            try
            {
                new DBAdmUsers().Insert(admUsers);
                return this.RetourneListeAllUser();
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return null;
            }
        }

         
        public List<CsUtilisateur> saveUserProfil(CsUtilisateur csUser, List<CsProfil> lesProfils)
        {
            try
            {
                new DBAdmUsers().saveUserProfil(csUser, lesProfils);
                return this.RetourneListeAllUser();
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return null;
            }
        }

        public List<CsUtilisateur> saveUserProfilCentre(CsUtilisateur csUser)
        {
            try
            {
                new DBAdmUsers().saveUserProfilCentre(csUser);
                return this.RetourneListeAllUser();
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return null;
            }
        }
    

        public bool? DeleteUser(CsUtilisateur user)
        {
            try
            {
                return new DBAdmUsers().Delete(user);
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return null;
            }
        }

        public bool DeleteUserByGuid(Guid guid)
        {
            try
            {
                return new DBAdmUsers().Delete(guid);
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return false;
            }
        }


        public List<CsCentre> RetourneListeDesCentre()
        {
            try
            {
                return new CommonDAL().GetCentre();
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return null;
            }
        }

        public List<CsProgramMenu> RetourneAllModuleProgram()
        {
            try
            {
                return new DBUserHabilitation().RetourneAllModuleProgram();
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return null;
            }
        }

        public List<CsModule> RetourneAllModuleFonction()
        {
            try
            {
                return new DBUserHabilitation().RetourneAllModuleFonction();
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return null;
            }
        }



        public List<CsAdmRoles> GetAllRole()
        {
            try
            {
                return null;// new DBAdmRoles().GetAll();
                //return new DBAdmRoles().GetAll();
            }
            catch (Exception ex)
            {
                string eror = ex.Message;
                return null;
            }
        }



        public List<CsAdmRoles> GetAssocitedToMenuByMenuID(int menuId)
        {
            try
            {
                return new DBAdmRoles().GetAssocitedToMenuByMenuID(menuId);
            }
            catch (Exception ex)
            {
                string eror = ex.Message;
                return null;
            }
        }

        public List<CsSite> GetAllSite()
        {
            try
            {
                return new DBAdmRoles().GetAllSite();
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return null;
            }
        }


        public List<CsFonction> SELECT_All_Fonction()
        {
            try
            {
                return new DBUserHabilitation().SELECT_All_Fonction();
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return null;
            }
        }


    

        public List<CsAdmMenu> MenusSelectByFonction(int metier)
        {
            try
            {
                List<CsAdmMenu> habliMetier = new List<CsAdmMenu>();
                habliMetier.AddRange(new DBUserHabilitation().MenusSelectByFonction(metier));
                return habliMetier;
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return null;
            }
        }

       

        public List<CsModule> HabilitationSelectByMetierModule(string metier)
        {
            try
            {
                List<CsModule> habliMetier = new List<CsModule>();
                habliMetier.AddRange(new DBUserHabilitation().HabilitationSelectByMetierModule(metier));
                return habliMetier;
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return null;
            }
        }

        public List<CsHabilitationProgram> ProgramSelectAll()
        {
            try
            {
                return new DBUserHabilitation().ProgramSelectAll();
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return null;
            }
        }
       
        public bool InsertionModuleDeFonction(List<CsModuleDeFonction> modules)
        {
            try
            {
                return new DBModuleDeFonction().InsertionModuleDeFonction( modules);
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return false;
            }
        }

        public bool InsertionHabilitationProfil(List<CsProfil> modules)
        {
            try
            {
                return new DBHabilitationProfil().InsertionHabilitationProfil(modules);
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return false;
            }
        }


        public bool InsertionProfilFonction(List<CsProfil> modules)
        {
            try
            {
                return new DBProfils().InsertionProfilFonction(modules);
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return false;
            }
        }

        public bool UpdateStrategieSecurite(CsStrategieSecurite admStrategieSecurite)
        {
            try
            {
                new DBSecurity().Update(admStrategieSecurite);
                return true;
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return false;
            }
        }

        public List<CsStrategieSecurite> InsertStrategieSecurite(CsStrategieSecurite admStrategieSecurite)
        {
            try
            {
                new DBSecurity().Insert(admStrategieSecurite);
                return new DBSecurity().GetAll();
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return null;
            }
        }

        public bool DeleteStrategieSecurite(Guid IdStrategieSecurite)
        {
            try
            {
                new DBSecurity().Delete(IdStrategieSecurite);
                return true;
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return false;
            }
        }

        public List<CsStrategieSecurite> SetActifStrategieSecurite(Guid IdStrategieSecurite)
        {
            try
            {
                new DBSecurity().SetActif(IdStrategieSecurite);
                return new DBSecurity().GetAll();
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return null;
            }
        }

        public CsStrategieSecurite GetActifStrategieSecurite()
        {
            try
            {
                return new DBSecurity().GetActif();
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return null;
            }
        }


        public List<CsModuleDeFonction> RetourneAllModuleDeFonction()
        {
            try
            {
                return null ;// new DBSecurity().GetAll();
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return null;
            }
        }

        public List<CsStrategieSecurite> GetAllStrategieSecurite()
        {
            try
            {
                return new DBSecurity().GetAll();
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return null;
            }
        }

        public List<CsDataBase> RetourneBdConfig()
        {
            try
            {
                List<CsDataBase> dbs = new List<CsDataBase>();

                CsDataBase abo07 = new CsDataBase();
                var connexion = ConfigurationManager.ConnectionStrings["abo07ConnectionString"].ConnectionString;
                SqlConnection sqlConnection = new SqlConnection(connexion);
                abo07.Catalog = sqlConnection.Database;
                abo07.ServerName = sqlConnection.DataSource;

                CsDataBase galadb = new CsDataBase();
                connexion = ConfigurationManager.ConnectionStrings["galadbConnectionString"].ConnectionString;
                sqlConnection = new SqlConnection(connexion);
                galadb.Catalog = sqlConnection.Database;
                galadb.ServerName = sqlConnection.DataSource;

                dbs.Add(abo07); dbs.Add(galadb);
                return dbs;

            }
            catch (Exception ex)
            {
               ErrorManager.LogException(this, ex);
                return null;
            }
        }

        public List<CsPoste> RetourneListePoste()
        {
            try
            {
                var obj=new DBAdmUsers().RetourneListePoste();
                return obj;
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return null;
            }
        }

        public bool InsertPoste(CsPoste lePoste)
        {
            try
            {
                return new DBAdmUsers().InsertPoste(lePoste);
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return false;

            }
        }
    
        public List<CsPoste> UpdatePoste(CsPoste lePoste)
        {
            try
            {
                if (new DBAdmUsers().UpdatePoste(lePoste))
                    return RetourneListePoste();
                else return null;
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return null;

            }
        }
        public List<CsHistoriquePassword> RetourneHistoriquePassword(int idUser)
        {
            try
            {
                List<CsHistoriquePassword> lst = new DBAdmUsers().RetourneHistoriquePassword(idUser);
                lst.ForEach(t => t.DATECREATION = Convert.ToDateTime(t.DATECREATION));
                return lst ;

               
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return null ;

            }
        
        }
        public List<CsHistoriquePassword> RetourneHistoriqueConnection(int idUser)
        {
            try
            {
                return  new DBAdmUsers().RetourneHistoriqueConnection(idUser);
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return null  ;

            }

        }
        public bool  SynchroniseDonneeAD()
        {
            try
            {
                return new DBAdmUsers().SynchroniseDonneesAD();
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return false ;

            }
        }
        public List<CsAgent> ChargeListeDesAgents()
        {
            try
            {
                return new DBAdmUsers().ChargeListeDesAgents();
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return null ;

            }
        }

        public List<CsUtilisateur> InsertUpdateUser(CsUtilisateur admUsers, List<CsProfil> anciensProfils)
        {
            try
            {
                new DBAdmUsers().InsertUpdateUser(admUsers);
                return this.RetourneListeAllUser();
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return null;
            }
        }
        public List<CsHabilitationMenu> RetourneProfilUtilisateur(List<int> idUtilisateur)
        {
            try
            {
               return  new DBUserHabilitation().RetourneProfilUtilisateur(idUtilisateur);
            }
            catch (Exception zw)
            {
                ErrorManager.WriteInLogFile(this, zw.Message);
                return null;
            }
        }
        //FIFO
        public List<CsHabilitationMetier> RetourneFonctionProfilCentre(string codefonction)
        {
            try
            {
                return new DBUserHabilitation().RetourneFonctionProfilCentre(codefonction);
            }
            catch (Exception zw)
            {
                ErrorManager.WriteInLogFile(this, zw.Message);
                return null;
            }
        }

        public List<CsHabilitationMenu> RetourneFonctionProfilMenu(string codefonction)
        {
            try
            {
                return new DBUserHabilitation().RetourneFonctionProfilMenu(codefonction);
            }
            catch (Exception zw)
            {
                ErrorManager.WriteInLogFile(this, zw.Message);
                return null;
            }
        }

        //

        //FIFO
        public bool InsertionMutation(Galatee.Structure.CsUtilisateur lutilisateur, string newCentre, DateTime datedebut, DateTime? datefin)
        {
            try
            {
                return new DBAdmUsers().InsertionMutation(lutilisateur, newCentre, datedebut, datefin);
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return false;
            }
        }
        //



        #region Module Fonction

        public List<CsModule> GetListeDesModule()
        {
            List<CsModule> resultat = new List<CsModule>();
            return new DBModule().GetAllModuleFonction();
            //return resultat;
        }
        public List<CsModule> GetListeDesModuleDesFonctions()
        {
            List<CsModule> resultat = new List<CsModule>();
            return new DBModule().GetAllModuleFonction();
            //return resultat;
        }
        #endregion

        public List<CsAdmMenu> GetListeDesMenusProfil()
        {
            List<CsAdmMenu> resultat = new List<CsAdmMenu>();
            return new DBAdmMenu().GetAllModuleFonction();
            //return resultat;
        }



        #region SynchroDataBase

        public List<CsAgent> LoadAgentBaseDistante(string Requette, string Provider, string DataSource, string IniialeCatalog, string UserId, string Password)
        {
            try
            {
                return new DBAdmUserSynchroBD().LoadAgentBaseDistantez(Requette, Provider, DataSource, IniialeCatalog, UserId, Password);
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return null;

            }
        }
        public bool TestBaseDistante(string Requette, string Provider, string DataSource, string IniialeCatalog, string UserId, string Password)
        {
            try
            {
                return new DBAdmUserSynchroBD().TestBaseDistante(Requette, Provider, DataSource, IniialeCatalog, UserId, Password);
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return false;

            }
        }

        public string LoadRequest()
        {
            try
            {
                return new DBAdmUserSynchroBD().LoadRequest();
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return null;

            }
        }
        public bool SaveAgent(List<CsAgent> agenttosynchro, string Requette)
        {
            try
            {
                return new DBAdmUserSynchroBD().SaveAgent(agenttosynchro, Requette);
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return false;

            }
        }

        public List<string> GetProviderList()
        {
            try
            {
                return new DBAdmUserSynchroBD().GetProviderList();
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return null;

            }
        }
        public List<string> GetSQLDatabaseList(string serverInstanceName, bool useWindowsAuthentication, string username, string password)
        {
            try
            {
                return new DBAdmUserSynchroBD().GetSQLDatabaseList(serverInstanceName, useWindowsAuthentication, username, password);
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return null;

            }
        }

        public bool  ImportDepuisBaseDeDonnee(aImportFichier limport)
        {
            List<string> ListAgent = new DBAdmUserSynchroBD().LoadAgentBaseDistante(limport.REQUTETTEBASEDISTANTE, limport.PROVIDER, limport.SERVER, limport.BASEDEDONNE, limport.UTILISATEUR, limport.MOTDEPASSE);
            new DbImportFichier().InsertDonneeImport(limport, new List<string>(), new List<string>(), ListAgent);
            return true;
        }
        #endregion

        #region Synchro Fichier
        public List<aImportFichier> GetAllImport()
        {
            List<aImportFichier> result = null;
            try
            {
                result = new DbImportFichier().RetourneAllImportFichier();

            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
            }
            return result;
        }
        public int MisaAjourImportFichier(aImportFichier limport)
        {
            try
            {
                return new DbImportFichier().MAJImportFichier(limport);
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return 0;

            }
        }
        public bool SuppressImportFichier(aImportFichier limport)
        {
            try
            {
                return new DbImportFichier().DeleteImport(limport.CODE);
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return false;

            }
        }




        //public List<CsLclient> GenererFichierImpayes(int idSite, int idCentre)
        public bool GenererFichierImpayes(int idSite, int idCentre, string nomposte)
        {
            try
            {
                bool retour = false;

                List<CsLclient> impayes = new DBAccueil().GetImpayes(idSite, idCentre);

                if (impayes != null && impayes.Count > 0)
                    retour = CreerFichier(impayes, nomposte);

                return retour;
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return false;
            }
        }



        private bool CreerFichier(List<CsLclient> Liste, string nomposte)
        {
            try
            {
                // Set the path and filename variable "path", filename being MyTest.csv in this example.
                // Change SomeGuy for your username.
                string date = DateTime.Now.Day.ToString("00") + DateTime.Now.Month.ToString("00") + DateTime.Now.Year.ToString("0000");
                string file = @"IMPAYES" + DateTime.Now.Year.ToString("0000") + DateTime.Now.Month.ToString("00") + DateTime.Now.Day.ToString("00") + ".csv";
                //string path = SessionObject.CheminImpression.Replace('[', '\\') + file;
                string path = @"C:\Impression\Interface\" + file;

                if (!string.IsNullOrEmpty(nomposte))
                    path = @"\\" + nomposte + "\\Impression\\Interface\\" + file;

                // Set the variable "delimiter" to ", ".
                string delimiter = ";";

                // This text is added only once to the file.
                if (System.IO.File.Exists(path))
                    return false;

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
                ErrorManager.LogException(this, ex);
                return false;
            }
        }


        //public List<CsLclient> SelectSoldeFacture(List<CsLclient> Factures)
        public List<CsLclient> SelectSoldeFacture(string nomposte)
        {
            try
            {
                List<CsLclient> Factures = LireFichierReglement(nomposte);
                return new DBAccueil().SoldeFactures(Factures);
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return null;

            }
        }



        private List<CsLclient> LireFichierReglement(string nomposte)
        {
            System.IO.FileStream monFichier = null;
            System.IO.StreamReader entrée = null;

            int nombreFacture = 0;
            decimal montantTotal = 0;

            try
            {
                List<CsLclient> reglements = new List<CsLclient>();
                string path = @"\\" + nomposte + "\\Impression\\Interface\\reglements.csv";
                System.IO.FileInfo file = new System.IO.FileInfo(path);

                if (file != null && !string.IsNullOrEmpty(file.FullName))
                {
                    string readText = System.IO.File.ReadAllText(file.FullName);


                    string ligneCourante;
                    string[] tableauString;
                    monFichier = new System.IO.FileStream(file.FullName, System.IO.FileMode.Open);
                    entrée = new System.IO.StreamReader(monFichier);



                    CsLclient reg = null;

                    while (!entrée.EndOfStream)
                    {

                        ligneCourante = entrée.ReadLine();

                        reg = new CsLclient();

                        if (ligneCourante.StartsWith("3"))
                        {
                            string[] recap = ligneCourante.Split(';');
                            nombreFacture = int.Parse(recap[3]);
                            montantTotal = decimal.Parse(recap[4]);
                        }

                        if (!ligneCourante.StartsWith("2"))
                            continue;

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

                if (reglements != null && reglements.Count > 0)
                {
                    reglements.ForEach(a => a.IDLOT = nombreFacture);
                    reglements.ForEach(a => a.MONTANTEXIGIBLE = montantTotal);
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



        public bool InsererPaiementMobile(List<CsLclient> Factures)
        {
            try
            {
                return new DBAccueil().InsererPaiementsMobile(Factures);
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return false;

            }
        }





        public aImportFichier GetImportFichier(int codeimport)
        {
            aImportFichier result = null;
            try
            {
                result = new DbImportFichier().RetourneImportFichier(codeimport);
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);

            }
            return result;
        }
        public List<string> ExexcImporterFichier(aImportFichier codeimport)
        {
            try
            {
                return  new DbImportFichier().ImporterFichier(codeimport.CODE);
                //if (result == null)
                    //Galatee.Tools.Utility.EcrireFichier(codeimport.LIBELLE + ": Erreur de paramétrage de" + codeimport.LIBELLE, new DB_ParametresGeneraux().SelectParametresGenerauxByCode("000406").LIBELLE + @"\Log_Import_Du_" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + ".txt");

                //return result;
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return null;
            }
        }


        public bool MisaAjourImportColonne(aImportFichierColonne lacolonne)
        {
            try
            {
                return new DbImportFichier().MAJImportFichierColonne(lacolonne);
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return false;

            }
        }
        public aImportFichierColonne GetImportColonne(int codeColonne)
        {
            aImportFichierColonne result = null;
            try
            {
                result = new DbImportFichier().RetourneImportFichierColonne(codeColonne);

            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
            }
            return result;
        }
        public bool DeleteColonne(int codeColonne)
        {
            try
            {
                return new DbImportFichier().DeleteImportColonne(codeColonne);

            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return false;

            }

        }
        public List<aImportFichierColonne> GetAllImportFichierColonne(int codeimport)
        {
            List<aImportFichierColonne> result = null;
            try
            {
                result = new DbImportFichier().RetourneAllImportColonne(codeimport);
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);

            }
            return result;
        }
        public List<CsAdmMenu> MenusSelectByProfil(int metier)
        {
            try
            {
                List<CsAdmMenu> habliMetier = new List<CsAdmMenu>();
                habliMetier.AddRange(new DBUserHabilitation().MenusSelectByProfil(metier));
                return habliMetier;
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return null;
            }
        }
        #endregion

        public List<CsHistoriquePassword> RetourneHistoriquePasswords(int idUser)
        {
            try
            {
                List<CsHistoriquePassword> lst = new DBAdmUsers().RetourneHistoriquePassword(idUser);
                lst.ForEach(t => t.DATECREATION = Convert.ToDateTime(t.DATECREATION));

                return lst;
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return null;

            }

        }
        public bool? DeleteListUser(List<CsUtilisateur> user)
        {
            try
            {
               return new DBAdmUsers().DeleteList(user);
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return null;
            }
        }
        public List<CsHistoriquePassword> RetourneHistoriquePasswordFromListUser(List<int?> idUser)
        {
            try
            {
                List<CsHistoriquePassword> lst = new DBAdmUsers().RetourneHistoriquePasswordFromListUser(idUser);
                lst.ForEach(t => t.DATECREATION = Convert.ToDateTime(t.DATECREATION));
                return lst;
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return null;

            }

        }
        public List<CsHistoriquePassword> RetourneHistoriqueConnectionfromListUser(List<int?> idUser)
        {
            try
            {
                return  new DBAdmUsers().RetourneHistoriqueConnectionFromListUser(idUser);
            }
            catch (Exception ex)
            {
                ErrorManager.LogException(this, ex);
                return null ;
            }
        }
    }
}
