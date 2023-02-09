using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void grigliaDisabilita_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (grigliaDisabilita.SelectedValue == null)
        {
            Session["chiave"] = null;
            return;
        }
        Session["chiave"] = grigliaDisabilita.SelectedValue.ToString();
    }

    protected void btnDisabilita_Click(object sender, EventArgs e)
    {
        string chiavegriglia = Session["chiave"].ToString();
        DIPENDENTI D = new DIPENDENTI();
        D.chiave = Convert.ToInt32(chiavegriglia);
        D.Disabilita();
        grigliaDisabilita.DataBind();
    }
}