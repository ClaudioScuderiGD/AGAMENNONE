<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ModificaDipendente.aspx.cs" Inherits="Forms_DIPENDENTI_ModificaDipendente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
          <div class="container py-5 mt-5">
            <div class="row d-flex justify-content-center align-items-center" style="height: 25px; margin-bottom: 15px; margin-top: -5px">
                <div class="col-md-12 text-center">
                    <center>
                        <h2>Modifica i campi</h2>
                    </center>
                </div>
            </div>

            <div class="row" style="height: 30px">
                <div class="col-md-2" style="width: 20%; float: left;">
                    <label class="label" style="width: 15%">Email:</label>
                </div>
                <div class="col-md-4" style="width: 25%; float: left;">
                    <asp:TextBox ID="txtEmail" runat="server" Style="width: 100%; margin-left: -15px;" MaxLength="50"></asp:TextBox>
                </div>

                <div class="col-md-2" style="width: 20%; float: left;">
                    <label class="label" style="width: 15%;">Password:</label>
                </div>
                <div class="col-md-4" style="width: 30%; float: left;">
                    <asp:TextBox ID="txtPassword" runat="server" Style="width: 100%;" MaxLength="50"></asp:TextBox>
                </div>
            </div>


            <div class="row" style="height: 30px">
                <div class="col-md-2" style="width: 20%; float: left;">
                    <label class="label" style="width: 15%">Abilitato:</label>
                </div>
                <div class="col-md-3" style="width: 8%; float: left;">
                    <asp:TextBox ID="txtAbilitato" runat="server" Style="width: 47%; margin-left: -15px;"></asp:TextBox>
                </div>
                <div class="col-md-2" style="width: 20%; float: left;">
                    <label class="label" style="width: 15%">Primo accesso:</label>
                </div>
                <div class="col-md-3" style="width: 8%; float: left;">
                    <asp:TextBox ID="txtPrimoAccesso" runat="server" Style="width: 47%; margin-left: -15px;"></asp:TextBox>
                </div>
                <div class="col-md-2" style="width: 15%; float: left;">
                    <label class="label" style="width: 15%; margin-left: 5px;">Ruolo:</label>
                </div>
                <div class="col-md-2" style="width: 8%; float: left;">
                    <asp:TextBox ID="txtRuolo" runat="server" Style="width: 47%; margin-left: -10px;" MaxLength="1"></asp:TextBox>
                </div>
            </div>


            <%--COGNOME E NOME--%>
            <div class="row" style="height: 30px">
                <div class="col-md-2" style="width: 20%; float: left;">
                    <label class="label" style="width: 15%">Cognome:</label>
                </div>
                <div class="col-md-4" style="width: 25%; float: left;">
                    <asp:TextBox ID="txtCognome" runat="server" Style="width: 100%; margin-left: -15px;" MaxLength="50"></asp:TextBox>
                </div>

                <div class="col-md-2" style="width: 20%; float: left;">
                    <label class="label" style="width: 15%;">Nome:</label>
                </div>
                <div class="col-md-4" style="width: 30%; float: left;">
                    <asp:TextBox ID="txtNome" runat="server" Style="width: 100%;" MaxLength="50"></asp:TextBox>
                </div>
            </div>
            <%--INDIRIZZO E CITTA--%>
            <div class="row" style="height: 30px">
                <div class="col-md-2" style="width: 20%; float: left;">
                    <label class="label" style="width: 15%">Indirizzo:</label>
                </div>
                <div class="col-md-4" style="width: 25%; float: left;">
                    <asp:TextBox ID="txtIndirizzo" runat="server" Style="width: 100%; margin-left: -15px;" MaxLength="50"></asp:TextBox>
                </div>

                <div class="col-md-2" style="width: 20%; float: left;">
                    <label class="label" style="width: 15%;">Città:</label>
                </div>
                <div class="col-md-4" style="width: 30%; float: left;">
                    <asp:TextBox ID="txtCitta" runat="server" Style="width: 100%;" MaxLength="50"></asp:TextBox>
                </div>
            </div>

            <%--CAP PROVINCIA--%>

            <div class="row" style="height: 30px">
                <div class="col-md-2" style="width: 20%; float: left;">
                    <label class="label" style="width: 15%">CAP:</label>
                </div>
                <div class="col-md-4" style="width: 25%; float: left;">
                    <asp:TextBox ID="txtCap" runat="server" Style="width: 100%; margin-left: -15px;" MaxLength="5"></asp:TextBox>
                </div>

                <div class="col-md-2" style="width: 20%; float: left;">
                    <label class="label" style="width: 15%;">Provincia:</label>
                </div>
                <div class="col-md-4" style="width: 30%; float: left;">
                    <asp:TextBox ID="txtProvincia" runat="server" Style="width: 100%;" MaxLength="2"></asp:TextBox>
                </div>
            </div>



            <div class="row" style="height: 30px">
                <div class="col-md-2" style="width: 30%; float: left;">
                    <label class="label" style="width: 30%">Telefono:</label>
                </div>
                <div class="col-md-10">
                    <asp:TextBox ID="txtTelefono" runat="server" Width="65%" MaxLength="50"></asp:TextBox>
                </div>
            </div>

            <div class="row" style="height: 30px">
                <div class="col-md-2" style="width: 30%; float: left;">
                    <label class="label" style="width: 30%">Costo Orario:</label>
                </div>
                <div class="col-md-10">
                    <asp:TextBox ID="txtCostoOrario" runat="server" Width="65%"></asp:TextBox>
                </div>
            </div>


            <%--DATA INIZIO  E FINE RAPPORTO--%>

            <div class="row" style="height: 30px">
                <div class="col-md-2" style="width: 20%; float: left;">
                    <label class="label" style="width: 15%">Data inizio:</label>
                </div>
                <div class="col-md-4" style="width: 25%; float: left;">
                    <asp:TextBox ID="txtDataApertura" runat="server" Style="width: 100%; margin-left: -10px;" TextMode="Date"></asp:TextBox>
                </div>
                <div class="col-md-2" style="width: 20%; float: left; margin-left: 5px;">
                    <label class="label" style="width: 15%;">Data fine:</label>
                </div>
                <div class="col-md-4" style="width: 25%; float: left;">
                    <asp:TextBox ID="txtDataChiusura" runat="server" Style="width: 100%;" TextMode="Date"></asp:TextBox>
                </div>
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
