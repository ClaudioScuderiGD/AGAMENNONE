using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_LAVORI_ModificaLavoro : System.Web.UI.Page
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

            LAVORI L = new LAVORI();
            L.chiave = Convert.ToInt32(chiavegriglia);
            DataTable dt = new DataTable();
            dt = L.SelectByKey();

            txtDataOra.Text = dt.Rows[0]["dataora"].ToString();
            txtOre.Text = dt.Rows[0]["ore"].ToString();
            txtDescrizione.Text = dt.Rows[0]["descrizione"].ToString();
            txtPernottamento.Text = dt.Rows[0]["pernottamento"].ToString();
            txtPasto.Text = dt.Rows[0]["pasto"].ToString();
            txtKM.Text = dt.Rows[0]["km"].ToString();
            txtPedaggi.Text = dt.Rows[0]["pedaggi"].ToString();
            txtMezzi.Text = dt.Rows[0]["mezzi"].ToString();
            txtSpeseExtra.Text = dt.Rows[0]["speseextra"].ToString();
            txtDescrizioneSpeseExtra.Text = dt.Rows[0]["descrizionespeseextra"].ToString();
        }
    }

    protected void btnSalva_Click(object sender, EventArgs e)
    {
        if (txtDataOra.Text.Trim() == "")
        {
            ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('Errore');", true);
            return;
        }

        LAVORI L = new LAVORI();
        string chiavegriglia = Session["chiave"].ToString();

        L.chiave = Convert.ToInt32(chiavegriglia);
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

        L.Update();
        DataBind();
    }
}