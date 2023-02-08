using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_Clienti : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnChiudiPopup_Click(object sender, EventArgs e)
    {
        grigliaClienti.DataBind();
    }

    protected void grigliaClienti_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (grigliaClienti.SelectedValue == null)
        {
            Session["chiave"] = null;
            return;
        }
        Session["chiave"] = grigliaClienti.SelectedValue.ToString();
        ModalPopupExtender1.Enabled = true;
    }
}