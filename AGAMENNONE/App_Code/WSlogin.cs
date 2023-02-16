using AjaxControlToolkit.HtmlEditor.ToolbarButtons;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;

/// <summary>
/// Descrizione di riepilogo per WSlogin
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Per consentire la chiamata di questo servizio Web dallo script utilizzando ASP.NET AJAX, rimuovere il commento dalla riga seguente. 
// [System.Web.Script.Services.ScriptService]
public class WSlogin : System.Web.Services.WebService
{

    public WSlogin()
    {

    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }
    
    [WebMethod]
    public DataTable Login(string email, string password)
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        DATABASE.query = "DIPENDENTI_Login";
        DATABASE.cmd.Parameters.AddWithValue("email", email);
        DATABASE.cmd.Parameters.AddWithValue("password", password);
        dt = DATABASE.EseguiSPRead();
        dt.TableName = "Login";
        return dt;
    }
}
