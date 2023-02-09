using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_Registrati : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnRegistra_Click(object sender, EventArgs e)
    {
        //controllo che il testo non sia vuoto
        if (txtEmail.Text.Trim() == "")
        {
            ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('Campo email vuoto,pirla');", true);
            return;
        }

        DIPENDENTI D = new DIPENDENTI();
        D.email = txtEmail.Text.Trim();
        DataTable dt = new DataTable();
        dt = D.EmailEsistente();
        if (dt.Rows.Count != 0)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('L email è gia registrata');", true);
            return;
        }

        Random res = new Random();

        // String that contain both alphabets and numbers
        String str = "abcdefghijklmnopqrstuvwxyz0123456789";
        int size = 10;

        // Initializing the empty string
        String randomstring = "";

        for (int i = 0; i < size; i++)
        {
            // Selecting a index randomly
            int x = res.Next(str.Length);

            // Appending the character at the 
            // index to the random alphanumeric string.
            randomstring = randomstring + str[x];
        }

        //setup server per mail
        SmtpClient client = new SmtpClient();
        client.Credentials = new NetworkCredential("generation@brovia.it", "!Pr0secc0!");
        client.Port = 25;
        client.Host = "brovia.it";
        client.EnableSsl = false;

        //setup messaggio da inviare
        MailMessage mail = new MailMessage();
        mail.From = new MailAddress("diegodaggiano@gmail.com");
        mail.To.Add(txtEmail.Text.Trim());
        mail.IsBodyHtml = true;
        mail.Subject = "DATI LOGIN";
        mail.Body = "La tua email è " + txtEmail.Text.Trim() + "<br/>";
        mail.Body += "La tua password temporanea è " + randomstring + "<br/>";
        client.Send(mail);

        Crypt C = new Crypt();

        D.chiaveAzienda = int.Parse(ddlAzienda.SelectedValue);
        D.email = txtEmail.Text.Trim();
        D.password = C.Crypta(randomstring);               
        D.cognome = txtCognome.Text.Trim();
        D.nome = txtNome.Text.Trim();
        D.indirizzo = txtIndirizzo.Text.Trim();
        D.citta = txtCitta.Text.Trim();
        D.cap = txtCap.Text.Trim();
        D.provincia = txtProvincia.Text.Trim();
        D.telefono = txtTelefono.Text.Trim();

        D.Registra();
        Response.Redirect("Login.aspx");
    }
}