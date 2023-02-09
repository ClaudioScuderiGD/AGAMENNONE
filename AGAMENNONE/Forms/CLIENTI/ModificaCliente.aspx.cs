using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_CLIENTI_ModificaCliente : System.Web.UI.Page
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

            CLIENTI C = new CLIENTI();
            C.chiave = Convert.ToInt32(chiavegriglia);
            DataTable dt = new DataTable();
            dt = C.SelectByKey();

            txtRagione.Text = dt.Rows[0]["ragionesociale"].ToString();
            txtIndirizzo.Text = dt.Rows[0]["indirizzo"].ToString();
            txtCitta.Text = dt.Rows[0]["citta"].ToString();
            txtCap.Text = dt.Rows[0]["cap"].ToString();
            txtProvincia.Text = dt.Rows[0]["provincia"].ToString();
            txtEmail.Text = dt.Rows[0]["email"].ToString();
            txtTelefono.Text = dt.Rows[0]["telefono"].ToString();
            txtCodiceFiscale.Text = dt.Rows[0]["codicefiscale"].ToString();
            txtPIva.Text = dt.Rows[0]["piva"].ToString();
            txtPEC.Text = dt.Rows[0]["pec"].ToString();
            txtCFE.Text = dt.Rows[0]["cfe"].ToString();
            txtTitolare.Text = dt.Rows[0]["titolare"].ToString();
            txtEmailTitolare.Text = dt.Rows[0]["emailtitolare"].ToString();
            txtTelefonoTitolare.Text = dt.Rows[0]["teltitolare"].ToString();
        }
    }

    protected void btnSalva_Click(object sender, EventArgs e)
    {
        if (txtRagione.Text.Trim() == "")
        {
            ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('Errore');", true);
            return;
        }

        string chiavegriglia = Session["chiave"].ToString();
        CLIENTI C = new CLIENTI();

        C.chiave = Convert.ToInt32(chiavegriglia);
        C.ragionesociale = txtRagione.Text.Trim();
        C.indirizzo = txtIndirizzo.Text.Trim();
        C.citta = txtCitta.Text.Trim();
        C.cap = txtCap.Text.Trim();
        C.provincia = txtProvincia.Text.Trim();
        C.email = txtEmail.Text.Trim();
        C.telefono = txtTelefono.Text.Trim();
        C.codicefiscale = txtCodiceFiscale.Text.Trim();
        C.piva = txtPIva.Text.Trim();
        C.pec = txtPEC.Text.Trim();
        C.cfe = txtCFE.Text.Trim();
        C.titolare = txtTitolare.Text.Trim();
        C.emailtitolare = txtEmailTitolare.Text.Trim();
        C.teltitolare = txtTelefonoTitolare.Text.Trim();

        C.Update();
        DataBind();
    }
}