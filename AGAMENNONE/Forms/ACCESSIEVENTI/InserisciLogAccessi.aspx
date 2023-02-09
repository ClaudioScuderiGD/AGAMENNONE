<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InserisciLogAccessi.aspx.cs" Inherits="Forms_LOG_InserisciLogAccessi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <div class="container py-5 mt-5">
            <div class="row d-flex justify-content-center align-items-center" style="height: 25px; margin-bottom:5px; margin-top:-5px">
                <div class="col-md-12 text-center">
                    <center><h2>Inserisci i campi</h2></center>
                </div>
           </div>

           <div class="row" style="height: 30px">
                <div class="col-md-2" style="width: 45%; float: left;">
                    <label class="label" style="width: 15%">Dipendente:</label>
                </div>
                <div class="col-md-4" style="width: 50%; float: left;">
                    <asp:DropDownList ID="ddlDipendente" runat="server" Style="width: 100%; margin-left: -5px;" DataSourceID="sdsDDLDipendenti" DataTextField="DIPENDENTE" DataValueField="chiave"></asp:DropDownList>
                    <asp:SqlDataSource ID="sdsDDLDipendenti" runat="server" ConnectionString="<%$ ConnectionStrings:AGAMENNONEConnectionString %>" SelectCommand="DIPENDENTI_SelectAll_DDL" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
                </div>             
            </div>

            <div class="row" style="height: 30px">
                <center><div class="col-md-2 ml-3" style="width: 40%; float: left;">
                    <label class="label" style="width: 40%">Data e ora accesso:</label>
                </div>
                    
                <div class="col-md-5" style="width: 55%; float: left">
                    <asp:TextBox ID="txtDataOra" type="datetime-local" runat="server" Width="80%"></asp:TextBox>
                </div></center>
            </div>

            <div class="row" style="height: 30px">
                <center><div class="col-md-2" style="width: 20%; float: left;">
                    <label class="label" style="width: 20%">Evento:</label>
                </div>
                <div class="col-md-10" style="width: 59%; margin-right:-60px">
                    <asp:TextBox ID="txtEvento" runat="server" Width="100%" MaxLength="100"></asp:TextBox>
                </div></center>
            </div>
           
            <div class="row" style="height: 30px">
                <div class="col-md-12">
                    <center>
                        <asp:Button ID="btnSalva" runat="server" Text="Salva" Style="width: 30%; height: 25px" OnClick="btnSalva_Click" />
                    </center>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
