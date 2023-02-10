using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descrizione di riepilogo per REFERENTI
/// </summary>
public class REFERENTI
{
    //diciarazione delle variabili
    public int chiave;
    public int chiaveCliente;
    public string COGNOME;
    public string NOME;
    public string EMAIL;
    public string TELEFONO;

    //dichiarazione del costruttore
    public REFERENTI()
    {

    }

    /// <summary>
    /// il metodo Insert della classe REFERENTI serve ad inserire nuovi referenti nel database
    /// </summary>
    public void Insert()
    {
        DATABASE.cmd.Parameters.Clear();
        DATABASE.cmd.CommandText = "REFERENTI_Insert";
        DATABASE.cmd.Parameters.AddWithValue("chiaveCliente", chiaveCliente);
        DATABASE.cmd.Parameters.AddWithValue("COGNOME", COGNOME);
        DATABASE.cmd.Parameters.AddWithValue("NOME", NOME);
        DATABASE.cmd.Parameters.AddWithValue("EMAIL", EMAIL);
        DATABASE.cmd.Parameters.AddWithValue("TELEFONO", TELEFONO);
        DATABASE.EseguiSPNonRead();
    }

    /// <summary>
    /// il metodo Update della classe REFERENTI serve a modificare i referenti nel database
    /// </summary>
    public void Update()
    {
        DATABASE.cmd.Parameters.Clear();
        DATABASE.cmd.CommandText = "REFERENTI_Insert";
        DATABASE.cmd.Parameters.AddWithValue("COGNOME", COGNOME);
        DATABASE.cmd.Parameters.AddWithValue("NOME", NOME);
        DATABASE.cmd.Parameters.AddWithValue("EMAIL", EMAIL);
        DATABASE.cmd.Parameters.AddWithValue("TELEFONO", TELEFONO);
        DATABASE.cmd.Parameters.AddWithValue("chiave", chiave);
        DATABASE.EseguiSPNonRead();
    }

    /// <summary>
    /// il metodo SelectAll della classe REFERENTI serve a leggere i campi dei referenti nel database
    /// </summary>
    public DataTable SelectAll()
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        DATABASE.query = "REFERENTI_SelectAll";
        dt = DATABASE.EseguiSPRead();
        return dt;
    }

    /// <summary>
    /// il metodo SelectAll_DDL della classe REFERENTI serve a selezionare il nome, cognome ed email dei referenti nel database in una dropdown list
    /// </summary>
    public DataTable SelectAll_DDL()
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        DATABASE.query = "REFERENTI_SelectAll_DDL";
        dt = DATABASE.EseguiSPRead();
        return dt;
    }

    /// <summary>
    /// il metodo SelectByKey della classe REFERENTI serve a selezionare la chiave del referente selezionato nel database
    /// </summary>
    public DataTable SelectByKey()
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        DATABASE.query = "COMMESSE_SelectByKey";
        DATABASE.cmd.Parameters.AddWithValue("chiave", chiave);
        dt = DATABASE.EseguiSPRead();
        return dt;
    }
}