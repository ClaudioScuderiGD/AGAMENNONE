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

  

    protected void grigliaAbilitazione_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (grigliaAbilitazione.SelectedValue == null)
        {
            Session["chiave"] = null;
            return;
        }
        Session["chiave"] = grigliaAbilitazione.SelectedValue.ToString();
    }

    protected void btnAbilita_Click(object sender, EventArgs e)
    {
        string chiavegriglia = Session["chiave"].ToString();
        DIPENDENTI D = new DIPENDENTI();
        D.chiave = Convert.ToInt32(chiavegriglia);
        D.Abilita();
        grigliaAbilitazione.DataBind();
    }
}