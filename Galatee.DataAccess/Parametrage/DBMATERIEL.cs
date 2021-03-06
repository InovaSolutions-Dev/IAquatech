
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Galatee.Structure;
using System.ComponentModel;
using Galatee.Entity.Model;

namespace Galatee.DataAccess
{
    [DataObject]
    public static class DBMATERIEL
    {

        public static bool Delete(CsMaterielDemande entity)
        {
            try
            {
                return Entities.DeleteEntity<Galatee.Entity.Model.MATERIELDEVIS>(Entities.ConvertObject<Galatee.Entity.Model.MATERIELDEVIS, CsMaterielDemande>(entity));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<CsMaterielDemande> GetAll()
        {
            try
            {
                return Entities.GetEntityListFromQuery<CsMaterielDemande>(ParamProcedure.PARAM_MATERIEL_RETOURNE ());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<ObjELEMENTDEVIS> GetAllMaterielOnFourniture()
        {
            try
            {
                return Entities.GetEntityListFromQuery<ObjELEMENTDEVIS>(ParamProcedure.PARAM_MATERIEL_RETOURNE());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static CsMaterielDemande GetById(CsMaterielDemande entity)
        {
            try
            {
                return Entities.GetEntityFromQuery<CsMaterielDemande>(ParamProcedure.PARAM_MATERIEL_RETOURNEById(entity.PK_ID));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool Insert(List<CsMaterielDemande> pEntityCollection)
        {
            try
            {
                return Entities.InsertEntity<Galatee.Entity.Model.MATERIELDEVIS>(Entities.ConvertObject<Galatee.Entity.Model.MATERIELDEVIS, CsMaterielDemande>(pEntityCollection));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static bool Update(List<CsMaterielDemande> pEntityCollection)
        {
            try
            {
                return Entities.UpdateEntity<Galatee.Entity.Model.MATERIELDEVIS>(Entities.ConvertObject<Galatee.Entity.Model.MATERIELDEVIS, CsMaterielDemande>(pEntityCollection));
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
} 


