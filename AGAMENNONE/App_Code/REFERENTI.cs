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
    //DATABASE DB = new DATABASE();

    public REFERENTI()
    {

    }

    public void Insert()
    {
        DATABASE.cmd.CommandText = "REFERENTI_Insert";
        DATABASE.cmd.Parameters.AddWithValue("chiaveCliente", chiaveCliente);
        DATABASE.cmd.Parameters.AddWithValue("COGNOME", COGNOME);
        DATABASE.cmd.Parameters.AddWithValue("NOME", NOME);
        DATABASE.cmd.Parameters.AddWithValue("EMAIL", EMAIL);
        DATABASE.cmd.Parameters.AddWithValue("TELEFONO", TELEFONO);
        DATABASE.EseguiSPNonRead();
    }

    public void Update()
    {
        DATABASE.cmd.CommandText = "REFERENTI_Insert";
        DATABASE.cmd.Parameters.AddWithValue("COGNOME", COGNOME);
        DATABASE.cmd.Parameters.AddWithValue("NOME", NOME);
        DATABASE.cmd.Parameters.AddWithValue("EMAIL", EMAIL);
        DATABASE.cmd.Parameters.AddWithValue("TELEFONO", TELEFONO);
        DATABASE.cmd.Parameters.AddWithValue("chiave", chiave);
        DATABASE.EseguiSPNonRead();
    }

    public DataTable SelectAll()
    {
        DataTable dt = new DataTable();
        DATABASE.query = "REFERENTI_SelectAll";
        dt = DATABASE.EseguiSPRead();
        return dt;
    }

    public DataTable SelectAll_DDL()
    {
        DataTable dt = new DataTable();
        DATABASE.query = "REFERENTI_SelectAll_DDL";
        dt = DATABASE.EseguiSPRead();
        return dt;
    }

    public DataTable SelectByKey()
    {
        DataTable dt = new DataTable();
        DATABASE.query = "COMMESSE_SelectByKey";
        DATABASE.cmd.Parameters.AddWithValue("chiave", chiave);
        dt = DATABASE.EseguiSPRead();
        return dt;
    }
}