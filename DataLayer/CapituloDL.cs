using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;

namespace DataLayer
{
    public class CapituloDL
    {
        public List<Capitulo> GetCapitulo()
        {
            try
            {
                using (dbConnection dbcontext = new dbConnection())
                {
                    return dbcontext.Capitulo.ToList();
                }

            }
            catch (Exception ex)
            {
                string cadena = ex.Message;
            }
            return new List<Capitulo>();
        }
        public List<Capitulo> GetCapituloById(int idCapitulo)
        {
            try
            {
                using (dbConnection dbcontext = new dbConnection())
                {
                    var query = (from n in dbcontext.Capitulo
                                 where n.IdCapitulo == idCapitulo
                                 select n);

                    return query.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void InsertCapitulo(Capitulo objCapitulo)
        {
            try
            {
                using (dbConnection dbcontext = new dbConnection())
                {
                    dbcontext.Capitulo.Add(objCapitulo);
                    dbcontext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void UpdateCapitulo(Capitulo objCapitulo)
        {
            try
            {
                using (dbConnection dbcontext = new dbConnection())
                {
                    Capitulo query = (from n in dbcontext.Capitulo
                                   where n.IdCapitulo == objCapitulo.IdCapitulo
                                   select n).SingleOrDefault();
                    if (query != objCapitulo)
                    {
                        query.NomCapitulo = objCapitulo.NomCapitulo;
                        query.EstadoCapitulo = objCapitulo.EstadoCapitulo;
                    }
                    dbcontext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<Capitulo> GetCapituloByAnexo(int idAnexo)
        {
            try
            {
                using (dbConnection dbcontext = new dbConnection())
                {
                    var query = (from n in dbcontext.Capitulo
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

    }
}
