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
    //dichiarazione delle variabili
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

    //creazione del costruttore
    public CLIENTI()
    {
       
    }

    /// <summary>
    /// il metodo Insert della classe CLIENTI serve ad inserire nuovi clienti nel database
    /// </summary>
    public void Insert()
    {
        DATABASE.cmd.Parameters.Clear();
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

    /// <summary>
    /// il metodo Update della classe CLIENTI serve a modificare i clienti nel database
    /// </summary>
    public void Update()
    {
        DATABASE.cmd.Parameters.Clear();
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

    /// <summary>
    /// il metodo SelectAll della classe CLIENTI serve a leggere i campi dei clienti nel database
    /// </summary>
    public DataTable SelectAll()
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        DATABASE.query = "CLIENTI_SelectAll";
        dt = DATABASE.EseguiSPRead();
        return dt;
    }

    /// <summary>
    /// il metodo SelectAll_DDL della classe CLIENTI serve a selezionare la ragione sociale dei clienti nel database in una dropdown list
    /// </summary>
    public DataTable SelectAll_DDL()
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        DATABASE.query = "CLIENTI_SelectAll_DDL";
        dt = DATABASE.EseguiSPRead();
        return dt;
    }

    /// <summary>
    /// il metodo SelectByKey della classe CLIENTI serve a selezionare la chiave del cliente selezionato nel database
    /// </summary>
    public DataTable SelectByKey()
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        DATABASE.query = "CLIENTI_SelectByKey";
        DATABASE.cmd.Parameters.AddWithValue("@chiave", chiave);
        dt = DATABASE.EseguiSPRead();
        return dt;
    }
}