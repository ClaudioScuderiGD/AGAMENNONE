using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class REFERENTICOMMESSE
{
    public int chiave;
    public int chiaveReferente;
    public int chiaveCommessa;
    DATABASE DB = new DATABASE();
    public REFERENTICOMMESSE()
    {

    }

    public void Insert()
    {
        DB.cmd.CommandText = "REFERENTICOMMESSE_Insert";
        DB.cmd.Parameters.AddWithValue("chiaveReferente", chiaveReferente);
        DB.cmd.Parameters.AddWithValue("chiaveCommessa", chiaveCommessa);
        DB.EseguiSPNonRead();
    }

    public void Delete()
    {
        DB.cmd.CommandText = "REFERENTICOMMESSE_Delete";
        DB.EseguiSPNonRead();
    }
}