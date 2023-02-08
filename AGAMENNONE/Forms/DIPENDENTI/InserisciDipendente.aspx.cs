using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_DIPENDENTI_InserisciDipendente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSalva_Click(object sender, EventArgs e)
    {
        if (txtEmail.Text.Trim() == "")
        {
            ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('Errore');", true);
            return;
        }

        DIPENDENTI D = new DIPENDENTI();

        D.email = txtEmail.Text.Trim();
        D.password = txtPassword.Text.Trim();
        D.abilitato = int.Parse(txtAbilitato.Text.Trim());
        D.primoaccesso = int.Parse(txtPrimoAccesso.Text.Trim());
        D.ruolo = txtRuolo.Text.Trim();
        D.cognome = txtCognome.Text.Trim();
        D.nome = txtNome.Text.Trim();
        D.indirizzo = txtIndirizzo.Text.Trim();
        D.citta = txtCitta.Text.Trim();
        D.cap = txtCap.Text.Trim();
        D.provincia = txtProvincia.Text.Trim();
        D.telefono = txtTelefono.Text.Trim();
        D.costoorario = int.Parse(txtCostoOrario.Text.Trim());
        D.datainiziorapporto = txtDataApertura.Text.Trim();
        D.datafinerapporto = txtDataChiusura.Text.Trim();      

        D.Insert();
        DataBind();
    }
}