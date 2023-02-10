using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

/// <summary>
/// Descrizione di riepilogo per DIPENDENTI
/// </summary>
public class DIPENDENTI
{
    //dichiarazione delle variabili
    public int chiave;
    public int chiaveAzienda;
    public string email;
    public string password;
    public int abilitato;
    public int primoaccesso;
    public string ruolo;
    public string cognome;
    public string nome;
    public string indirizzo;
    public string citta;
    public string cap;
    public string provincia;
    public string telefono;
    public int costoorario;
    public string datainiziorapporto;
    public string datafinerapporto;

    //dichiarazione del costruttore
    public DIPENDENTI()
    {

    }

    /// <summary>
    /// il metodo Abilita della classe DIPENDENTI serve ad abilitare nuovi dipendenti nel database
    /// </summary>
    public void Abilita()
    {
        DATABASE.cmd.Parameters.Clear();
        DATABASE.query = "DIPENDENTI_Abilita";
        DATABASE.EseguiSPNonRead();
    }

    /// <summary>
    /// il metodo Abilita della classe DIPENDENTI serve ad disabilitare i dipendenti nel database
    /// </summary>
    public void Disabilita()
    {
        DATABASE.cmd.Parameters.Clear();
        DATABASE.query = "DIPENDENTI_Disabilita";
        DATABASE.EseguiSPNonRead();
    }

    /// <summary>
    /// il metodo Registra della classe DIPENDENTI serve ad registrare i dipendenti nel database
    /// </summary>
    public void Registra()
    {
        DATABASE.cmd.Parameters.Clear();
        DATABASE.query = "DIPENDENTI_Registra";
        DATABASE.cmd.Parameters.AddWithValue("chiaveAzienda", chiaveAzienda);
        DATABASE.cmd.Parameters.AddWithValue("email", email);
        DATABASE.cmd.Parameters.AddWithValue("password", password);
        DATABASE.cmd.Parameters.AddWithValue("cognome", cognome);
        DATABASE.cmd.Parameters.AddWithValue("nome", nome);
        DATABASE.cmd.Parameters.AddWithValue("indirizzo", indirizzo);
        DATABASE.cmd.Parameters.AddWithValue("citta", citta);
        DATABASE.cmd.Parameters.AddWithValue("cap", cap);
        DATABASE.cmd.Parameters.AddWithValue("provincia", provincia);
        DATABASE.cmd.Parameters.AddWithValue("telefono", telefono);
        DATABASE.EseguiSPNonRead();
    }

