using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class REFERENTICOMMESSE
{
    public int chiave;
    public int chiaveReferente;
    public int chiaveCommessa;
    //DATABASE DB = new DATABASE();
    public REFERENTICOMMESSE()
    {

    }

    public void Insert()
    {
        DATABASE.cmd.CommandText = "REFERENTICOMMESSE_Insert";
        DATABASE.cmd.Parameters.AddWithValue("chiaveReferente", chiaveReferente);
        DATABASE.cmd.Parameters.AddWithValue("chiaveCommessa", chiaveCommessa);
        DATABASE.EseguiSPNonRead();
    }

    public void Delete()
    {
        DATABASE.cmd.CommandText = "REFERENTICOMMESSE_Delete";
        DATABASE.EseguiSPNonRead();
    }
}