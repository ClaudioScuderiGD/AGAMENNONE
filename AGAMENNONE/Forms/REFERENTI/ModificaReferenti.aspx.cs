using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_REFERENTI_ModificaReferenti : System.Web.UI.Page
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

            REFERENTI R = new REFERENTI();
            R.chiave = Convert.ToInt32(chiavegriglia);
            DataTable dt = new DataTable();
            dt = R.SelectByKey();

            txtCognome.Text = dt.Rows[0]["cognome"].ToString();
            txtNome.Text = dt.Rows[0]["nome"].ToString();
            txtEmail.Text = dt.Rows[0]["email"].ToString();
            txtTelefono.Text = dt.Rows[0]["telefono"].ToString();
        }
    }
}