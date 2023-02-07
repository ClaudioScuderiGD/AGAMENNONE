using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;

public class ACCESSI
{
    public int chiave;
    public int chiaveDipendente;
    public string dataora;
    public string evento;

    public ACCESSI()
    {
       
    }

    public void Insert()
    {
        //DATABASE DB = new DATABASE();
        DATABASE.query = "ACCESSI_Insert";
        DATABASE.cmd.Parameters.AddWithValue("chiaveDipendente", chiaveDipendente);
        DATABASE.cmd.Parameters.AddWithValue("dataora", dataora);
        DATABASE.cmd.Parameters.AddWithValue("evento", evento);
        DATABASE.EseguiSPNonRead();
    } 
    
    public void DeleteAll()
    {
        //DATABASE DB = new DATABASE();
        DATABASE.query = "ACCESSI_DeleteAll";
        DATABASE.EseguiSPNonRead();
    }

    public DataTable SelectAll()
    {
        DataTable dt = new DataTable();
        //DATABASE DB = new DATABASE();
        DATABASE.query = "ACCESSI_SelectAll";
        dt = DATABASE.EseguiSPRead();
        return dt;
    }

    public DataTable SelectDate_Interval(string start, string end)
    {
        DataTable dt = new DataTable();
        //DATABASE DB = new DATABASE();
        DATABASE.query = "ACCESSI_SelectDate_Interval";
        DATABASE.cmd.Parameters.AddWithValue("startdate", start);
        DATABASE.cmd.Parameters.AddWithValue("enddate", end);
        dt = DATABASE.EseguiSPRead();
        return dt;
    }
}