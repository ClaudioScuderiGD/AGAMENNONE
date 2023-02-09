using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_LAVORI_InserisciLavoro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSalva_Click(object sender, EventArgs e)
    {
        if (txtDataOra.Text.Trim() == "")
        {
            ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('Errore');", true);
            return;
        }

        LAVORI L = new LAVORI();

        L.chiaveCommessa = int.Parse(ddlCommesse.SelectedValue.ToString());
        L.chiaveDipendente = int.Parse(ddlDipendenti.SelectedValue.ToString());
        L.dataora = txtDataOra.Text.Trim();
        L.ore = int.Parse(txtOre.Text.Trim());
        L.descrizione = txtDescrizione.Text.Trim();
        L.pernottamento = int.Parse(txtPernottamento.Text.Trim());
        L.pasto = int.Parse(txtPasto.Text.Trim());
        L.km = int.Parse(txtKM.Text.Trim());
        L.pedaggi = int.Parse(txtPedaggi.Text.Trim());
        L.mezzi = int.Parse(txtMezzi.Text.Trim());
        L.speseextra = int.Parse(txtSpeseExtra.Text.Trim());
        L.descrizionespeseextra = txtDescrizioneSpeseExtra.Text.Trim();

        int spese = int.Parse(txtPernottamento.Text.Trim()) + int.Parse(txtPasto.Text.Trim()) + int.Parse(txtKM.Text.Trim()) + int.Parse(txtPedaggi.Text.Trim()) + int.Parse(txtMezzi.Text.Trim());

        if (L.speseextra < spese)
        {
            L.accettazionespese = 1;
        }
        else L.accettazionespese = 0;

        L.Insert();
        DataBind();
    }
}