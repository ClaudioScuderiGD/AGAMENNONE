using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

public class UTENTI
{
    public int key;
    public string email;
    public string password;
    public string tipo;

    public UTENTI()
    {

    }

    public void Insert()
    {
        DATABASE DB = new DATABASE();
        DB.query = "UTENTI_Registrazione";
        DB.cmd.Parameters.AddWithValue("email", email);
        DB.cmd.Parameters.AddWithValue("password", password);
        DB.EseguiSPNonRead();
    }

    public void UpdatePassword()
    {
        DATABASE DB = new DATABASE();
        DB.query = "UTENTI_UpdatePasswordTipo";
        DB.cmd.Parameters.AddWithValue("chiave", key);
        DB.cmd.Parameters.AddWithValue("password", password);
        DB.cmd.Parameters.AddWithValue("tipo", tipo);
        DB.EseguiSPNonRead();
    }

    public DataTable Esistenza()
    {
        DataTable dt = new DataTable();
        DATABASE DB = new DATABASE();
        DB.query = "UTENTI_EmailEsistente";
        DB.cmd.Parameters.AddWithValue("email", email);
        dt = DB.EseguiSPRead();
        return dt;
    }

    public DataTable Login()
    {
        DataTable dt = new DataTable();
        DATABASE DB = new DATABASE();
        DB.query = "UTENTI_Login";
        DB.cmd.Parameters.AddWithValue("email", email);
        DB.cmd.Parameters.AddWithValue("password", password);
        dt = DB.EseguiSPRead();
        return dt;
    }
}