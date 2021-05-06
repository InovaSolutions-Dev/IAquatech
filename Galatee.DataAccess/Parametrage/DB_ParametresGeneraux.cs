using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Galatee.Structure;
using Galatee.Entity.Model;

namespace Galatee.DataAccess
{
    public class DB_ParametresGeneraux /*: Galatee.DataAccess.Parametrage.DbBase*/
    {
        /*
        private string ConnectionString;

        public DB_ParametresGeneraux()
        {
           try
            {
                ConnectionString = Session.GetSqlConnexionString();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public DB_ParametresGeneraux(string ConnStr)
        {
            ConnectionString = ConnStr;
        }

        private SqlConnection cn = null;

        private bool _Transaction;

        public bool Transaction
        {
            get { return _Transaction; }
            set { _Transaction = value; }

        }

        private SqlCommand cmd = null;

        public List<CsParametresGeneraux> SelectAllParametresGeneraux()
        {
            cn = new SqlConnection(ConnectionString);
            try
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                cmd = new SqlCommand
                          {
                              Connection = cn,
                              CommandType = CommandType.StoredProcedure,
                              CommandText = EnumProcedureStockee.SelectPARAMETRESGENRAUX
                          };
                IDataReader reader = cmd.ExecuteReader();
                var rows = new List<CsParametresGeneraux>();
                Fill(reader, rows, int.MinValue, int.MaxValue);
                reader.Close();
                return rows;
            }
            catch (Exception ex)
            {
                throw new Exception(EnumProcedureStockee.SelectPARAMETRESGENRAUX + ":" + ex.Message);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close(); // Fermeture de la connection 
                cmd.Dispose();
            }
        }

        public CsParametresGeneraux SelectParametresGenerauxByCode(string pCode)
        {
            cn = new SqlConnection(ConnectionString);
            try
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                cmd = new SqlCommand
                {
                    Connection = cn,
                    CommandType = CommandType.StoredProcedure,
                    CommandText = EnumProcedureStockee.SelectPARAMETRESGENRAUXByKey
                };
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CODE", pCode);
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                IDataReader reader = cmd.ExecuteReader();
                var rows = new List<CsParametresGeneraux>();
                Fill(reader, rows, int.MinValue, int.MaxValue);
                reader.Close();
                if (rows.Count == 1)
                {
                    return  rows[0];
                }
                else if (rows.Count == 0)
                {
                    return null;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(EnumProcedureStockee.SelectPARAMETRESGENRAUXByKey + ":" + ex.Message);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close(); // Fermeture de la connection 
                cmd.Dispose();
            }
        }

        public bool Delete(CsParametresGeneraux pParametresGeneraux)
        {
            try
            {
                cn = new SqlConnection(ConnectionString);
                cmd = new SqlCommand
                {
                    Connection = cn,
                    CommandType = CommandType.StoredProcedure,
                    CommandText = EnumProcedureStockee.DeletePARAMETRESGENRAUX
                };
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CODE", pParametresGeneraux.CODE);
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                StartTransaction(cn);
                int rowsAffected = cmd.ExecuteNonQuery();
                CommitTransaction(cmd.Transaction);
                return Convert.ToBoolean(rowsAffected);
            }
            catch (Exception ex)
            {
                RollBackTransaction(cmd.Transaction);
                throw new Exception(EnumProcedureStockee.DeletePARAMETRESGENRAUX + ":" + ex.Message);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                cn.Close();
                cmd.Dispose();
            }
        }

        public bool Delete(List<CsParametresGeneraux> pParametreGenerauxCollection)
        {
            int number = 0;
            foreach (CsParametresGeneraux entity in pParametreGenerauxCollection)
            {
                if (Delete(entity))
                {
                    number++;
                }
            }
            return number != 0;
        }

        public static List<CsParametresGeneraux> Fill(IDataReader reader, List<CsParametresGeneraux> rows, int start, int pageLength)
		{
			// advance to the starting row
			for (int i = 0; i < start; i++)
			{
				if (! reader.Read() )
					return rows; // not enough rows, just return
			}

			for (int i = 0; i < pageLength; i++)
			{
				if (!reader.Read())
					break; // we are done

                var c = new CsParametresGeneraux();
				c.CODE = (Convert.IsDBNull(reader["CODE"]))?string.Empty:(System.String)reader["CODE"];
				c.OriginalCODE = (Convert.IsDBNull(reader["CODE"]))?string.Empty:(System.String)reader["CODE"];
                c.LIBELLE = (Convert.IsDBNull(reader["LIBELLE"])) ? string.Empty : (System.String)reader["LIBELLE"];
                c.DESCRIPTION = (Convert.IsDBNull(reader["DESCRIPTION"])) ? null : (System.String)reader["DESCRIPTION"];
                c.USERCREATION = (Convert.IsDBNull(reader["USERCREATION"])) ? string.Empty : (System.String)reader["USERCREATION"];
                c.USERMODIFICATION = (Convert.IsDBNull(reader["USERMODIFICATION"])) ? string.Empty : (System.String)reader["USERMODIFICATION"];
                c.DATECREATION = (Convert.IsDBNull(reader["DATECREATION"])) ? (DateTime?)null : (System.DateTime)reader["DATECREATION"];
                c.DATEMODIFICATION = (Convert.IsDBNull(reader["DATEMODIFICATION"])) ? (DateTime?)null : (System.DateTime)reader["DATEMODIFICATION"];
				rows.Add(c);
			}
			return rows;
		}

        public bool Update(CsParametresGeneraux pParametresGeneraux)
        {
                cn = new SqlConnection(ConnectionString);
                cmd = new SqlCommand
                          {
                              Connection = cn,
                              CommandType = CommandType.StoredProcedure,
                              CommandText = EnumProcedureStockee.UpdatePARAMETRESGENRAUX
                          };
                cmd.Parameters.Clear();

                try
                {
                    cmd.Parameters.AddWithValue("@CODE", pParametresGeneraux.CODE);
                    cmd.Parameters.AddWithValue("@LIBELLE", pParametresGeneraux.LIBELLE);
                    cmd.Parameters.AddWithValue("@DESCRIPTION", pParametresGeneraux.DESCRIPTION);
                    cmd.Parameters.AddWithValue("@OriginalCODE", pParametresGeneraux.OriginalCODE);
                    cmd.Parameters.AddWithValue("@DATECREATION", pParametresGeneraux.DATECREATION);
                    cmd.Parameters.AddWithValue("@DATEMODIFICATION", pParametresGeneraux.DATEMODIFICATION);
                    cmd.Parameters.AddWithValue("@USERCREATION", pParametresGeneraux.USERCREATION);
                    cmd.Parameters.AddWithValue("@USERMODIFICATION", pParametresGeneraux.USERMODIFICATION);
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    StartTransaction(cn);
                    SetDBNullParametre(cmd.Parameters);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    CommitTransaction(cmd.Transaction);
                    return Convert.ToBoolean(rowsAffected);
                }
                catch (Exception ex)
                {
                    RollBackTransaction(cmd.Transaction);
                    throw ex;
                }
                finally
                {
                    if (cn.State == ConnectionState.Open)
                        cn.Close(); // Fermeture de la connection 
                    cmd.Dispose();
                }
        }

        public bool Update(List<CsParametresGeneraux> pParametreGenerauxCollection)
        {
            int number = 0;
            foreach (CsParametresGeneraux entity in pParametreGenerauxCollection)
            {
                if (Update(entity))
                {
                    number++;
                }
            }
            return number != 0;
        }

        public bool Insert(CsParametresGeneraux pParametresGeneraux)
        {
                cn = new SqlConnection(ConnectionString);
                cmd = new SqlCommand
                {
                    Connection = cn,
                    CommandType = CommandType.StoredProcedure,
                    CommandText = EnumProcedureStockee.InsertPARAMETRESGENRAUX
                };
                cmd.Parameters.Clear();

                try
                {
                    cmd.Parameters.AddWithValue("@CODE", pParametresGeneraux.CODE);
                    cmd.Parameters.AddWithValue("@LIBELLE", pParametresGeneraux.LIBELLE);
                    cmd.Parameters.AddWithValue("@DESCRIPTION", pParametresGeneraux.DESCRIPTION);
                    cmd.Parameters.AddWithValue("@DATECREATION", pParametresGeneraux.DATECREATION);
                    cmd.Parameters.AddWithValue("@DATEMODIFICATION", pParametresGeneraux.DATEMODIFICATION);
                    cmd.Parameters.AddWithValue("@USERCREATION", pParametresGeneraux.USERCREATION);
                    cmd.Parameters.AddWithValue("@USERMODIFICATION", pParametresGeneraux.USERMODIFICATION);
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    StartTransaction(cn);

                    SetDBNullParametre(cmd.Parameters);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    CommitTransaction(cmd.Transaction);
                    return Convert.ToBoolean(rowsAffected);
                }
                catch (Exception ex)
                {
                    RollBackTransaction(cmd.Transaction);
                    throw ex;
                }
                finally
                {
                    if (cn.State == ConnectionState.Open)
                        cn.Close(); // Fermeture de la connection 
                    cmd.Dispose();
                }
        }

        public bool Insert(List<CsParametresGeneraux> pParametreGenerauxCollection)
        {
            int number = 0;
            foreach (CsParametresGeneraux entity in pParametreGenerauxCollection)
            {
                if (Insert(entity))
                {
                    number++;
                }
            }
            return number != 0;
        }

        private void StartTransaction(SqlConnection _conn)
        {
            if ((_Transaction) && (_conn != null))
            {
                cmd.Transaction = this.BeginTransaction(_conn);
            }
        }

        private void CommitTransaction(SqlTransaction _pSqlTransaction)
        {
            if ((_Transaction) && (_pSqlTransaction != null))
            {
                this.Commit(_pSqlTransaction);
            }
        }

        private void RollBackTransaction(SqlTransaction _pSqlTransaction)
        {
            if ((_Transaction) && (_pSqlTransaction != null))
            {
                this.RollBack(_pSqlTransaction);
            }
        }

        */

