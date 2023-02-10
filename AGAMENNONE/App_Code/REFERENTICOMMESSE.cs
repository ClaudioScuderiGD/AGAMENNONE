using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrizione di riepilogo per REFERENTICOMMESSE
/// </summary>
public class REFERENTICOMMESSE
{
    //dichiarazione delle variabili
    public int chiave;
    public int chiaveReferente;
    public int chiaveCommessa;

    //dichiarazione del costruttore
    public REFERENTICOMMESSE()
    {

    }

    /// <summary>
    /// il metodo Insert della classe REFERENTICOMMESSE serve ad inserire nuovi referenti associati alle commesse nel database
    /// </summary>
    public void Insert()
    {
        DATABASE.cmd.Parameters.Clear();
        DATABASE.cmd.CommandText = "REFERENTICOMMESSE_Insert";
        DATABASE.cmd.Parameters.AddWithValue("chiaveReferente", chiaveReferente);
        DATABASE.cmd.Parameters.AddWithValue("chiaveCommessa", chiaveCommessa);
        DATABASE.EseguiSPNonRead();
    }

    /// <summary>
    /// il metodo Delete della classe REFERENTICOMMESSE serve ad eliminare i referenti associati alle commesse nel database
    /// </summary>
    public void Delete()
    {
        DATABASE.cmd.Parameters.Clear();
        DATABASE.cmd.CommandText = "REFERENTICOMMESSE_Delete";
        DATABASE.EseguiSPNonRead();
    }
}