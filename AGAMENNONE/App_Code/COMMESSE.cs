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
    DATABASE DB = new DATABASE();

    public COMMESSE()
    {

    }

    public void Insert()
    {
        DB.cmd.CommandText = "COMMESSE_Insert";
        DB.cmd.Parameters.AddWithValue("chiaveCliente", chiaveCliente);
        DB.cmd.Parameters.AddWithValue("chiaveResponsabile", chiaveResponsabile);
        DB.cmd.Parameters.AddWithValue("CORPOORA", CORPOORA);
        DB.cmd.Parameters.AddWithValue("DATAAPERTURA", DATAAPERTURA);
        DB.cmd.Parameters.AddWithValue("DATACHIUSURA", DATACHIUSURA);
        DB.cmd.Parameters.AddWithValue("DATACONSEGNA", DATACONSEGNA);
        DB.cmd.Parameters.AddWithValue("DESCRIZIONE", DESCRIZIONE);
        DB.cmd.Parameters.AddWithValue("IMPORTOCORPO", IMPORTOCORPO);
        DB.cmd.Parameters.AddWithValue("IMPORTOORARIO", IMPORTOORARIO);
        DB.cmd.Parameters.AddWithValue("ANTICIPO", ANTICIPO);
        DB.cmd.Parameters.AddWithValue("PERNOTTAMENTO", PERNOTTAMENTO);
        DB.cmd.Parameters.AddWithValue("PASTO", PASTO);
        DB.cmd.Parameters.AddWithValue("KM", KM);
        DB.cmd.Parameters.AddWithValue("PEDAGGIO", PEDAGGIO);
        DB.cmd.Parameters.AddWithValue("MEZZI", MEZZI);
        DB.EseguiSPNonRead();
    }

    public void Update()
    {
        DB.cmd.CommandText = "COMMESSE_Update";
        DB.cmd.Parameters.AddWithValue("CORPOORA", CORPOORA);
        DB.cmd.Parameters.AddWithValue("DATAAPERTURA", DATAAPERTURA);
        DB.cmd.Parameters.AddWithValue("DATACHIUSURA", DATACHIUSURA);
        DB.cmd.Parameters.AddWithValue("DATACONSEGNA", DATACONSEGNA);
        DB.cmd.Parameters.AddWithValue("DESCRIZIONE", DESCRIZIONE);
        DB.cmd.Parameters.AddWithValue("IMPORTOCORPO", IMPORTOCORPO);
        DB.cmd.Parameters.AddWithValue("IMPORTOORARIO", IMPORTOORARIO);
        DB.cmd.Parameters.AddWithValue("ANTICIPO", ANTICIPO);
        DB.cmd.Parameters.AddWithValue("PERNOTTAMENTO", PERNOTTAMENTO);
        DB.cmd.Parameters.AddWithValue("PASTO", PASTO);
        DB.cmd.Parameters.AddWithValue("KM", KM);
        DB.cmd.Parameters.AddWithValue("PEDAGGIO", PEDAGGIO);
        DB.cmd.Parameters.AddWithValue("MEZZI", MEZZI);
        DB.cmd.Parameters.AddWithValue("chiave", chiave);
        DB.EseguiSPNonRead();
    }

    public DataTable SelectAll()
    {
        DataTable dt = new DataTable();
        DB.query = "COMMESSE_SelectAll";
        dt = DB.EseguiSPRead();
        return dt;
    }

    public DataTable SelectAll_DDL_Cliente()
    {
        DataTable dt = new DataTable();
        DB.query = "COMMESSE_SelectAll_DDL_Cliente";
        dt = DB.EseguiSPRead();
        return dt;
    }
    public DataTable SelectAll_DDL_CorpoOra()
    {
        DataTable dt = new DataTable();
        DB.query = "COMMESSE_SelectAll_DDL_CorpoOra";
        dt = DB.EseguiSPRead();
        return dt;
    }

    public DataTable SelectAll_DDL_Responsabile()
    {
        DataTable dt = new DataTable();
        DB.query = "COMMESSE_SelectAll_DDL_Responsabile";
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

    public DataTable SelectAll_DateInterval(string start, string end)
    {
        DataTable dt = new DataTable();
        DB.query = "COMMESSE_SelectAll_DateInterval";
        DB.cmd.Parameters.AddWithValue("startdate", start);
        DB.cmd.Parameters.AddWithValue("enddate", end);
        dt = DB.EseguiSPRead();
        return dt;
    }

}