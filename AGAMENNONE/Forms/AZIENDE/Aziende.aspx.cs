using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_Aziende : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnChiudiPopup_Click(object sender, EventArgs e)
    {
        griglia.DataBind();
    }

    protected void griglia_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(griglia.SelectedValue == null) 
        {
            Session["chiave"] = null;
            return;
        } 
        Session["chiave"] = griglia.SelectedValue.ToString();
        ModalPopupExtender1.Enabled = true;
    }
}