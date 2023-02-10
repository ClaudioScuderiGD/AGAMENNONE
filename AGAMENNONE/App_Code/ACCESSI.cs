using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;

/// <summary>
/// Classe che gestisce l'elenco degli accessi dei login dei dipendenti
/// </summary>

public class ACCESSI
{
    //dichiarazione delle variabili della classe
    public int chiave;
    public int chiaveDipendente;
    public string dataora;
    public string evento;

    //costruttore
    public ACCESSI()
    {
        
    }

    //---------------------------------------------------------------------------------------------//
    // dichiarazione dei metodi della classe ACCESSI
    //---------------------------------------------------------------------------------------------//

    /// <summary>
    /// il metodo insert della classe ACCESSI serve a registrare gli accessi nel database
    /// </summary>
    public void Insert()
    {
        DATABASE.cmd.Parameters.Clear();
        DATABASE.query = "ACCESSI_Insert";
        DATABASE.cmd.Parameters.AddWithValue("chiaveDipendente", chiaveDipendente);
        DATABASE.cmd.Parameters.AddWithValue("dataora", dataora);
        DATABASE.cmd.Parameters.AddWithValue("evento", evento);
        DATABASE.EseguiSPNonRead();
    }

    /// <summary>
    /// il metodo DeleteAll della classe ACCESSI serve a cancellare gli accessi nel database
    /// </summary>
    public void DeleteAll()
    {
        DATABASE.cmd.Parameters.Clear();
        DATABASE.query = "ACCESSI_DeleteAll";
        DATABASE.EseguiSPNonRead();
    }

    /// <summary>
    /// il metodo SelectAll della classe ACCESSI serve a leggere gli accessi nel database
    /// </summary>
    public DataTable SelectAll()
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        DATABASE.query = "ACCESSI_SelectAll";
        dt = DATABASE.EseguiSPRead();
        return dt;
    }

    /// <summary>
    /// il metodo SelectDate_Interval della classe ACCESSI serve a leggere l'intervallo di date tra data d'inizio e data di fine di un accesso all'interno del database
    /// </summary>
    public DataTable SelectDate_Interval(string start, string end)
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        DATABASE.query = "ACCESSI_SelectDate_Interval";
        DATABASE.cmd.Parameters.AddWithValue("startdate", start);
        DATABASE.cmd.Parameters.AddWithValue("enddate", end);
        dt = DATABASE.EseguiSPRead();
        return dt;
    }
}