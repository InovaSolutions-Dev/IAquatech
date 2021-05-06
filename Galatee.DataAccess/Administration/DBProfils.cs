using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Galatee.Structure;
using System.Transactions;
using Galatee.Entity.Model;

namespace Galatee.DataAccess
{
    public class DBProfils : Galatee.DataAccess.Parametrage.DbBase
    {


        public DBProfils()
        {
        }
        /// </summary>
        private string ConnectionString;
        private SqlConnection cn = null;
        /// <summary>
        /// _Transaction
        /// </summary>
        private bool _Transaction;
        /// <summary>
        /// Transaction
        /// </summary>
        public bool Transaction
        {
            get { return _Transaction; }
            set { _Transaction = value; }

        }

        public List<CsProfil> GetAll()
        {
            try
            {
                
                DataTable objet = Galatee.Entity.Model.AdminProcedures.RetourneListeToutProfilUtilisateur();
                return Galatee.Tools.Utility.GetEntityFromQuery<CsProfil>(objet).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<CsProfil> GetProfilByFonction(string fonction)
        {
            try
            {

                DataTable objet = Galatee.Entity.Model.AdminProcedures.RetourneProfilByFonction( fonction);
                return Galatee.Tools.Utility.GetEntityFromQuery<CsProfil>(objet).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CsProfil> RetourneProfilByID(int fonction)
        {
            try
            {

                DataTable objet = Galatee.Entity.Model.AdminProcedures.RetourneProfilByID( fonction);
                return Galatee.Tools.Utility.GetEntityFromQuery<CsProfil>(objet).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool saveProfilHabilitation(CsProfil csProfil, List<CsHabilitationProgram> menuProfil)
        {
            try
            {
                PROFIL _profil = new PROFIL()
                {
                    FK_IDFONCTION = csProfil.FK_IDFONCTION,
                    LIBELLE = csProfil.LIBELLE,
                    CODE = csProfil.CODE,
                    PK_ID = csProfil.PK_ID 
                };
                // modification
                if (_profil.PK_ID != 0)
                {
                    // suprimer ancien
                    DeleteMenuDuProfilByIdProfil(_profil.PK_ID);
                    if (_profil.MENUSDUPROFIL == null || _profil.MENUSDUPROFIL.Count == 0)
                    {
                        //créer nouveau

                        foreach (var item in menuProfil)
                        {
                            MENUSDUPROFIL _menuProfil = new MENUSDUPROFIL()
                            {
                                FK_IDPROFIL = _profil.PK_ID,
                                FK_IDMENU = item.FK_IDMENU == null ? 0 : item.FK_IDMENU.Value,
                                //DATEDEBUTVALIDITE = DateTime.Now
                                //DATEFINVALIDITE
                            };
                            _profil.MENUSDUPROFIL.Add(_menuProfil);
                        }

                        //_profil.MENUSDUPROFIL.ToList().ForEach(t => t.FK_IDPROFIL = _profil.PK_ID);
                        Entities.InsertEntity<MENUSDUPROFIL>(_profil.MENUSDUPROFIL.ToList());
                        _profil.MENUSDUPROFIL = null;
                    }

                    return Entities.UpdateEntity<PROFIL>(_profil);

                }
                else
                {
                    // création

                    foreach (var item in menuProfil)
                    {
                        MENUSDUPROFIL _menuProfil = new MENUSDUPROFIL()
                        {
                            FK_IDPROFIL = _profil.PK_ID,
                            FK_IDMENU = item.FK_IDMENU == null ? 0 : item.FK_IDMENU.Value,
                            //DATEDEBUTVALIDITE = DateTime.Now
                            //DATEFINVALIDITE
                        };

                        _profil.MENUSDUPROFIL.Add(_menuProfil);

                    }

                    return Entities.InsertEntity<PROFIL>(_profil);

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void DeleteMenuDuProfilByIdProfil(int idprofil)
        {
            //SqlCommand cmd = new SqlCommand("spx_AdmStrategieSecurite_Delete", cn);
            try
            {
                List<Galatee.Entity.Model.MENUSDUPROFIL> lst_entity = new List<MENUSDUPROFIL>();

                using (Galatee.Entity.Model.galadbEntities context = new galadbEntities())
                {
                    lst_entity = context.MENUSDUPROFIL.Where(pk => pk.FK_IDPROFIL == idprofil).ToList();
                }

                foreach (var entity in lst_entity)
                {
                    if (entity.PK_ID != 0)
                    {
                        Entities.DeleteEntity<Galatee.Entity.Model.MENUSDUPROFIL>(entity);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<CsProfil> GetAllProfilUser()
        {
            try
            {
                DataTable dt = AdminProcedures.RetourneListeToutProfilUtilisateur();
                return Entities.GetEntityListFromQuery<CsProfil>(dt);
                }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Insert(CsProfil admProfilUsers)
        {
            try
            {

                Galatee.Entity.Model.PROFILSUTILISATEUR admProfilUser = Galatee.Tools.Utility.ConvertEntity<Galatee.Entity.Model.PROFILSUTILISATEUR, CsProfil>(admProfilUsers);
                using (galadbEntities context = new galadbEntities())
                {
                    return Entities.InsertEntity<PROFILSUTILISATEUR>(admProfilUser);

                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool InsertionProfilFonction(List<CsProfil> admProfilUsers)
        {
          
                try
                    {

                        List<Galatee.Entity.Model.PROFIL> dt = Entities.ConvertObject<Galatee.Entity.Model.PROFIL, CsProfil>(admProfilUsers);
                        return Galatee.Entity.Model.AdminProcedures.InsertionProfilFonction(dt);
                   }  
                  catch (Exception ex)
                    {
                        throw ex;
                    }
        
        }

        private SqlCommand cmd = null;
    }
}
