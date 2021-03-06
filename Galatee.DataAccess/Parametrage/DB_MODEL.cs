using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Galatee.Structure;
using Galatee.Entity.Model;

namespace Galatee.DataAccess
{
    public static  class DB_MODEL  
    {


        public static List<CsMarque_Modele> SelectAllModel()
        {
            try
            {
                return Entities.GetEntityListFromQuery<CsMarque_Modele>(ParamProcedure.PARAM_MODELE_RETOURNE());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool Delete(CsMarque_Modele pMarqueModel)
        {
            try
            {
                return Entities.DeleteEntity<Galatee.Entity.Model.MODELE>(Entities.ConvertObject<Galatee.Entity.Model.MODELE, CsMarque_Modele>(pMarqueModel));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool Delete(List<CsMarque_Modele> pMarqueModel)
        {
            try
            {
                return Entities.DeleteEntity<Galatee.Entity.Model.MODELE>(Entities.ConvertObject<Galatee.Entity.Model.MODELE, CsMarque_Modele>(pMarqueModel));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool Update(CsMarque_Modele pMarqueModel)
        {
            try
            {
                return Entities.UpdateEntity<Galatee.Entity.Model.MODELE>(Entities.ConvertObject<Galatee.Entity.Model.MODELE, CsMarque_Modele>(pMarqueModel));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool Update(List<CsMarque_Modele> pTMarqueModelCollection)
        {
            try
            {
                return Entities.UpdateEntity<Galatee.Entity.Model.MODELE>(Entities.ConvertObject<Galatee.Entity.Model.MODELE, CsMarque_Modele>(pTMarqueModelCollection));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool Insert(CsMarque_Modele pTcompt)
        {
            try
            {
                return Entities.InsertEntity<Galatee.Entity.Model.MODELE>(Entities.ConvertObject<Galatee.Entity.Model.MODELE, CsMarque_Modele>(pTcompt));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool Insert(List<CsMarque_Modele> pTcomptCollection)
        {
            try
            {
                return Entities.InsertEntity<Galatee.Entity.Model.MODELE>(Entities.ConvertObject<Galatee.Entity.Model.MODELE, CsMarque_Modele>(pTcomptCollection));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
