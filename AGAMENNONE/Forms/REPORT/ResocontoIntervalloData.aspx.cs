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

    protected void btnCarica_Click(object sender, EventArgs e)
    {
        FATTURE F = new FATTURE();

        F.SelectDate_Interval(txtDataInizio.Text, txtDataFine.Text);
        graficoIntervallo.DataBind();
        grigliaIntervallo.DataBind();
    }
}