using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_FATTURE_InserisciFattura : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSalva_Click(object sender, EventArgs e)
    {

        if (txtNumFattura.Text.Trim() == "")
        {
            ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('Errore');", true);
            return;
        }

        FATTURE F = new FATTURE();

        F.chiaveCommessa = int.Parse(ddlCommessa.SelectedValue.ToString());
        F.numerofattura = txtNumFattura.Text.Trim();
        F.datafattura = txtDataFattura.Text.Trim();
        F.datasaldo = txtDataSaldo.Text.Trim();
        F.importo = int.Parse(txtImporto.Text.Trim());
        F.aliquota = int.Parse(txtAliquota.Text.Trim());
        F.descrizione = txtDescrizione.Text.Trim();

        F.Insert();
        DataBind();
    }
}