using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Classe che gestisce l'elenco delle aziende
/// </summary>
public class AZIENDE
{
    //dichiarazione delle variabili della classe
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

    //costruttore
    public AZIENDE()
    {

    }

    /// <summary>
    /// il metodo Insert della classe AZIENDE serve ad inserire nuove aziende nel database
    /// </summary>
    public void Insert()
    {
        DATABASE.cmd.Parameters.Clear();
        DATABASE.query = "AZIENDE_Insert";
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

    /// <summary>
    /// il metodo Update della classe AZIENDE serve a modificare le aziende nel database
    /// </summary>
    public void Update()
    {
        DATABASE.cmd.Parameters.Clear();
        DATABASE.query = "AZIENDE_Update";
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

    /// <summary>
    /// il metodo SelectAll della classe AZIENDE serve a leggere le aziende nel database
    /// </summary>
    public DataTable SelectAll()
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        DATABASE.query = "AZIENDE_SelectAll";
        dt = DATABASE.EseguiSPRead();
        return dt;
    }

    /// <summary>
    /// il metodo SelectAll_DDL della classe AZIENDE serve a selezionare la ragione sociale delle aziende nel database in una dropdown list
    /// </summary>
    public DataTable SelectAll_DDL()
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        DATABASE.query = "AZIENDE_SelectAll_DDL";
        dt = DATABASE.EseguiSPRead();
        return dt;
    }

    /// <summary>
    /// il metodo SelectByKey della classe AZIENDE serve a selezionare la chiave dell'azienda selezionata nel database
    /// </summary>
    public DataTable SelectByKey()
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        DATABASE.query = "AZIENDE_SelectByKey";
        DATABASE.cmd.Parameters.AddWithValue("@chiave", chiave);
        dt = DATABASE.EseguiSPRead();
        return dt;
    }
}