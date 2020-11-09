using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;

namespace DataLayer
{
    public class AnexoDL
    {
        public List<Anexo> GetAnexo()
        {
            try
            {
                using (dbConnection dbcontext = new dbConnection())
                {
                    return dbcontext.Anexo.ToList();
                }

            }
            catch (Exception ex)
            {
                string cadena = ex.Message;
            }
            return new List<Anexo>();
        }
        public List<Anexo> GetAnexoById(int idAnexo)
        {
            try
            {
                using (dbConnection dbcontext = new dbConnection())
                {
                    var query = (from n in dbcontext.Anexo
                                 where n.IdAnexo == idAnexo
                                 select n);

                    return query.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void InsertAnexo(Anexo objAnexo)
        {
            try
            {
                using (dbConnection dbcontext = new dbConnection())
                {
                    dbcontext.Anexo.Add(objAnexo);
                    dbcontext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void UpdateAnexo(Anexo objAnexo)
        {
            try
            {
                using (dbConnection dbcontext = new dbConnection())
                {
                    Anexo query = (from n in dbcontext.Anexo
                                   where n.IdAnexo == objAnexo.IdAnexo
                                   select n).SingleOrDefault();
                    if (query != objAnexo)
                    {
                        query.NomAnexo = objAnexo.NomAnexo;
                        query.EstadoAnexo = objAnexo.EstadoAnexo;
                    }
                    dbcontext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
