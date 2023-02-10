using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descrizione di riepilogo per COMMESSE
/// </summary>
public class COMMESSE
{
    //dichiarazione variabili
    public int chiave;
    public int chiaveCliente;
    public int chiaveResponsabile;
    public string CORPOORA;
    public string DATAAPERTURA;
    public string DATACHIUSURA;
    public string DATACONSEGNA;
    public string DESCRIZIONE;
    public int IMPORTOCORPO;
    public int IMPORTOORARIO;
    public int ANTICIPO;
    public int PERNOTTAMENTO;
    public int PASTO;
    public int KM;
    public int PEDAGGI;
    public int MEZZI;

    //dichiarazione del costruttore
    public COMMESSE()
    {

    }

    /// <summary>
    /// il metodo Insert della classe COMMESSE serve ad inserire nuove commesse nel database
    /// </summary>
    public void Insert()
    {
        DATABASE.cmd.Parameters.Clear();
        DATABASE.cmd.CommandText = "COMMESSE_Insert";
        DATABASE.cmd.Parameters.AddWithValue("chiaveCliente", chiaveCliente);
        DATABASE.cmd.Parameters.AddWithValue("chiaveResponsabile", chiaveResponsabile);
        DATABASE.cmd.Parameters.AddWithValue("CORPOORA", CORPOORA);
        DATABASE.cmd.Parameters.AddWithValue("DATAAPERTURA", DATAAPERTURA);
        DATABASE.cmd.Parameters.AddWithValue("DATACHIUSURA", DATACHIUSURA);
        DATABASE.cmd.Parameters.AddWithValue("DATACONSEGNA", DATACONSEGNA);
        DATABASE.cmd.Parameters.AddWithValue("DESCRIZIONE", DESCRIZIONE);
        DATABASE.cmd.Parameters.AddWithValue("IMPORTOCORPO", IMPORTOCORPO);
        DATABASE.cmd.Parameters.AddWithValue("IMPORTOORARIO", IMPORTOORARIO);
        DATABASE.cmd.Parameters.AddWithValue("ANTICIPO", ANTICIPO);
        DATABASE.cmd.Parameters.AddWithValue("PERNOTTAMENTO", PERNOTTAMENTO);
        DATABASE.cmd.Parameters.AddWithValue("PASTO", PASTO);
        DATABASE.cmd.Parameters.AddWithValue("KM", KM);
        DATABASE.cmd.Parameters.AddWithValue("PEDAGGI", PEDAGGI);
        DATABASE.cmd.Parameters.AddWithValue("MEZZI", MEZZI);
        DATABASE.EseguiSPNonRead();
    }

    /// <summary>
    /// il metodo Update della classe COMMESSE serve a modificare le commesse nel database
    /// </summary>
    public void Update()
    {
        DATABASE.cmd.Parameters.Clear();
        DATABASE.cmd.CommandText = "COMMESSE_Update";
        DATABASE.cmd.Parameters.AddWithValue("CORPOORA", CORPOORA);
        DATABASE.cmd.Parameters.AddWithValue("DATAAPERTURA", DATAAPERTURA);
        DATABASE.cmd.Parameters.AddWithValue("DATACHIUSURA", DATACHIUSURA);
        DATABASE.cmd.Parameters.AddWithValue("DATACONSEGNA", DATACONSEGNA);
        DATABASE.cmd.Parameters.AddWithValue("DESCRIZIONE", DESCRIZIONE);
        DATABASE.cmd.Parameters.AddWithValue("IMPORTOCORPO", IMPORTOCORPO);
        DATABASE.cmd.Parameters.AddWithValue("IMPORTOORARIO", IMPORTOORARIO);
        DATABASE.cmd.Parameters.AddWithValue("ANTICIPO", ANTICIPO);
        DATABASE.cmd.Parameters.AddWithValue("PERNOTTAMENTO", PERNOTTAMENTO);
        DATABASE.cmd.Parameters.AddWithValue("PASTO", PASTO);
        DATABASE.cmd.Parameters.AddWithValue("KM", KM);
        DATABASE.cmd.Parameters.AddWithValue("PEDAGGI", PEDAGGI);
        DATABASE.cmd.Parameters.AddWithValue("MEZZI", MEZZI);
        DATABASE.cmd.Parameters.AddWithValue("chiave", chiave);
        DATABASE.EseguiSPNonRead();
    }

    /// <summary>
    /// il metodo SelectAll della classe COMMESSE serve a leggere i campi delle commesse nel database
    /// </summary>
    public DataTable SelectAll()
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        DATABASE.query = "COMMESSE_SelectAll";
        dt = DATABASE.EseguiSPRead();
        return dt;
    }

    /// <summary>
    /// il metodo SelectAll_DDL della classe COMMESSE serve a selezionare la ragione sociale della commessa nel database in una dropdown list
    /// </summary>
    public DataTable SelectAll_DDL_Cliente()
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        DATABASE.query = "COMMESSE_SelectAll_DDL_Cliente";
        dt = DATABASE.EseguiSPRead();
        return dt;
    }

    /// <summary>
    /// il metodo SelectAll_DDL della classe COMMESSE serve a selezionare il corpo ora della commessa nel database in una dropdown list
    /// </summary>
    public DataTable SelectAll_DDL_CorpoOra()
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        DATABASE.query = "COMMESSE_SelectAll_DDL_CorpoOra";
        dt = DATABASE.EseguiSPRead();
        return dt;
    }

    /// <summary>
    /// il metodo SelectAll_DDL_Responsabile della classe COMMESSE serve a selezionare il responsabile della commessa nel database in una dropdown list
    /// </summary>
    public DataTable SelectAll_DDL_Responsabile()
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        DATABASE.query = "COMMESSE_SelectAll_DDL_Responsabile";
        dt = DATABASE.EseguiSPRead();
        return dt;
    }

    /// <summary>
    /// il metodo SelectByKey della classe COMMESSE serve a selezionare la chiave della commessa selezionata nel database
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

    /// <summary>
    /// il metodo SelectDate_Interval della classe COMMESSE serve a leggere l'intervallo di date tra data d'inizio e data di fine di una commessa all'interno del database
    /// </summary>
    public DataTable SelectAll_DateInterval(string start, string end)
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        DATABASE.query = "COMMESSE_SelectAll_DateInterval";
        DATABASE.cmd.Parameters.AddWithValue("startdate", start);
        DATABASE.cmd.Parameters.AddWithValue("enddate", end);
        dt = DATABASE.EseguiSPRead();
        return dt;
    }

}