    /// <summary>
    /// il metodo Login della classe DIPENDENTI serve ad effettuare il login dei dipendenti nel database
    /// </summary>
    public DataTable Login()
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        DATABASE.query = "DIPENDENTI_Login";
        DATABASE.cmd.Parameters.AddWithValue("email", email);
        DATABASE.cmd.Parameters.AddWithValue("password", password);
        dt = DATABASE.EseguiSPRead();
        return dt;
    }

    /// <summary>
    /// il metodo CambioPassword della classe DIPENDENTI serve a cambiare la password temporanea dei dipendenti nel database
    /// </summary>
    public void CambioPassword()
    {
        DATABASE.cmd.Parameters.Clear();
        DATABASE.query = "DIPENDENTI_CambioPassword";
        DATABASE.cmd.Parameters.AddWithValue("chiave", chiave);
        DATABASE.cmd.Parameters.AddWithValue("password", password);
        DATABASE.EseguiSPNonRead();
    }

    /// <summary>
    /// il metodo EmailEsistente della classe DIPENDENTI serve a controllare se l'email del dipendente è presente nel database
    /// </summary>
    public DataTable EmailEsistente()
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        DATABASE.query = "DIPENDENTI_EmailEsistente";
        DATABASE.cmd.Parameters.AddWithValue("email", password);
        DATABASE.EseguiSPRead();
        return dt;
    }

    /// <summary>
    /// il metodo Insert della classe DIPENDENTI serve ad inserire nuovi dipendenti nel database
    /// </summary>
    public void Insert()
    {
        DATABASE.cmd.Parameters.Clear();
        DATABASE.query = "DIPENDENTI_Insert";
        DATABASE.cmd.Parameters.AddWithValue("email", email);
        DATABASE.cmd.Parameters.AddWithValue("password", password);
        DATABASE.cmd.Parameters.AddWithValue("abilitato", abilitato);
        DATABASE.cmd.Parameters.AddWithValue("primoaccesso", primoaccesso);
        DATABASE.cmd.Parameters.AddWithValue("ruolo", ruolo);
        DATABASE.cmd.Parameters.AddWithValue("cognome", cognome);
        DATABASE.cmd.Parameters.AddWithValue("nome", nome);
        DATABASE.cmd.Parameters.AddWithValue("indirizzo", indirizzo);
        DATABASE.cmd.Parameters.AddWithValue("citta", citta);
        DATABASE.cmd.Parameters.AddWithValue("cap", cap);
        DATABASE.cmd.Parameters.AddWithValue("provincia", provincia);
        DATABASE.cmd.Parameters.AddWithValue("telefono", telefono);
        DATABASE.cmd.Parameters.AddWithValue("costoorario", costoorario);
        DATABASE.cmd.Parameters.AddWithValue("datainiziorapporto", datainiziorapporto);
        DATABASE.cmd.Parameters.AddWithValue("datafinerapporto", datafinerapporto);
        DATABASE.EseguiSPNonRead();
    }

    /// <summary>
    /// il metodo Update della classe DIPENDENTI serve a modificare i dipendenti nel database
    /// </summary>
    public void Update()
    {
        DATABASE.cmd.Parameters.Clear();
        DATABASE.query = "DIPENDENTI_Update";
        DATABASE.cmd.Parameters.AddWithValue("chiave", chiave);
        DATABASE.cmd.Parameters.AddWithValue("email", email);
        DATABASE.cmd.Parameters.AddWithValue("password", password);
        DATABASE.cmd.Parameters.AddWithValue("abilitato", abilitato);
        DATABASE.cmd.Parameters.AddWithValue("primoaccesso", primoaccesso);
        DATABASE.cmd.Parameters.AddWithValue("ruolo", ruolo);
        DATABASE.cmd.Parameters.AddWithValue("cognome", cognome);
        DATABASE.cmd.Parameters.AddWithValue("nome", nome);
        DATABASE.cmd.Parameters.AddWithValue("indirizzo", indirizzo);
        DATABASE.cmd.Parameters.AddWithValue("citta", citta);
        DATABASE.cmd.Parameters.AddWithValue("cap", cap);
        DATABASE.cmd.Parameters.AddWithValue("provincia", provincia);
        DATABASE.cmd.Parameters.AddWithValue("telefono", telefono);
        DATABASE.cmd.Parameters.AddWithValue("costoorario", costoorario);
        DATABASE.cmd.Parameters.AddWithValue("datainiziorapporto", datainiziorapporto);
        DATABASE.cmd.Parameters.AddWithValue("datafinerapporto", datafinerapporto);
        DATABASE.EseguiSPNonRead();
    }

    /// <summary>
    /// il metodo SelectAll della classe DIPENDENTI serve a leggere i campi dei clienti nel database
    /// </summary>
    public DataTable SelectAll()
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        DATABASE.query = "DIPENDENTI_SelectAll";     
        dt = DATABASE.EseguiSPRead();
        return dt;
    }

    /// <summary>
    /// il metodo SelectAll_DDL della classe DIPENDENTI serve a selezionare il nome, il cognome e l'email del dipendente nel database in una dropdown list
    /// </summary>
    public DataTable SelectAll_DDL()
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        DATABASE.query = "DIPENDENTI_SelectAll_DDL";
        dt = DATABASE.EseguiSPRead();
        return dt;
    }

    /// <summary>
    /// il metodo SelectByKey della classe DIPENDENTI serve a selezionare la chiave del dipendente selezionato nel database
    /// </summary>
    public DataTable SelectByKey()
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        DATABASE.query = "DIPENDENTI_SelectByKey";
        DATABASE.cmd.Parameters.AddWithValue("chiave", chiave);
        dt = DATABASE.EseguiSPRead();
        return dt;
    }

    /// <summary>
    /// il metodo FatturatoDIPENDENTE della classe DIPENDENTI serve a calcolare il costo del dipendente per le sue ore lavorative
    /// </summary>
    public DataTable FatturatoDIPENDENTE(string dipendente)
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        //DATABASE DB = new DATABASE();
        DATABASE.query = "FATTURATODIPENDENTE";
        DATABASE.cmd.Parameters.AddWithValue("cognome", dipendente);
        dt = DATABASE.EseguiSPRead();
        return dt;
    }
}