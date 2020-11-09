using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebObligaciones.Forms.Anexo
{
    public partial class AdminAnexo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AnexoBL objAnexo = new AnexoBL();
            grvAnexo.DataSource = objAnexo.GetAnexo();
            grvAnexo.DataBind();
        }
    }
}