using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

namespace WebObligaciones.Forms.Capitulo
{
    public partial class AdminCapitulo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CapituloBL objCapitulo = new CapituloBL();
            grvCapitulo.DataSource = objCapitulo.GetCapitulo();
            grvCapitulo.DataBind();
        }
    }
}