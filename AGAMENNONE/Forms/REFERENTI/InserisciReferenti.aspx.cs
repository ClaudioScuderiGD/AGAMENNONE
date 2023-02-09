using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_REFERENTI_InserisciReferenti : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSalva_Click(object sender, EventArgs e)
    {
        if (txtCognome.Text.Trim() == "")
        {
            ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('Errore');", true);
            return;
        }
       
        REFERENTI R = new REFERENTI();

        R.COGNOME = txtCognome.Text.Trim();
        R.NOME = txtNome.Text.Trim();
        R.EMAIL = txtEmail.Text.Trim();
        R.TELEFONO = txtTelefono.Text.Trim();

        R.Insert();
        DataBind();
    }
}