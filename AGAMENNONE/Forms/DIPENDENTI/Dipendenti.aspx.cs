using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_Dipendenti : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnChiudiPopup_Click(object sender, EventArgs e)
    {
        grigliaDipendenti.DataBind();
    }

    protected void grigliaDipendenti_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (grigliaDipendenti.SelectedValue == null)
        {
            Session["chiave"] = null;
            return;
        }
        Session["chiave"] = grigliaDipendenti.SelectedValue.ToString();
        ModalPopupExtender1.Enabled = true;
    }
}