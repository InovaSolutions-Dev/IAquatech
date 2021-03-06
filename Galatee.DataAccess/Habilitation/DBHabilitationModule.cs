using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Collections;
using Inova.Tools.Utilities;
//
using Galatee.Structure  ;
using System.Globalization;


namespace Galatee.DataAccess
{
    public class DBHabilitationModule
    {
        public DBHabilitationModule()
        {
            try
            {
               // ConnectionString = Session.GetSqlConnexionString();
            }
            catch (Exception )
            {
                
                //;
            }
        }
        private string ConnectionString;
        private SqlCommand cmd = null;
        private SqlConnection cn = null;



        public List<CsHabilitationProgram> SelectHabilitationByUser(int Iduser)
        {
            try
            {
                DataTable obj = Galatee.Entity.Model.AuthentProcedures.SelectHabilitationByUser(Iduser);
                List<CsHabilitationProgram> l = Tools.Utility.GetEntityFromQuery<CsHabilitationProgram>(obj).ToList();
                return l;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public CsProgram SelectById(int id)
        {
            CsProgram line = new CsProgram();

            SqlConnection cn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spx_Program_SelectById";

            SqlParameter param0 = cmd.Parameters.Add(new SqlParameter("@Id", id));
            param0.Direction = ParameterDirection.Input;

            try
            {

                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    reader.Close();

                    return null;
                }
                while (reader.Read())
                {
                    if (reader.GetValue(0).ToString().Trim() != string.Empty)
                        line.Id = int.Parse(reader.GetValue(0).ToString().Trim());
                    if (reader.GetValue(1).ToString().Trim() != string.Empty)
                        line.IdGroupProgram = reader.GetValue(1).ToString().Trim();
                    line.Code = reader.GetValue(2).ToString().Trim();
                    line.Libelle = reader.GetValue(3).ToString().Trim();
                }
                //Fermeture reader
                reader.Close();
                return line;
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                return null;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close(); // Fermeture de la connection 
                cmd.Dispose();
            }
        }
        public CsGroupProgram GroupSelectById(int id)
        {
            CsGroupProgram line = new CsGroupProgram();

            SqlConnection cn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spx_GroupProgram_SelectById";

            SqlParameter param0 = cmd.Parameters.Add(new SqlParameter("@Id", id));
            param0.Direction = ParameterDirection.Input;

            try
            {

                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    reader.Close();

                    return null;
                }
                while (reader.Read())
                {
                    if (reader.GetValue(0).ToString().Trim() != string.Empty)
                        line.Id = reader.GetValue(0).ToString().Trim();
                    line.Libelle = reader.GetValue(1).ToString().Trim();
                }
                //Fermeture reader
                reader.Close();
                return line;
            }
            catch (Exception ex)
            {
                string error =  ex.Message;
                return null;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close(); // Fermeture de la connection 
                cmd.Dispose();
            }
        }
    }
  }


