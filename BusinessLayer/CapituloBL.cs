using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;
using DataLayer;

namespace BusinessLayer
{
    public class CapituloBL
    {
        public List<Capitulo> GetCapitulo()
        {
            CapituloDL dataCapitulo = new CapituloDL();
            return dataCapitulo.GetCapitulo();
        }
        public List<Capitulo> GetCapituloById(int idCapitulo)
        {
            CapituloDL dataCapitulo = new CapituloDL();
            return dataCapitulo.GetCapituloById(idCapitulo);
        }
        public void InsertCapitulo(Capitulo objCapitulo)
        {
            CapituloDL dataCapitulo = new CapituloDL();
            dataCapitulo.InsertCapitulo(objCapitulo);
        }
        public void UpdateCapitulo(Capitulo objCapitulo)
        {
            CapituloDL dataCapitulo = new CapituloDL();
            dataCapitulo.UpdateCapitulo(objCapitulo);
        }
    }
}
