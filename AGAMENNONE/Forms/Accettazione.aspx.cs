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

    protected void grigliaAccettazione_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (grigliaAccettazione.SelectedValue == null)
        {
            Session["chiave"] = null;
            return;
        }
        Session["chiave"] = grigliaAccettazione.SelectedValue.ToString();
    }

    protected void btnAccetta_Click(object sender, EventArgs e)
    {
        string chiavegriglia = Session["chiave"].ToString();
        LAVORI L = new LAVORI();
        L.chiave = Convert.ToInt32(chiavegriglia);
        L.Accetta();
        grigliaAccettazione.DataBind();
    }
}