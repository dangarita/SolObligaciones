using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;
using DataLayer;

namespace BusinessLayer
{
    public class AnexoBL
    {   
        public List<Anexo> GetAnexo()
        {
            AnexoDL dataAnexo = new AnexoDL();
            return dataAnexo.GetAnexo();
        }
        public List<Anexo> GetAnexoById(int idAnexo)
        {
            AnexoDL dataAnexo = new AnexoDL();
            return dataAnexo.GetAnexoById(idAnexo);
        }
        public void InsertAnexo(Anexo objAnexo)
        {
            AnexoDL dataAnexo = new AnexoDL();
            dataAnexo.InsertAnexo(objAnexo);
        }
        public void UpdateAnexo(Anexo objAnexo)
        {
            AnexoDL dataAnexo = new AnexoDL();
            dataAnexo.UpdateAnexo(objAnexo);
        }
    }
}
