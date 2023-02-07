using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


public class COMMESSE
{
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
    public int PEDAGGIO;
    public int MEZZI;
    //DATABASE DB = new DATABASE();

    public COMMESSE()
    {

    }

    public void Insert()
    {
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
        DATABASE.cmd.Parameters.AddWithValue("PEDAGGIO", PEDAGGIO);
        DATABASE.cmd.Parameters.AddWithValue("MEZZI", MEZZI);
        DATABASE.EseguiSPNonRead();
    }

    public void Update()
    {
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
        DATABASE.cmd.Parameters.AddWithValue("PEDAGGIO", PEDAGGIO);
        DATABASE.cmd.Parameters.AddWithValue("MEZZI", MEZZI);
        DATABASE.cmd.Parameters.AddWithValue("chiave", chiave);
        DATABASE.EseguiSPNonRead();
    }

    public DataTable SelectAll()
    {
        DataTable dt = new DataTable();
        DATABASE.query = "COMMESSE_SelectAll";
        dt = DATABASE.EseguiSPRead();
        return dt;
    }

    public DataTable SelectAll_DDL_Cliente()
    {
        DataTable dt = new DataTable();
        DATABASE.query = "COMMESSE_SelectAll_DDL_Cliente";
        dt = DATABASE.EseguiSPRead();
        return dt;
    }
    public DataTable SelectAll_DDL_CorpoOra()
    {
        DataTable dt = new DataTable();
        DATABASE.query = "COMMESSE_SelectAll_DDL_CorpoOra";
        dt = DATABASE.EseguiSPRead();
        return dt;
    }

    public DataTable SelectAll_DDL_Responsabile()
    {
        DataTable dt = new DataTable();
        DATABASE.query = "COMMESSE_SelectAll_DDL_Responsabile";
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

    public DataTable SelectAll_DateInterval(string start, string end)
    {
        DataTable dt = new DataTable();
        DATABASE.query = "COMMESSE_SelectAll_DateInterval";
        DATABASE.cmd.Parameters.AddWithValue("startdate", start);
        DATABASE.cmd.Parameters.AddWithValue("enddate", end);
        dt = DATABASE.EseguiSPRead();
        return dt;
    }

}