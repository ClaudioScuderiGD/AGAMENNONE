using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_ModificaAzienda : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //string chiavegriglia = Session["chiave"].ToString();
        //if (String.IsNullOrEmpty(chiavegriglia))
        //{
        //    ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('Nessun elemento selezionato');", true);
        //    return;
        //}

        //AZIENDE A = new AZIENDE();
        //A.chiave = Convert.ToInt32(chiavegriglia);
        //DataTable dt = new DataTable();
        //dt = A.SelectByKey();

        //txtRagione.Text = dt.Rows[0]["ragionesociale"].ToString();
        //txtIndirizzo.Text = dt.Rows[0]["indirizzo"].ToString();
    }
}