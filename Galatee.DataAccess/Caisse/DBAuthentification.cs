using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Collections;
using Inova.Tools.Utilities;
using Galatee.Structure  ;
using System.Globalization;
//using System.Data.Objects;
using Galatee.Entity;
using Galatee.Entity.Model;

namespace Galatee.DataAccess
{
    public class DBAuthentification
    {
        public DBAuthentification()
        {
            ConnectionString = Session.GetSqlConnexionString();
        }
        private string ConnectionString;
        private SqlCommand cmd = null;
        private SqlConnection cn = null;
        #region 07/06/2016 SYLLA
        public void TraceDeConnection(int IdUser, string Post)
        {
            try
            {
                Galatee.Entity.Model.AuthentProcedures.TraceDeConnection(IdUser, Post);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        public CsUserConnecte RetourneInfoMatriculeConnecte(string pLogin)
        {
            try
            {
                CsUserConnecte c = new CsUserConnecte();
                DataTable query = Galatee.Entity.Model.AdminProcedures.RetourneInfoUtilisateurConnecte(pLogin);
                c = Tools.Utility.GetEntityFromQuery<CsUserConnecte>(query).FirstOrDefault();
                return c;
            }
            catch (Exception ex)
            {
               throw ex;
            }
        }

        //public CsUtilisateur GetByLoginName(string pLogin)
        //{

        //    try
        //    {
        //        CsUtilisateur c = new CsUtilisateur();
        //        DataTable query = Galatee.Entity.Model.AuthentProcedures.GetUserByLoginName(pLogin);
        //        c = Tools.Utility.GetEntityFromQuery<CsUtilisateur>(query).FirstOrDefault();
        //        if (c != null && (c.PK_ID != 0))
        //        {
        //            DataTable query1 = Galatee.Entity.Model.AuthentProcedures.GetProfilUserByLoginName(c.PK_ID);
        //            c.LESPROFILSUTILISATEUR = Tools.Utility.GetEntityListFromQuery<CsProfil>(query1);
        //            List<CsProfil> lstProfil = Tools.Utility.GetEntityListFromQuery<CsProfil>(query1);
        //            c.LESPROFILSUTILISATEUR = lstProfil.Where(t => (Convert.ToDateTime(t.DATEDEBUT.Value.ToShortDateString()) > System.DateTime.Today) && (t.DATEFIN == null || Convert.ToDateTime(t.DATEFIN.Value.ToShortDateString()) < System.DateTime.Today)).ToList();
        //            foreach (CsProfil item in c.LESPROFILSUTILISATEUR)
        //            {
        //                DataTable query2 = Galatee.Entity.Model.AuthentProcedures.GetCentreDesProfilsUserByLoginName(c.PK_ID, item.FK_IDPROFIL);
        //                item.LESCENTRESPROFIL = Tools.Utility.GetEntityListFromQuery<CsCentreProfil>(query2);
        //            }
        //        }
        //        return c;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        public CsUtilisateur GetByLoginName(string pLogin)
        {

            try
            {
                CsUtilisateur c = new CsUtilisateur();
                DataTable query = Galatee.Entity.Model.AuthentProcedures.GetUserByLoginName(pLogin);
                c = Tools.Utility.GetEntityFromQuery<CsUtilisateur>(query).FirstOrDefault();
                if (c != null && (c.PK_ID != 0))
                {
                    List<CsProfil> leProfiles = GetProfilActifUser(c.PK_ID);
                    if (leProfiles != null && leProfiles.Count != 0)
                    {
                        c.LESPROFILSUTILISATEUR = leProfiles;
                        foreach (CsProfil item in c.LESPROFILSUTILISATEUR)
                            item.LESCENTRESPROFIL = GetCentreProfilActif(c.PK_ID,item.FK_IDPROFIL);
                    }
                }
                return c;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<CsProfil> GetProfilActifUser(int IdUtilisateur)
        {

            try
            {
                cn = new SqlConnection(ConnectionString);

                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandTimeout = 3000;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SPX_ADMIN_RETOUREPROFILUSER";
                cmd.Parameters.Add("@FK_IDADMUTILISATEUR", SqlDbType.Int).Value = IdUtilisateur;
                DBBase.SetDBNullParametre(cmd.Parameters);
                try
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    return Entities.GetEntityListFromQuery<CsProfil>(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception(cmd.CommandText + ":" + ex.Message);
                }
                finally
                {
                    if (cn.State == ConnectionState.Open)
                        cn.Close(); // Fermeture de la connection 
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CsCentreProfil> GetCentreProfilActif(int IdUtilidateur, int IdProfil)
        {

            try
            {
                cn = new SqlConnection(ConnectionString);

                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandTimeout = 3000;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SPX_ADMIN_RETOURECENTREPROFIL";
                cmd.Parameters.Add("@IDPROFIL", SqlDbType.Int).Value = IdProfil;
                cmd.Parameters.Add("@IDUTILISATEUR", SqlDbType.Int).Value = IdUtilidateur;
                DBBase.SetDBNullParametre(cmd.Parameters);
                try
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    return Entities.GetEntityListFromQuery<CsCentreProfil>(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception(cmd.CommandText + ":" + ex.Message);
                }
                finally
                {
                    if (cn.State == ConnectionState.Open)
                        cn.Close(); // Fermeture de la connection 
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<CsCentreProfil> GetAllCentreProfilActif(int IdUtilidateur)
        {

            try
            {
                cn = new SqlConnection(ConnectionString);

                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandTimeout = 3000;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SPX_ADMIN_RETOUREALLCENTREPROFIL";
                cmd.Parameters.Add("@IDUTILISATEUR", SqlDbType.Int).Value = IdUtilidateur;
                DBBase.SetDBNullParametre(cmd.Parameters);
                try
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    return Entities.GetEntityListFromQuery<CsCentreProfil>(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception(cmd.CommandText + ":" + ex.Message);
                }
                finally
                {
                    if (cn.State == ConnectionState.Open)
                        cn.Close(); // Fermeture de la connection 
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CsUtilisateur  VerifieUserExist(string matricule )
        {

            try
            {
                cn = new SqlConnection(ConnectionString);

                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandTimeout = 3000;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SPX_ADMIN_VERIFIEUTILISATEUR";
                cmd.Parameters.Add("@MATRICULE", SqlDbType.VarChar ,9).Value = matricule;
                DBBase.SetDBNullParametre(cmd.Parameters);
                try
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    return Entities.GetEntityFromQuery<CsUtilisateur>(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception(cmd.CommandText + ":" + ex.Message);
                }
                finally
                {
                    if (cn.State == ConnectionState.Open)
                        cn.Close(); // Fermeture de la connection 
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CsStrategieSecurite GetActif()
        {
            CsStrategieSecurite c = new CsStrategieSecurite();
            try
            {
                DataTable query = Galatee.Entity.Model.AuthentProcedures.AdmStrategieSecuriteActive();
                c = Tools.Utility.GetEntityFromQuery<CsStrategieSecurite>(query).FirstOrDefault();
                return c;
            }
            catch (Exception ex)
            {
                new ErrorManager().WriteInLogFile(this, ex.Message);
                throw ex;
            }
        }



        //public void TraceDeConnection(CsUtilisateur user)
        //{
        //    CsStrategieSecurite c = new CsStrategieSecurite();
        //    try
        //    {
        //        DataTable query = Galatee.Entity.Model.AuthentProcedures.AdmStrategieSecuriteActive();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
  }


