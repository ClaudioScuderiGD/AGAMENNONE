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
        DATABASE DB = new DATABASE();
        DB.query = "FATTURE_Insert";
        DB.cmd.Parameters.AddWithValue("chiaveCommessa", chiaveCommessa);
        DB.cmd.Parameters.AddWithValue("numerofattura", numerofattura);
        DB.cmd.Parameters.AddWithValue("datafattura", datafattura);
        DB.cmd.Parameters.AddWithValue("importo", importo);
        DB.cmd.Parameters.AddWithValue("aliquota", aliquota);
        DB.cmd.Parameters.AddWithValue("descrizione", descrizione);
        DB.cmd.Parameters.AddWithValue("datasaldo", datasaldo);
        DB.EseguiSPNonRead();
    }

    public void Update()
    {
        DATABASE DB = new DATABASE();
        DB.query = "FATTURE_Update";
        DB.cmd.Parameters.AddWithValue("chiave", chiave);
        DB.cmd.Parameters.AddWithValue("numerofattura", numerofattura);
        DB.cmd.Parameters.AddWithValue("datafattura", datafattura);
        DB.cmd.Parameters.AddWithValue("importo", importo);
        DB.cmd.Parameters.AddWithValue("aliquota", aliquota);
        DB.cmd.Parameters.AddWithValue("descrizione", descrizione);
        DB.cmd.Parameters.AddWithValue("datasaldo", datasaldo);
        DB.EseguiSPNonRead();
    }

    public DataTable SelectAll()
    {
        DataTable dt = new DataTable();
        DATABASE DB = new DATABASE();
        DB.query = "FATTURE_SelectAll";
        dt = DB.EseguiSPRead();
        return dt;
    }

    public DataTable SelectByDataSaldo()
    {
        DataTable dt = new DataTable();
        DATABASE DB = new DATABASE();
        DB.query = "FATTURE_SelectByDataSaldo";
        DB.cmd.Parameters.AddWithValue("datasaldo", datasaldo);
        DB.EseguiSPRead();
        return dt;
    }

    public DataTable SelectByKey()
    {
        DataTable dt = new DataTable();
        DATABASE DB = new DATABASE();
        DB.query = "FATTURE_SelectByKey";
        DB.cmd.Parameters.AddWithValue("chiave", chiave);
        DB.EseguiSPRead();
        return dt;
    }

    public DataTable SelectByMonth(string anno)
    {
        DataTable dt = new DataTable();
        DATABASE DB = new DATABASE();
        DB.query = "FATTURE_SelectByMomth";
        DB.cmd.Parameters.AddWithValue("anno", anno);
        DB.EseguiSPRead();
        return dt;
    }

    public DataTable SelectByYear(string anno)
    {
        DataTable dt = new DataTable();
        DATABASE DB = new DATABASE();
        DB.query = "FATTURE_SelectByYear";
        DB.cmd.Parameters.AddWithValue("anno", anno);
        DB.EseguiSPRead();
        return dt;
    }

    public DataTable SelectDate_Interval(string start, string end)
    {
        DataTable dt = new DataTable();
        DATABASE DB = new DATABASE();
        DB.query = "FATTURE_SelectDate_Interval";
        DB.cmd.Parameters.AddWithValue("startdate", start);
        DB.cmd.Parameters.AddWithValue("enddate", end);
        DB.EseguiSPRead();
        return dt;
    }
}