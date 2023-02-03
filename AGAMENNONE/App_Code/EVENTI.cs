using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

public class EVENTI
{
    public int chiave;
    public int chiaveDipendente;
    public string dataora;
    public string evento;

    public EVENTI()
    {

    }

    public void Insert()
    {
        DATABASE DB = new DATABASE();
        DB.query = "EVENTI_Insert";
        DB.cmd.Parameters.AddWithValue("chiaveDipendente", chiaveDipendente);
        DB.cmd.Parameters.AddWithValue("dataora", dataora);
        DB.cmd.Parameters.AddWithValue("evento", evento);
        DB.EseguiSPNonRead();
    }

    public void DeleteAll()
    {
        DATABASE DB = new DATABASE();
        DB.query = "EVENTI_DeleteAll";
        DB.EseguiSPNonRead();
    }

    public DataTable SelectAll()
    {
        DataTable dt = new DataTable();
        DATABASE DB = new DATABASE();
        DB.query = "EVENTI_SelectAll";
        dt = DB.EseguiSPRead();
        return dt;
    }

    public DataTable SelectDate_Interval(string start, string end)
    {
        DataTable dt = new DataTable();
        DATABASE DB = new DATABASE();
        DB.query = "EVENTI_SelectDate_Interval";
        DB.cmd.Parameters.AddWithValue("startdate", start);
        DB.cmd.Parameters.AddWithValue("enddate", end);
        dt = DB.EseguiSPRead();
        return dt;
    }
}