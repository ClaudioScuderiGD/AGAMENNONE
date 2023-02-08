using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_DIPENDENTI_ModificaDipendente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["chiave"] == null)
            {
                return;
            }
            string chiavegriglia = Session["chiave"].ToString();
            if (String.IsNullOrEmpty(chiavegriglia))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('Nessun elemento selezionato');", true);
                return;
            }

            DIPENDENTI D = new DIPENDENTI();
            D.chiave = Convert.ToInt32(chiavegriglia);
            DataTable dt = new DataTable();
            dt = D.SelectByKey();

            txtEmail.Text = dt.Rows[0]["email"].ToString();
            txtPassword.Text = dt.Rows[0]["password"].ToString();
            txtAbilitato.Text = dt.Rows[0]["abilitato"].ToString();
            txtPrimoAccesso.Text = dt.Rows[0]["primoaccesso"].ToString();
            txtRuolo.Text = dt.Rows[0]["ruolo"].ToString();
            txtCognome.Text = dt.Rows[0]["cognome"].ToString();
            txtNome.Text = dt.Rows[0]["nome"].ToString();
            txtIndirizzo.Text = dt.Rows[0]["indirizzo"].ToString();
            txtCitta.Text = dt.Rows[0]["citta"].ToString();
            txtCap.Text = dt.Rows[0]["cap"].ToString();
            txtProvincia.Text = dt.Rows[0]["provincia"].ToString();
            txtTelefono.Text = dt.Rows[0]["telefono"].ToString();
            txtCostoOrario.Text = dt.Rows[0]["costoorario"].ToString();
            txtDataApertura.Text = dt.Rows[0]["datainiziorapporto"].ToString();
            txtDataChiusura.Text = dt.Rows[0]["datafinerapporto"].ToString();
        }
    }
}