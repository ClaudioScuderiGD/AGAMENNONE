using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_FATTURE_ModificaFattura : System.Web.UI.Page
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

            FATTURE F = new FATTURE();
            F.chiave = Convert.ToInt32(chiavegriglia);
            DataTable dt = new DataTable();
            dt = F.SelectByKey();

            txtNumFattura.Text = dt.Rows[0]["numerofattura"].ToString();
            txtDataFattura.Text = dt.Rows[0]["datafattura"].ToString();
            txtImporto.Text = dt.Rows[0]["importo"].ToString();
            txtAliquota.Text = dt.Rows[0]["aliquota"].ToString();
            txtDescrizione.Text = dt.Rows[0]["descrizione"].ToString();
            txtDataSaldo.Text = dt.Rows[0]["datasaldo"].ToString();
        }
    }

    protected void btnSalva_Click(object sender, EventArgs e)
    {
        if (txtNumFattura.Text.Trim() == "")
        {
            ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('Errore');", true);
            return;
        }
        string chiavegriglia = Session["chiave"].ToString();

        FATTURE F = new FATTURE();

        F.chiave = Convert.ToInt32(chiavegriglia);
        F.numerofattura = txtNumFattura.Text.Trim();
        F.datafattura = txtDataFattura.Text.Trim();
        F.datasaldo = txtDataSaldo.Text.Trim();
        F.importo = int.Parse(txtImporto.Text.Trim());
        F.aliquota = int.Parse(txtAliquota.Text.Trim());
        F.descrizione = txtDescrizione.Text.Trim();

        F.Update();
        DataBind();
    }
}