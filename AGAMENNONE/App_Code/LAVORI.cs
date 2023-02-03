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

    public LAVORI()
    {
        
    }

    public void Insert()
    {
        DATABASE DB = new DATABASE();
        DB.query = "LAVORI_Insert";
        DB.cmd.Parameters.AddWithValue("chiaveCommessa", chiaveCommessa);
        DB.cmd.Parameters.AddWithValue("chiaveDipendente", chiaveDipendente);
        DB.cmd.Parameters.AddWithValue("dataora", dataora);
        DB.cmd.Parameters.AddWithValue("ore", ore);
        DB.cmd.Parameters.AddWithValue("descrizione", descrizione);
        DB.cmd.Parameters.AddWithValue("pernottamento", pernottamento);
        DB.cmd.Parameters.AddWithValue("pasto", pasto);
        DB.cmd.Parameters.AddWithValue("km", km);
        DB.cmd.Parameters.AddWithValue("pedaggi", pedaggi);
        DB.cmd.Parameters.AddWithValue("mezzi", mezzi);
        DB.cmd.Parameters.AddWithValue("speseextra", speseextra);
        DB.cmd.Parameters.AddWithValue("descrizionespeseextra", descrizionespeseextra);
        DB.cmd.Parameters.AddWithValue("accettazionespese", accettazionespese);
        DB.EseguiSPNonRead();
    }

    public void Update()
    {
        DATABASE DB = new DATABASE();
        DB.query = "LAVORI_Update";
        DB.cmd.Parameters.AddWithValue("chiave", chiave);
        DB.cmd.Parameters.AddWithValue("chiaveCommessa", chiaveCommessa);
        DB.cmd.Parameters.AddWithValue("chiaveDipendente", chiaveDipendente);
        DB.cmd.Parameters.AddWithValue("dataora", dataora);
        DB.cmd.Parameters.AddWithValue("ore", ore);
        DB.cmd.Parameters.AddWithValue("descrizione", descrizione);
        DB.cmd.Parameters.AddWithValue("pernottamento", pernottamento);
        DB.cmd.Parameters.AddWithValue("pasto", pasto);
        DB.cmd.Parameters.AddWithValue("km", km);
        DB.cmd.Parameters.AddWithValue("pedaggi", pedaggi);
        DB.cmd.Parameters.AddWithValue("mezzi", mezzi);
        DB.cmd.Parameters.AddWithValue("speseextra", speseextra);
        DB.cmd.Parameters.AddWithValue("descrizionespeseextra", descrizionespeseextra);
        DB.cmd.Parameters.AddWithValue("accettazionespese", accettazionespese);
        DB.EseguiSPNonRead();
    }

    public void Accetta()
    {
        DATABASE DB = new DATABASE();
        DB.query = "LAVORI_Accetta";
        DB.EseguiSPNonRead();      
    }

    public DataTable SelectAll()
    {
        DataTable dt = new DataTable();
        DATABASE DB = new DATABASE();
        DB.query = "LAVORI_SelectAll";
        dt = DB.EseguiSPRead();
        return dt;
    }

    public DataTable SelectByKey()
    {
        DataTable dt = new DataTable();
        DATABASE DB = new DATABASE();
        DB.query = "LAVORI_SelectByKey";
        DB.cmd.Parameters.AddWithValue("chiave", chiave);
        dt = DB.EseguiSPRead();
        return dt;
    }

    public DataTable SelectByAccettazioneSpese()
    {
        DataTable dt = new DataTable();
        DATABASE DB = new DATABASE();
        DB.query = "LAVORI_SelectByAccettazioneSpese";
        DB.cmd.Parameters.AddWithValue("accettazionespese", accettazionespese);
        dt = DB.EseguiSPRead();
        return dt;
    }

    public DataTable SelectByCommessa()
    {
        DataTable dt = new DataTable();
        DATABASE DB = new DATABASE();
        DB.query = "LAVORI_SelectByCommessa";
        DB.cmd.Parameters.AddWithValue("chiaveCommessa", chiaveCommessa);
        dt = DB.EseguiSPRead();
        return dt;
    }

    public DataTable SelectByDipendentiDDL()
    {
        DataTable dt = new DataTable();
        DATABASE DB = new DATABASE();
        DB.query = "LAVORI_SelectByDipendentiDDL";
        dt = DB.EseguiSPRead();
        return dt;
    }
}