        public List<CsParametresGeneraux> SelectAllParametresGeneraux()
        {
            try
            {
                //return Entities.GetEntityListFromQuery<CsParametresGeneraux>(ParamProcedure.PARAM_PARAMETRESGENERAUX_RETOURNE());
                DataTable obj = ParamProcedure.PARAM_PARAMETRESGENERAUX_RETOURNE();
                return Entities.GetEntityListFromQuery<CsParametresGeneraux>(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CsParametresGeneraux SelectParametresGenerauxByCode(string pCode)
        {
            try
            {
                return Entities.GetEntityFromQuery<CsParametresGeneraux>(ParamProcedure.PARAM_PARAMETRESGENERAUX_RETOURNEByCode(pCode));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CsParametresGeneraux SelectParametresGenerauxById(int pCode)
        {
            try
            {
                return Entities.GetEntityFromQuery<CsParametresGeneraux>(ParamProcedure.PARAM_PARAMETRESGENERAUX_RETOURNEById(pCode));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(CsParametresGeneraux pParametresGeneraux)
        {
            try
            {
                return Entities.DeleteEntity<Galatee.Entity.Model.PARAMETRESGENERAUX>(Entities.ConvertObject<Galatee.Entity.Model.PARAMETRESGENERAUX, CsParametresGeneraux>(pParametresGeneraux));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(List<CsParametresGeneraux> pParametreGenerauxCollection)
        {
            try
            {
                return Entities.DeleteEntity<Galatee.Entity.Model.PARAMETRESGENERAUX>(Entities.ConvertObject<Galatee.Entity.Model.PARAMETRESGENERAUX, CsParametresGeneraux>(pParametreGenerauxCollection));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(CsParametresGeneraux pParametresGeneraux)
        {
            try
            {
                return Entities.UpdateEntity<Galatee.Entity.Model.PARAMETRESGENERAUX>(Entities.ConvertObject<Galatee.Entity.Model.PARAMETRESGENERAUX, CsParametresGeneraux>(pParametresGeneraux));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(List<CsParametresGeneraux> pParametreGenerauxCollection)
        {
            try
            {
                return Entities.UpdateEntity<Galatee.Entity.Model.PARAMETRESGENERAUX>(Entities.ConvertObject<Galatee.Entity.Model.PARAMETRESGENERAUX, CsParametresGeneraux>(pParametreGenerauxCollection));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Insert(CsParametresGeneraux pParametresGeneraux)
        {
            try
            {
                return Entities.InsertEntity<Galatee.Entity.Model.PARAMETRESGENERAUX>(Entities.ConvertObject<Galatee.Entity.Model.PARAMETRESGENERAUX, CsParametresGeneraux>(pParametresGeneraux));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Insert(List<CsParametresGeneraux> pParametreGenerauxCollection)
        {
            try
            {
                return Entities.InsertEntity<Galatee.Entity.Model.PARAMETRESGENERAUX>(Entities.ConvertObject<Galatee.Entity.Model.PARAMETRESGENERAUX, CsParametresGeneraux>(pParametreGenerauxCollection));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
