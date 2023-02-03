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
        DATABASE DB = new DATABASE();
        DB.query = "DIPENDENTI_Abilita";
        DB.EseguiSPNonRead();
    } 
    
    public void Disabilita()
    {
        DATABASE DB = new DATABASE();
        DB.query = "DIPENDENTI_Disabilita";
        DB.EseguiSPNonRead();
    }

    public void Registra()
    {
        DATABASE DB = new DATABASE();
        DB.query = "DIPENDENTI_Registra";
        DB.cmd.Parameters.AddWithValue("email", email);
        DB.cmd.Parameters.AddWithValue("password", password);
        DB.cmd.Parameters.AddWithValue("cognome", cognome);
        DB.cmd.Parameters.AddWithValue("nome", nome);
        DB.cmd.Parameters.AddWithValue("indirizzo", indirizzo);
        DB.cmd.Parameters.AddWithValue("citta", citta);
        DB.cmd.Parameters.AddWithValue("cap", cap);
        DB.cmd.Parameters.AddWithValue("provincia", provincia);
        DB.cmd.Parameters.AddWithValue("telefono", telefono);
        DB.EseguiSPNonRead();
    }

    public DataTable Login()
    {
        DataTable dt = new DataTable();
        DATABASE DB = new DATABASE();
        DB.query = "DIPENDENTI_Login";
        DB.cmd.Parameters.AddWithValue("email", email);
        DB.cmd.Parameters.AddWithValue("password", password);
        dt = DB.EseguiSPRead();
        return dt;
    }

    public void CambioPassword()
    {
        DATABASE DB = new DATABASE();
        DB.query = "DIPENDENTI_CambioPassword";
        DB.cmd.Parameters.AddWithValue("chiave", chiave);
        DB.cmd.Parameters.AddWithValue("password", password);
        DB.EseguiSPNonRead();
    }

    public void Insert()
    {
        DATABASE DB = new DATABASE();
        DB.query = "DIPENDENTI_Insert";
        DB.cmd.Parameters.AddWithValue("email", email);
        DB.cmd.Parameters.AddWithValue("password", password);
        DB.cmd.Parameters.AddWithValue("abilitato", abilitato);
        DB.cmd.Parameters.AddWithValue("primoaccesso", primoaccesso);
        DB.cmd.Parameters.AddWithValue("ruolo", ruolo);
        DB.cmd.Parameters.AddWithValue("cognome", cognome);
        DB.cmd.Parameters.AddWithValue("nome", nome);
        DB.cmd.Parameters.AddWithValue("indirizzo", indirizzo);
        DB.cmd.Parameters.AddWithValue("citta", citta);
        DB.cmd.Parameters.AddWithValue("cap", cap);
        DB.cmd.Parameters.AddWithValue("provincia", provincia);
        DB.cmd.Parameters.AddWithValue("telefono", telefono);
        DB.cmd.Parameters.AddWithValue("costoorario", costoorario);
        DB.cmd.Parameters.AddWithValue("datainiziorapporto", datainiziorapporto);
        DB.cmd.Parameters.AddWithValue("datafinerapporto", datafinerapporto);
        DB.EseguiSPNonRead();
    }

    public void Update()
    {
        DATABASE DB = new DATABASE();
        DB.query = "DIPENDENTI_Update";
        DB.cmd.Parameters.AddWithValue("chiave", chiave);
        DB.cmd.Parameters.AddWithValue("email", email);
        DB.cmd.Parameters.AddWithValue("password", password);
        DB.cmd.Parameters.AddWithValue("abilitato", abilitato);
        DB.cmd.Parameters.AddWithValue("primoaccesso", primoaccesso);
        DB.cmd.Parameters.AddWithValue("ruolo", ruolo);
        DB.cmd.Parameters.AddWithValue("cognome", cognome);
        DB.cmd.Parameters.AddWithValue("nome", nome);
        DB.cmd.Parameters.AddWithValue("indirizzo", indirizzo);
        DB.cmd.Parameters.AddWithValue("citta", citta);
        DB.cmd.Parameters.AddWithValue("cap", cap);
        DB.cmd.Parameters.AddWithValue("provincia", provincia);
        DB.cmd.Parameters.AddWithValue("telefono", telefono);
        DB.cmd.Parameters.AddWithValue("costoorario", costoorario);
        DB.cmd.Parameters.AddWithValue("datainiziorapporto", datainiziorapporto);
        DB.cmd.Parameters.AddWithValue("datafinerapporto", datafinerapporto);
        DB.EseguiSPNonRead();
    }

    public DataTable SelectAll()
    {
        DataTable dt = new DataTable();
        DATABASE DB = new DATABASE();
        DB.query = "DIPENDENTI_SelectAll";     
        dt = DB.EseguiSPRead();
        return dt;
    }

    public DataTable SelectAll_DDL()
    {
        DataTable dt = new DataTable();
        DATABASE DB = new DATABASE();
        DB.query = "DIPENDENTI_SelectAll_DDL";
        dt = DB.EseguiSPRead();
        return dt;
    }
    
    public DataTable SelectByKey()
    {
        DataTable dt = new DataTable();
        DATABASE DB = new DATABASE();
        DB.query = "DIPENDENTI_SelectByKey";
        DB.cmd.Parameters.AddWithValue("chiave", chiave);
        dt = DB.EseguiSPRead();
        return dt;
    }
}