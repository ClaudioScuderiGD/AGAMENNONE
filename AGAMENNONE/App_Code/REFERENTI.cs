using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

public class REFERENTI
{
    public int chiave;
    public int chiaveCliente;
    public string COGNOME;
    public string NOME;
    public string EMAIL;
    public string TELEFONO;
    DATABASE DB = new DATABASE();

    public REFERENTI()
    {

    }

    public void Insert()
    {
        DB.cmd.CommandText = "REFERENTI_Insert";
        DB.cmd.Parameters.AddWithValue("chiaveCliente", chiaveCliente);
        DB.cmd.Parameters.AddWithValue("COGNOME", COGNOME);
        DB.cmd.Parameters.AddWithValue("NOME", NOME);
        DB.cmd.Parameters.AddWithValue("EMAIL", EMAIL);
        DB.cmd.Parameters.AddWithValue("TELEFONO", TELEFONO);
        DB.EseguiSPNonRead();
    }

    public void Update()
    {
        DB.cmd.CommandText = "REFERENTI_Insert";
        DB.cmd.Parameters.AddWithValue("COGNOME", COGNOME);
        DB.cmd.Parameters.AddWithValue("NOME", NOME);
        DB.cmd.Parameters.AddWithValue("EMAIL", EMAIL);
        DB.cmd.Parameters.AddWithValue("TELEFONO", TELEFONO);
        DB.cmd.Parameters.AddWithValue("chiave", chiave);
        DB.EseguiSPNonRead();
    }

    public DataTable SelectAll()
    {
        DataTable dt = new DataTable();
        DB.query = "REFERENTI_SelectAll";
        dt = DB.EseguiSPRead();
        return dt;
    }

    public DataTable SelectAll_DDL()
    {
        DataTable dt = new DataTable();
        DB.query = "REFERENTI_SelectAll_DDL";
        dt = DB.EseguiSPRead();
        return dt;
    }

    public DataTable SelectByKey()
    {
        DataTable dt = new DataTable();
        DB.query = "COMMESSE_SelectByKey";
        DB.cmd.Parameters.AddWithValue("chiave", chiave);
        dt = DB.EseguiSPRead();
        return dt;
    }
}