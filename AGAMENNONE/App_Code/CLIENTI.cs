using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descrizione di riepilogo per CLIENTI
/// </summary>
public class CLIENTI
{
    public int chiave;
    public string ragionesociale;
    public string indirizzo;
    public string citta;
    public string cap;
    public string provincia;
    public string email;
    public string telefono;
    public string codicefiscale;
    public string piva;
    public string pec;
    public string cfe;
    public string titolare;
    public string emailtitolare;
    public string teltitolare;

    public CLIENTI()
    {
       
    }

    public void Insert()
    {
        DATABASE.cmd.Parameters.Clear();
        //DATABASE DB = new DATABASE();
        DATABASE.query = "CLIENTI_Insert";
        DATABASE.cmd.Parameters.AddWithValue("ragionesociale", ragionesociale);
        DATABASE.cmd.Parameters.AddWithValue("indirizzo", indirizzo);
        DATABASE.cmd.Parameters.AddWithValue("citta", citta);
        DATABASE.cmd.Parameters.AddWithValue("cap", cap);
        DATABASE.cmd.Parameters.AddWithValue("provincia", provincia);
        DATABASE.cmd.Parameters.AddWithValue("email", email);
        DATABASE.cmd.Parameters.AddWithValue("telefono", telefono);
        DATABASE.cmd.Parameters.AddWithValue("codicefiscale", codicefiscale);
        DATABASE.cmd.Parameters.AddWithValue("piva", piva);
        DATABASE.cmd.Parameters.AddWithValue("pec", pec);
        DATABASE.cmd.Parameters.AddWithValue("cfe", cfe);
        DATABASE.cmd.Parameters.AddWithValue("titolare", titolare);
        DATABASE.cmd.Parameters.AddWithValue("emailtitolare", emailtitolare);
        DATABASE.cmd.Parameters.AddWithValue("teltitolare", teltitolare);
        DATABASE.EseguiSPNonRead();
    }

    public void Update()
    {
        DATABASE.cmd.Parameters.Clear();
        //DATABASE DB = new DATABASE();
        DATABASE.query = "CLIENTI_Update";
        DATABASE.cmd.Parameters.AddWithValue("chiave", chiave);
        DATABASE.cmd.Parameters.AddWithValue("ragionesociale", ragionesociale);
        DATABASE.cmd.Parameters.AddWithValue("indirizzo", indirizzo);
        DATABASE.cmd.Parameters.AddWithValue("citta", citta);
        DATABASE.cmd.Parameters.AddWithValue("cap", cap);
        DATABASE.cmd.Parameters.AddWithValue("provincia", provincia);
        DATABASE.cmd.Parameters.AddWithValue("email", email);
        DATABASE.cmd.Parameters.AddWithValue("telefono", telefono);
        DATABASE.cmd.Parameters.AddWithValue("codicefiscale", codicefiscale);
        DATABASE.cmd.Parameters.AddWithValue("piva", piva);
        DATABASE.cmd.Parameters.AddWithValue("pec", pec);
        DATABASE.cmd.Parameters.AddWithValue("cfe", cfe);
        DATABASE.cmd.Parameters.AddWithValue("titolare", titolare);
        DATABASE.cmd.Parameters.AddWithValue("emailtitolare", emailtitolare);
        DATABASE.cmd.Parameters.AddWithValue("teltitolare", teltitolare);
        DATABASE.EseguiSPNonRead();
    }

    public DataTable SelectAll()
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        //DATABASE DB = new DATABASE();
        DATABASE.query = "CLIENTI_SelectAll";
        dt = DATABASE.EseguiSPRead();
        return dt;
    }

    public DataTable SelectAll_DDL()
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        //DATABASE DB = new DATABASE();
        DATABASE.query = "CLIENTI_SelectAll_DDL";
        dt = DATABASE.EseguiSPRead();
        return dt;
    }

    public DataTable SelectByKey()
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        //DATABASE DB = new DATABASE();
        DATABASE.query = "CLIENTI_SelectByKey";
        DATABASE.cmd.Parameters.AddWithValue("@chiave", chiave);
        dt = DATABASE.EseguiSPRead();
        return dt;
    }
}