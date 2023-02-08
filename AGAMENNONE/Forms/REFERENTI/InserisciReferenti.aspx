<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InserisciReferenti.aspx.cs" Inherits="Forms_REFERENTI_InserisciReferenti" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container py-5 mt-5">            <div class="row d-flex justify-content-center align-items-center" style="height: 25px; margin-bottom:13px; margin-top:-11px">                <div class="col-md-12 text-center">                    <center><h2>Inserisci i campi</h2></center>                </div>           </div>            <div class="row" style="height: 30px">                <div class="col-md-2" style="width: 20%; float: left;">                    <label class="label" style="width: 20%">Nome:</label>                </div>                                    <div class="col-md-4" style="width: 30%; float: left">                    <asp:TextBox ID="txtNome" runat="server" Width="80%" MaxLength="50"></asp:TextBox>                </div>                <div class="col-md-2" style="width: 20%; float: left;">                    <label class="label" style="width: 40%">Cognome:</label>                </div>                                    <div class="col-md-4" style="width: 30%; float: left">                    <asp:TextBox ID="txtCognome" runat="server" Width="80%" MaxLength="50"></asp:TextBox>                </div>            </div>            <div class="row" style="height: 30px">                <div class="col-md-2" style="width: 20%; float: left;">                    <label class="label" style="width: 20%">E-mail:</label>                </div>                                    <div class="col-md-4" style="width: 30%; float: left">                    <asp:TextBox ID="txtEmail" runat="server" Width="80%" MaxLength="50"></asp:TextBox>                </div>                <div class="col-md-2" style="width: 20%; float: left;">                    <label class="label" style="width: 40%">Telefono:</label>                </div>                                    <div class="col-md-4" style="width: 30%; float: left">                    <asp:TextBox ID="txtTelefono" runat="server" Width="80%" MaxLength="50"></asp:TextBox>                </div>            </div>                    <div class="row" style="height: 30px">                <div class="col-md-12">                    <center>                        <asp:Button ID="btnSalva" runat="server" Text="Salva" Style="width: 30%; height: 25px" />                    </center>                </div>            </div>        </div>
    </form>
</body>
</html>
