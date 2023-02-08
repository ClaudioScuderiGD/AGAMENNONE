using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_Referenti : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnChiudiPopup_Click(object sender, EventArgs e)
    {
        grigliaReferenti.DataBind();
    }

    protected void grigliaReferenti_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (grigliaReferenti.SelectedValue == null)
        {
            Session["chiave"] = null;
            return;
        }
        Session["chiave"] = grigliaReferenti.SelectedValue.ToString();
        ModalPopupExtender1.Enabled = true;
    }
}