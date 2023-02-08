using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_LOG_InserisciLogAccessi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSalva_Click(object sender, EventArgs e)
    {
        if (txtEvento.Text.Trim() == "")
        {
            ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('Errore');", true);
            return;
        }

        ACCESSI AS = new ACCESSI();

        AS.dataora = txtDataOra.Text.Trim();
        AS.evento = txtEvento.Text.Trim();
       
        AS.Insert();
        DataBind();
    }
}