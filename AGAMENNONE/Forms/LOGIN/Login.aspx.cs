using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void btnAccedi_Click(object sender, EventArgs e)
    {
        //controllo che il testo non sia vuoto
        if (txtEmail.Text.Trim() == "" || txtPWD.Text.Trim() == "")
        {
            ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('Un campo è vuoto,pirla');", true);
            return;
        }

        DIPENDENTI D = new DIPENDENTI();
        Crypt C = new Crypt();
        D.email = txtEmail.Text.Trim();
        D.password = C.Crypta(txtPWD.Text.Trim());
        DataTable dt = new DataTable();
        dt = D.Login();

        //se non esistono = messaggio "Email o password sbagliati"
        if (dt.Rows.Count == 0) { 
            ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('Email o password sbagliati');", true);
            return;
        }

        Session["chiave"] = dt.Rows[0]["chiave"].ToString();
        
        if ((bool)dt.Rows[0]["PRIMOACCESSO"])
        {
            Response.Redirect("/Forms/LOGIN/CambioPassword.aspx");
        }
        else
        {
            Response.Redirect("/Forms/Home.aspx");
        }
    }
}