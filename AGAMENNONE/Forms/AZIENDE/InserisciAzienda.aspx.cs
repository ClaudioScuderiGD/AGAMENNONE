using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_InserisciAzienda : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSalva_Click(object sender, EventArgs e)
    {
        if (txtRagione.Text.Trim() == "")
        {
            ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('Errore');", true);
            return;
        }

        AZIENDE A = new AZIENDE();
        
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

        A.Insert();
        DataBind();
    }
}