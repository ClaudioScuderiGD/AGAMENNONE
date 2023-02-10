using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Configuration;

/// <summary>
/// Descrizione di riepilogo per DATABASE
/// </summary>
public static class DATABASE
{
    //dichiarazione variabili
    public static string query;
    public static SqlConnection conn = new SqlConnection();    
    public static SqlCommand cmd = new SqlCommand();
    public static SqlDataAdapter DA = new SqlDataAdapter();
    public static DataTable DT = new DataTable();

    static DATABASE()
    {
        //conn.ConnectionString = @"Data Source=DESKTOP-GR1O3LV\SQLEXPRESS;Initial Catalog=AGAMENNONE;Integrated Security=True;";
        conn.ConnectionString = ConfigurationManager.ConnectionStrings["AGAMENNONEConnectionString"].ConnectionString;
        cmd.Connection = conn;
    }

    /// <summary>
    /// carica i dati db con una query diretta scritta in SQL
    /// </summary>
    public static DataTable EseguiQueryRead()
    {
        cmd.CommandText = query;
        cmd.CommandType = CommandType.Text;
        DataTable DT = new DataTable();
        DA.SelectCommand = cmd;
        DA.Fill(DT);
        return DT;
    }

    /// <summary>
    /// esegue ins, upd, del sul db
    /// </summary>
    public static void EseguiQueryNonRead()
    {
        cmd.CommandText = query;
        cmd.CommandType = CommandType.Text;
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
    }

    /// <summary>
    /// eseguo una stored procedure senza ritorno di dati
    /// </summary>
    public static void EseguiSPNonRead()
    {
        cmd.CommandText = query;
        cmd.CommandType = CommandType.StoredProcedure;
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
    }

    /// <summary>
    /// eseguo una stored procedure con ritorno di dati
    /// </summary>
    public static DataTable EseguiSPRead()
    {
        cmd.CommandText = query;
        cmd.CommandType = CommandType.StoredProcedure;
        DA.SelectCommand = cmd;
        DA.Fill(DT);
        return DT;
    }
}