using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_Accessi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnChiudiPopup_Click(object sender, EventArgs e)
    {
        grigliaLogAccessi.DataBind();
    }

    protected void grigliaLogAccessi_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (grigliaLogAccessi.SelectedValue == null)
        {
            Session["chiave"] = null;
            return;
        }
        Session["chiave"] = grigliaLogAccessi.SelectedValue.ToString();
        ModalPopupExtender1.Enabled = true;
    }
}