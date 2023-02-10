using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Web;

/// <summary>
/// Descrizione di riepilogo per LAVORI
/// </summary>
public class LAVORI
{
    //dichiarazione delle variabili
    public int chiave;
    public int chiaveCommessa;
    public int chiaveDipendente;
    public string dataora;
    public int ore;
    public string descrizione;
    public int pernottamento;
    public int pasto;
    public int km;
    public int pedaggi;
    public int mezzi;
    public int speseextra;
    public string descrizionespeseextra;
    public int accettazionespese;

    //dichiarazione del costruttore
    public LAVORI()
    {
        
    }

    /// <summary>
    /// il metodo Insert della classe LAVORI serve ad inserire nuovi lavori nel database
    /// </summary>
    public void Insert()
    {
        DATABASE.cmd.Parameters.Clear();
        DATABASE.query = "LAVORI_Insert";
        DATABASE.cmd.Parameters.AddWithValue("chiaveCommessa", chiaveCommessa);
        DATABASE.cmd.Parameters.AddWithValue("chiaveDipendente", chiaveDipendente);
        DATABASE.cmd.Parameters.AddWithValue("dataora", dataora);
        DATABASE.cmd.Parameters.AddWithValue("ore", ore);
        DATABASE.cmd.Parameters.AddWithValue("descrizione", descrizione);
        DATABASE.cmd.Parameters.AddWithValue("pernottamento", pernottamento);
        DATABASE.cmd.Parameters.AddWithValue("pasto", pasto);
        DATABASE.cmd.Parameters.AddWithValue("km", km);
        DATABASE.cmd.Parameters.AddWithValue("pedaggi", pedaggi);
        DATABASE.cmd.Parameters.AddWithValue("mezzi", mezzi);
        DATABASE.cmd.Parameters.AddWithValue("speseextra", speseextra);
        DATABASE.cmd.Parameters.AddWithValue("descrizionespeseextra", descrizionespeseextra);
        DATABASE.cmd.Parameters.AddWithValue("accettazionespese", accettazionespese);
        DATABASE.EseguiSPNonRead();
    }

    /// <summary>
    /// il metodo Update della classe LAVORI serve ad inserire nuovi lavori nel database
    /// </summary>
    public void Update()
    {
        DATABASE.cmd.Parameters.Clear();
        DATABASE.query = "LAVORI_Update";
        DATABASE.cmd.Parameters.AddWithValue("chiave", chiave);
        DATABASE.cmd.Parameters.AddWithValue("chiaveCommessa", chiaveCommessa);
        DATABASE.cmd.Parameters.AddWithValue("chiaveDipendente", chiaveDipendente);
        DATABASE.cmd.Parameters.AddWithValue("dataora", dataora);
        DATABASE.cmd.Parameters.AddWithValue("ore", ore);
        DATABASE.cmd.Parameters.AddWithValue("descrizione", descrizione);
        DATABASE.cmd.Parameters.AddWithValue("pernottamento", pernottamento);
        DATABASE.cmd.Parameters.AddWithValue("pasto", pasto);
        DATABASE.cmd.Parameters.AddWithValue("km", km);
        DATABASE.cmd.Parameters.AddWithValue("pedaggi", pedaggi);
        DATABASE.cmd.Parameters.AddWithValue("mezzi", mezzi);
        DATABASE.cmd.Parameters.AddWithValue("speseextra", speseextra);
        DATABASE.cmd.Parameters.AddWithValue("descrizionespeseextra", descrizionespeseextra);
        DATABASE.cmd.Parameters.AddWithValue("accettazionespese", accettazionespese);
        DATABASE.EseguiSPNonRead();
    }

    /// <summary>
    /// il metodo Accetta della classe LAVORI serve ad acccettare nuovi lavori nel database
    /// </summary>
    public void Accetta()
    {
        DATABASE.cmd.Parameters.Clear();
        DATABASE.query = "LAVORI_Accetta";
        DATABASE.cmd.Parameters.AddWithValue("chiave", chiave);
        DATABASE.EseguiSPNonRead();      
    }

    /// <summary>
    /// il metodo SelectAll della classe LAVORI serve a leggere i campi dei lavori nel database
    /// </summary>
    public DataTable SelectAll()
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        DATABASE.query = "LAVORI_SelectAll";
        dt = DATABASE.EseguiSPRead();
        return dt;
    }

    /// <summary>
    /// il metodo SelectByKey della classe LAVORI serve a selezionare la chiave del lavoro selezionato nel database
    /// </summary>
    public DataTable SelectByKey()
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        DATABASE.query = "LAVORI_SelectByKey";
        DATABASE.cmd.Parameters.AddWithValue("chiave", chiave);
        dt = DATABASE.EseguiSPRead();
        return dt;
    }

    /// <summary>
    /// il metodo SelectByAccettazioneSpese della classe LAVORI serve a selezionare l'accettazione spese del lavoro selezionato nel database
    /// </summary>
    public DataTable SelectByAccettazioneSpese()
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        DATABASE.query = "LAVORI_SelectByAccettazioneSpese";
        DATABASE.cmd.Parameters.AddWithValue("accettazionespese", accettazionespese);
        dt = DATABASE.EseguiSPRead();
        return dt;
    }

    /// <summary>
    /// il metodo SelectByCommessa della classe LAVORI serve a selezionare la commessa del lavoro selezionato nel database
    /// </summary>
    public DataTable SelectByCommessa()
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        DATABASE.query = "LAVORI_SelectByCommessa";
        DATABASE.cmd.Parameters.AddWithValue("chiaveCommessa", chiaveCommessa);
        dt = DATABASE.EseguiSPRead();
        return dt;
    }

    /// <summary>
    /// il metodo SelectByDipendentiDDL della classe LAVORI serve a selezionare il dipendente del lavoro nel database in una dropdown list
    /// </summary>
    public DataTable SelectByDipendentiDDL()
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        DATABASE.query = "LAVORI_SelectByDipendentiDDL";
        dt = DATABASE.EseguiSPRead();
        return dt;
    }
}