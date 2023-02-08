using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_Commesse : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnChiudiPopup_Click(object sender, EventArgs e)
    {
        grigliaCommesse.DataBind();
    }

    protected void grigliaCommesse_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (grigliaCommesse.SelectedValue == null)
        {
            Session["chiave"] = null;
            return;
        }
        Session["chiave"] = grigliaCommesse.SelectedValue.ToString();
        ModalPopupExtender1.Enabled = true;
    }
}