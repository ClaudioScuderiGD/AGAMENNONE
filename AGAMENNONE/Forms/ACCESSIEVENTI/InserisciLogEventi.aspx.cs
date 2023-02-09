using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_LOG_InserisciLogEventi : System.Web.UI.Page
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
        EVENTI E = new EVENTI();

        E.chiaveDipendente = int.Parse(ddlDipendente.SelectedValue.ToString());
        E.dataora = txtDataOra.Text.Trim();
        E.evento = txtEvento.Text.Trim();

        E.Insert();
        DataBind();
    }
}