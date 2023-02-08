using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_ModificaAzienda : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)    
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

            AZIENDE A = new AZIENDE();
            A.chiave = Convert.ToInt32(chiavegriglia);
            DataTable dt = new DataTable();
            dt = A.SelectByKey();

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

        AZIENDE A = new AZIENDE();
        A.chiave = Convert.ToInt32(chiavegriglia);
        A.ragionesociale = txtRagione.Text.Trim();
        A.indirizzo = txtIndirizzo.Text.Trim();
        A.citta = txtCitta.Text.Trim();
        A.cap = txtCap.Text.Trim();
        A.provincia = txtProvincia.Text.Trim();
        A.email = txtEmail.Text.Trim();
        A.telefono = txtTelefono.Text.Trim();
        A.codicefiscale = txtCodiceFiscale.Text.Trim();
        A.piva = txtPIva.Text.Trim();
        A.pec = txtPEC.Text.Trim();
        A.cfe = txtCFE.Text.Trim();
        A.titolare = txtTitolare.Text.Trim();
        A.emailtitolare = txtEmailTitolare.Text.Trim();
        A.teltitolare = txtTelefonoTitolare.Text.Trim();
     
        A.Update();
        DataBind();
    }
}