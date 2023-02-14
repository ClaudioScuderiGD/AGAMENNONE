using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_CambioPassword : System.Web.UI.Page
{
    public string varSession;

    protected void Page_Load(object sender, EventArgs e)
    {
        varSession = Session["chiave"].ToString();
    }

    protected void btnAccedi_Click(object sender, EventArgs e)
    {
        if (txtNuovaPWD.Text.Trim() == "" || txtConfermaPWD.Text.Trim() == "")
        {
            ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('Un campo è vuoto,pirla');", true);
            return;
        }

        if (txtNuovaPWD.Text.Trim() != txtConfermaPWD.Text.Trim())
        {
            ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('Le password non corrispondono, pirla');", true);
            return;
        }

        DIPENDENTI D = new DIPENDENTI();
        Crypt C = new Crypt();
        D.password = C.Crypta(txtNuovaPWD.Text.Trim());
        D.chiave = int.Parse(varSession);
        D.CambioPassword();
        Response.Redirect("/Forms/Home.aspx");
    }
}