using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

public class AZIENDE
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

    public AZIENDE()
    {

    }

    public void Insert()
    {
        DATABASE DB = new DATABASE();
        DB.query = "AZIENDE_Insert";
        DB.cmd.Parameters.AddWithValue("ragionesociale", ragionesociale);   
        DB.cmd.Parameters.AddWithValue("indirizzo", indirizzo);
        DB.cmd.Parameters.AddWithValue("citta", citta);
        DB.cmd.Parameters.AddWithValue("cap", cap);
        DB.cmd.Parameters.AddWithValue("provincia", provincia);
        DB.cmd.Parameters.AddWithValue("email", email);
        DB.cmd.Parameters.AddWithValue("telefono", telefono);
        DB.cmd.Parameters.AddWithValue("codicefiscale", codicefiscale);
        DB.cmd.Parameters.AddWithValue("piva", piva);
        DB.cmd.Parameters.AddWithValue("pec", pec);
        DB.cmd.Parameters.AddWithValue("cfe", cfe);
        DB.cmd.Parameters.AddWithValue("titolare", titolare);
        DB.cmd.Parameters.AddWithValue("emailtitolare", emailtitolare);
        DB.cmd.Parameters.AddWithValue("teltitolare", teltitolare);
        DB.EseguiSPNonRead();
    }

    public void Update()
    {
        DATABASE DB = new DATABASE();
        DB.query = "AZIENDE_Update";
        DB.cmd.Parameters.AddWithValue("chiave", chiave);
        DB.cmd.Parameters.AddWithValue("ragionesociale", ragionesociale);
        DB.cmd.Parameters.AddWithValue("indirizzo", indirizzo);
        DB.cmd.Parameters.AddWithValue("citta", citta);
        DB.cmd.Parameters.AddWithValue("cap", cap);
        DB.cmd.Parameters.AddWithValue("provincia", provincia);
        DB.cmd.Parameters.AddWithValue("email", email);
        DB.cmd.Parameters.AddWithValue("telefono", telefono);
        DB.cmd.Parameters.AddWithValue("codicefiscale", codicefiscale);
        DB.cmd.Parameters.AddWithValue("piva", piva);
        DB.cmd.Parameters.AddWithValue("pec", pec);
        DB.cmd.Parameters.AddWithValue("cfe", cfe);
        DB.cmd.Parameters.AddWithValue("titolare", titolare);
        DB.cmd.Parameters.AddWithValue("emailtitolare", emailtitolare);
        DB.cmd.Parameters.AddWithValue("teltitolare", teltitolare); 
        DB.EseguiSPNonRead();
    }

    public DataTable SelectAll()
    {
        DataTable dt = new DataTable();
        DATABASE DB = new DATABASE();
        DB.query = "AZIENDE_SelectAll";
        dt = DB.EseguiSPRead();
        return dt;
    }

    public DataTable SelectAll_DDL()
    {
        DataTable dt = new DataTable();
        DATABASE DB = new DATABASE();
        DB.query = "AZIENDE_SelectAll_DDL";
        dt = DB.EseguiSPRead();
        return dt;
    }

    public DataTable SelectByKey()
    {
        DataTable dt = new DataTable();
        DATABASE DB = new DATABASE();
        DB.query = "AZIENDE_SelectByKey";
        DB.cmd.Parameters.AddWithValue("chiave", chiave);
        dt = DB.EseguiSPRead();
        return dt;
    }
}