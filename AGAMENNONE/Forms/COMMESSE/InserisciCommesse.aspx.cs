using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_COMMESSE_InserisciCommesse : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSalva_Click(object sender, EventArgs e)
    {
        if (txtDataApertura.Text.Trim() == "")
        {
            ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('Errore');", true);
            return;
        }

        COMMESSE CS = new COMMESSE();

        CS.CORPOORA = txtCorpoOra.Text.Trim();
        CS.DATAAPERTURA = txtDataApertura.Text.Trim();
        CS.DATACHIUSURA = txtDataChiusura.Text.Trim();
        CS.DATACONSEGNA = txtDataConsegna.Text.Trim();
        CS.DESCRIZIONE = txtDescrizione.Text.Trim();
        CS.IMPORTOCORPO = int.Parse(txtImportoCorpo.Text.Trim());
        CS.IMPORTOORARIO = int.Parse(txtImportoOrario.Text.Trim());
        CS.ANTICIPO = int.Parse(txtAnticipo.Text.Trim());
        CS.PERNOTTAMENTO = int.Parse(txtPernottamento.Text.Trim());
        CS.PASTO = int.Parse(txtPasto.Text.Trim());
        CS.KM = int.Parse(txtKM.Text.Trim());
        CS.PEDAGGI = int.Parse(txtPedaggi.Text.Trim());
        CS.MEZZI = int.Parse(txtMezzi.Text.Trim());

        CS.Insert();
        DataBind();
    }
}