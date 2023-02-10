using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descrizione di riepilogo per EVENTI
/// </summary>
public class EVENTI
{
    //dichiarazione delle variabili
    public int chiave;
    public int chiaveDipendente;
    public string dataora;
    public string evento;

    //dichiarazione del costruttore
    public EVENTI()
    {

    }

    /// <summary>
    /// il metodo Insert della classe EVENTI serve ad inserire nuovi eventi nel database
    /// </summary>
    public void Insert()
    {
        DATABASE.cmd.Parameters.Clear();
        DATABASE.query = "EVENTI_Insert";
        DATABASE.cmd.Parameters.AddWithValue("chiaveDipendente", chiaveDipendente);
        DATABASE.cmd.Parameters.AddWithValue("dataora", dataora);
        DATABASE.cmd.Parameters.AddWithValue("evento", evento);
        DATABASE.EseguiSPNonRead();
    }

    /// <summary>
    /// il metodo DeleteAll della classe EVENTI serve ad eliminare gli eventi nel database
    /// </summary>
    public void DeleteAll()
    {
        DATABASE.cmd.Parameters.Clear();
        DATABASE.query = "EVENTI_DeleteAll";
        DATABASE.EseguiSPNonRead();
    }

    /// <summary>
    /// il metodo SelectAll della classe EVENTI serve a leggere i campi degli eventi nel database
    /// </summary>
    public DataTable SelectAll()
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        DATABASE.query = "EVENTI_SelectAll";
        dt = DATABASE.EseguiSPRead();
        return dt;
    }

    /// <summary>
    /// il metodo SelectDate_Interval della classe EVENTI serve a leggere l'intervallo di date tra data d'inizio e data di fine di un evento all'interno del database
    /// </summary>
    public DataTable SelectDate_Interval(string start, string end)
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        DATABASE.query = "EVENTI_SelectDate_Interval";
        DATABASE.cmd.Parameters.AddWithValue("startdate", start);
        DATABASE.cmd.Parameters.AddWithValue("enddate", end);
        dt = DATABASE.EseguiSPRead();
        return dt;
    }
}