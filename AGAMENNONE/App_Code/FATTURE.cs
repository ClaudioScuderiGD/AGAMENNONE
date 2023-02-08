using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


public class FATTURE
{
    public int chiave;
    public int chiaveCommessa;
    public string numerofattura;
    public string datafattura;
    public int importo;
    public int aliquota;
    public string descrizione;
    public string datasaldo;

    public FATTURE()
    {

    }

    public void Insert()
    {
        DATABASE.cmd.Parameters.Clear();
        //DATABASE DB = new DATABASE();
        DATABASE.query = "FATTURE_Insert";
        DATABASE.cmd.Parameters.AddWithValue("chiaveCommessa", chiaveCommessa);
        DATABASE.cmd.Parameters.AddWithValue("numerofattura", numerofattura);
        DATABASE.cmd.Parameters.AddWithValue("datafattura", datafattura);
        DATABASE.cmd.Parameters.AddWithValue("importo", importo);
        DATABASE.cmd.Parameters.AddWithValue("aliquota", aliquota);
        DATABASE.cmd.Parameters.AddWithValue("descrizione", descrizione);
        DATABASE.cmd.Parameters.AddWithValue("datasaldo", datasaldo);
        DATABASE.EseguiSPNonRead();
    }

    public void Update()
    {
        DATABASE.cmd.Parameters.Clear();
        //DATABASE DB = new DATABASE();
        DATABASE.query = "FATTURE_Update";
        DATABASE.cmd.Parameters.AddWithValue("chiave", chiave);
        DATABASE.cmd.Parameters.AddWithValue("numerofattura", numerofattura);
        DATABASE.cmd.Parameters.AddWithValue("datafattura", datafattura);
        DATABASE.cmd.Parameters.AddWithValue("importo", importo);
        DATABASE.cmd.Parameters.AddWithValue("aliquota", aliquota);
        DATABASE.cmd.Parameters.AddWithValue("descrizione", descrizione);
        DATABASE.cmd.Parameters.AddWithValue("datasaldo", datasaldo);
        DATABASE.EseguiSPNonRead();
    }

    public DataTable SelectAll()
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        //DATABASE DB = new DATABASE();
        DATABASE.query = "FATTURE_SelectAll";
        dt = DATABASE.EseguiSPRead();
        return dt;
    }

    public DataTable SelectByDataSaldo()
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        //DATABASE DB = new DATABASE();
        DATABASE.query = "FATTURE_SelectByDataSaldo";
        DATABASE.cmd.Parameters.AddWithValue("datasaldo", datasaldo);
        DATABASE.EseguiSPRead();
        return dt;
    }

    public DataTable SelectByKey()
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        //DATABASE DB = new DATABASE();
        DATABASE.query = "FATTURE_SelectByKey";
        DATABASE.cmd.Parameters.AddWithValue("chiave", chiave);
        DATABASE.EseguiSPRead();
        return dt;
    }

    public DataTable SelectByMonth(string anno)
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        //DATABASE DB = new DATABASE();
        DATABASE.query = "FATTURE_SelectByMomth";
        DATABASE.cmd.Parameters.AddWithValue("anno", anno);
        DATABASE.EseguiSPRead();
        return dt;
    }

    public DataTable SelectByYear(string anno)
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        //DATABASE DB = new DATABASE();
        DATABASE.query = "FATTURE_SelectByYear";
        DATABASE.cmd.Parameters.AddWithValue("anno", anno);
        DATABASE.EseguiSPRead();
        return dt;
    }

    public DataTable SelectDate_Interval(string start, string end)
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        //DATABASE DB = new DATABASE();
        DATABASE.query = "FATTURE_SelectDate_Interval";
        DATABASE.cmd.Parameters.AddWithValue("startdate", start);
        DATABASE.cmd.Parameters.AddWithValue("enddate", end);
        DATABASE.EseguiSPRead();
        return dt;
    }
}