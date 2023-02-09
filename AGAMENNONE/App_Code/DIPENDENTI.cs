using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

public class DIPENDENTI
{
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

    public DIPENDENTI()
    {

    }

    public void Abilita()
    {
        DATABASE.cmd.Parameters.Clear();
        //DATABASE DB = new DATABASE();
        DATABASE.query = "DIPENDENTI_Abilita";
        DATABASE.EseguiSPNonRead();
    } 
    
    public void Disabilita()
    {
        DATABASE.cmd.Parameters.Clear();
        //DATABASE DB = new DATABASE();
        DATABASE.query = "DIPENDENTI_Disabilita";
        DATABASE.EseguiSPNonRead();
    }

    public void Registra()
    {
        DATABASE.cmd.Parameters.Clear();
        //DATABASE DB = new DATABASE();
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

    public DataTable Login()
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        //DATABASE DB = new DATABASE();
        DATABASE.query = "DIPENDENTI_Login";
        DATABASE.cmd.Parameters.AddWithValue("email", email);
        DATABASE.cmd.Parameters.AddWithValue("password", password);
        dt = DATABASE.EseguiSPRead();
        return dt;
    }

    public void CambioPassword()
    {
        DATABASE.cmd.Parameters.Clear();
        //DATABASE DB = new DATABASE();
        DATABASE.query = "DIPENDENTI_CambioPassword";
        DATABASE.cmd.Parameters.AddWithValue("chiave", chiave);
        DATABASE.cmd.Parameters.AddWithValue("password", password);
        DATABASE.EseguiSPNonRead();
    }

     public DataTable EmailEsistente()
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        //DATABASE DB = new DATABASE();
        DATABASE.query = "DIPENDENTI_EmailEsistente";
        DATABASE.cmd.Parameters.AddWithValue("email", password);
        DATABASE.EseguiSPRead();
        return dt;
    }

    public void Insert()
    {
        DATABASE.cmd.Parameters.Clear();
        //DATABASE DB = new DATABASE();
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

    public void Update()
    {
        DATABASE.cmd.Parameters.Clear();
        //DATABASE DB = new DATABASE();
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

    public DataTable SelectAll()
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        //DATABASE DB = new DATABASE();
        DATABASE.query = "DIPENDENTI_SelectAll";     
        dt = DATABASE.EseguiSPRead();
        return dt;
    }

    public DataTable SelectAll_DDL()
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        //DATABASE DB = new DATABASE();
        DATABASE.query = "DIPENDENTI_SelectAll_DDL";
        dt = DATABASE.EseguiSPRead();
        return dt;
    }
    
    public DataTable SelectByKey()
    {
        DATABASE.cmd.Parameters.Clear();
        DataTable dt = new DataTable();
        //DATABASE DB = new DATABASE();
        DATABASE.query = "DIPENDENTI_SelectByKey";
        DATABASE.cmd.Parameters.AddWithValue("chiave", chiave);
        dt = DATABASE.EseguiSPRead();
        return dt;
    }
}