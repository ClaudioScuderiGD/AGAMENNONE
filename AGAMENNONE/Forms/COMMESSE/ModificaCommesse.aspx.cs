using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_COMMESSE_ModificaCommesse : System.Web.UI.Page
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

            COMMESSE CS = new COMMESSE();
            CS.chiave = Convert.ToInt32(chiavegriglia);
            DataTable dt = new DataTable();
            dt = CS.SelectByKey();

            txtCorpoOra.Text = dt.Rows[0]["corpoora"].ToString();
            txtDataApertura.Text = dt.Rows[0]["dataapertura"].ToString();
            txtDataChiusura.Text = dt.Rows[0]["datachiusura"].ToString();
            txtDataConsegna.Text = dt.Rows[0]["dataconsegna"].ToString();
            txtDescrizione.Text = dt.Rows[0]["descrizione"].ToString();
            txtImportoCorpo.Text = dt.Rows[0]["importocorpo"].ToString();
            txtImportoOrario.Text = dt.Rows[0]["importoorario"].ToString();
            txtAnticipo.Text = dt.Rows[0]["anticipo"].ToString();
            txtPernottamento.Text = dt.Rows[0]["pernottamento"].ToString();
            txtPasto.Text = dt.Rows[0]["pasto"].ToString();
            txtKM.Text = dt.Rows[0]["km"].ToString();
            txtPedaggi.Text = dt.Rows[0]["pedaggi"].ToString();
            txtMezzi.Text = dt.Rows[0]["mezzi"].ToString();
        }
    }
}