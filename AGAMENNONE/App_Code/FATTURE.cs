using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descrizione di riepilogo per FATTURE
/// </summary>
public class FATTURE
{
    //dichiarazione delle variabili
    public int chiave;
    public int chiaveCommessa;
    public string numerofattura;
    public string datafattura;
    public int importo;
    public int aliquota;
    public string descrizione;
    public string datasaldo;

    //dichiarazione del costruttore
    public FATTURE()
    {

    }

    /// <summary>
    /// il metodo Insert della classe FATTURE serve ad inserire nuove fatture nel database
    /// </summary>
    public void Insert()
    {
        DATABASE.cmd.Parameters.Clear();
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

    /// <summary>
    /// il metodo Update della classe FATTURE serve a modificare delle fatture nel database
    /// </summary>
    public void Update()
    {
        DATABASE.cmd.Parameters.Clear();
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

    /// <summary>
    /// il metodo SelectAll della classe FATTURE serve a leggere i campi delle fatture nel database
    /// </summary>
    public DataTable SelectAll()
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        DATABASE.query = "FATTURE_SelectAll";
        dt = DATABASE.EseguiSPRead();
        return dt;
    }

    /// <summary>
    /// il metodo SelectByDataSaldo della classe FATTURE serve a selezionare la data di saldo della fattura selezionata nel database
    /// </summary>
    public DataTable SelectByDataSaldo()
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        DATABASE.query = "FATTURE_SelectByDataSaldo";
        DATABASE.cmd.Parameters.AddWithValue("datasaldo", datasaldo);
        DATABASE.EseguiSPRead();
        return dt;
    }

    /// <summary>
    /// il metodo SelectByKey della classe FATTURE serve a selezionare la chiave della fattura selezionata nel database
    /// </summary>
    public DataTable SelectByKey()
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        DATABASE.query = "FATTURE_SelectByKey";
        DATABASE.cmd.Parameters.AddWithValue("chiave", chiave);
        DATABASE.EseguiSPRead();
        return dt;
    }  
    
    /// <summary>
    /// il metodo FATTURATOMENSILE della classe FATTURE serve a visualizzare il fatturato mensile di un anno selezionato all'interno del database
    /// </summary>    
    public DataTable FATTURATOMENSILE(string anno)
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        DATABASE.query = "FATTURATOMENSILE";
        DATABASE.cmd.Parameters.AddWithValue("anno", anno);
        DATABASE.EseguiSPRead();
        return dt;
    }

    /// <summary>
    /// il metodo SelectByMonth della classe FATTURE serve a selezionare il mese della fattura selezionata nel database
    /// </summary>
    public DataTable SelectByMonth(string anno)
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        DATABASE.query = "FATTURE_SelectByMomth";
        DATABASE.cmd.Parameters.AddWithValue("anno", anno);
        DATABASE.EseguiSPRead();
        return dt;
    }

    /// <summary>
    /// il metodo SelectByYear della classe FATTURE serve a selezionare l'anno della fattura selezionata nel database
    /// </summary>
    public DataTable SelectByYear(string anno)
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        DATABASE.query = "FATTURE_SelectByYear";
        DATABASE.cmd.Parameters.AddWithValue("anno", anno);
        DATABASE.EseguiSPRead();
        return dt;
    }

    /// <summary>
    /// il metodo SelectDate_Interval della classe FATTURE serve a leggere l'intervallo di date tra data d'inizio e data di fine di una fattura all'interno del database
    /// </summary>
    public DataTable SelectDate_Interval(string start, string end)
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        DATABASE.query = "FATTURE_SelectDate_Interval";
        DATABASE.cmd.Parameters.AddWithValue("startdate", start);
        DATABASE.cmd.Parameters.AddWithValue("enddate", end);
        DATABASE.EseguiSPRead();
        return dt;
    }
}