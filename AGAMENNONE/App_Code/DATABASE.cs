using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;


public class DATABASE
{
    public SqlConnection conn = new SqlConnection();
    public string query;
    public SqlCommand cmd = new SqlCommand();
    public SqlDataAdapter DA = new SqlDataAdapter();
    public DataTable DT = new DataTable();

    public DATABASE()
    {
        conn.ConnectionString = @"Data Source=CLAUDIO_PC\SQLEXPRESS;Initial Catalog=AGAMENNONE;Integrated Security=True;";
        cmd.Connection = conn;
    }

    //carica i dati db con una query diretta scritta in SQL
    public DataTable EseguiQueryRead()
    {
        cmd.CommandText = query;
        cmd.CommandType = CommandType.Text;
        DataTable DT = new DataTable();
        DA.SelectCommand = cmd;
        DA.Fill(DT);
        return DT;
    }

    //esegue ins, upd, del sul db
    public void EseguiQueryNonRead()
    {
        cmd.CommandText = query;
        cmd.CommandType = CommandType.Text;
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
    }

    //eseguo una stored procedure senza ritorno di dati
    public void EseguiSPNonRead()
    {
        cmd.CommandText = query;
        cmd.CommandType = CommandType.StoredProcedure;
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
    }

    public DataTable EseguiSPRead()
    {
        cmd.CommandText = query;
        cmd.CommandType = CommandType.StoredProcedure;
        DA.SelectCommand = cmd;
        DA.Fill(DT);
        return DT;
    }
}