using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_CLIENTI_InserisciCliente : System.Web.UI.Page
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

        CLIENTI C = new CLIENTI();

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

        C.Insert();
        DataBind();
    }
}