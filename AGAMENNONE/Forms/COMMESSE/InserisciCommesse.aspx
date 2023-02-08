<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InserisciCommesse.aspx.cs" Inherits="Forms_COMMESSE_InserisciCommesse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container py-5 mt-5">
            <div class="row d-flex justify-content-center align-items-center" style="height: 25px; margin-bottom: 5px; margin-top: -5px">
                <div class="col-md-12 text-center">
                    <center>
                        <h2>Inserisci i campi</h2>
                    </center>
                </div>
            </div>

            
            <div class="row" style="height: 30px">
                <div class="col-md-2" style="width: 20%; float: left;">
                    <label class="label" style="width: 15%">Data apertura:</label>
                </div>
                <div class="col-md-4" style="width: 25%; float: left;">
                    <asp:TextBox ID="txtDataApertura"  runat="server" Style="width: 100%; margin-left: -5px;" TextMode="Date"></asp:TextBox>
                </div>

                <div class="col-md-2" style="width: 20%; float: left; margin-left: 5px;">
                    <label class="label" style="width: 15%;">Data chiusura:</label>
                </div>
                <div class="col-md-4" style="width: 25%; float: left;">
                    <asp:TextBox ID="txtDataChiusura"  runat="server" Style="width: 100%;" TextMode="Date"></asp:TextBox>
                </div>
            </div>

            <div class="row" style="height: 30px">
                <div class="col-md-2" style="width: 20%; float: left;">
                    <label class="label" style="width: 15%">Data consegna:</label>
                </div>
                <div class="col-md-4" style="width: 25%; float: left;">
                    <asp:TextBox ID="txtDataConsegna" runat="server" Style="width: 100%; margin-left: -5px;" TextMode="Date"></asp:TextBox>
                </div>

                <div class="col-md-2" style="width: 20%; float: left;margin-left: 5px;">
                    <label class="label" style="width: 15%;">Corpo/Ora:</label>
                </div>
                <div class="col-md-4" style="width: 25%; float: left;">
                    <asp:TextBox ID="txtCorpoOra" runat="server" Style="width: 100%;" MaxLength="1"></asp:TextBox>
                </div>
            </div>
            <div class="row" style="height: 30px">                <div class="col-md-2" style="width: 20%; float: left;">                    <label class="label" style="width: 15%">Importo corpo:</label>                </div>                <div class="col-md-4" style="width: 25%; float: left;">                    <asp:TextBox ID="txtImportoCorpo" runat="server" Style="width: 100%; margin-left: -5px;"></asp:TextBox>                </div>                <div class="col-md-2" style="width: 20%; float: left;margin-left: 5px;">                    <label class="label" style="width: 15%;">Importo orario:</label>                </div>                <div class="col-md-4" style="width: 25%; float: left;">                    <asp:TextBox ID="txtImportoOrario" runat="server" Style="width: 100%;"></asp:TextBox>                </div>            </div>
            <div class="row" style="height: 30px">
                <div class="col-md-2" style="width: 20%; float: left;">
                    <label class="label" style="width: 15%">Anticipo:</label>
                </div>
                <div class="col-md-4" style="width: 25%; float: left;">
                    <asp:TextBox ID="txtAnticipo" runat="server" Style="width: 100%; margin-left: -5px;"></asp:TextBox>
                </div>

                <div class="col-md-2" style="width: 20%; float: left;margin-left: 5px;">
                    <label class="label" style="width: 15%;">Pernottamento:</label>
                </div>
                <div class="col-md-4" style="width: 25%; float: left;">
                    <asp:TextBox ID="txtPernottamento" runat="server" Style="width: 100%;"></asp:TextBox>
                </div>
            </div>

            <div class="row" style="height: 30px">
                <div class="col-md-2" style="width: 20%; float: left;">
                    <label class="label" style="width: 15%">Pasto:</label>
                </div>
                <div class="col-md-4" style="width: 25%; float: left;">
                    <asp:TextBox ID="txtPasto" runat="server" Style="width: 100%; margin-left: -5px;"></asp:TextBox>
                </div>

                <div class="col-md-2" style="width: 20%; float: left;margin-left: 5px;">
                    <label class="label" style="width: 15%;">KM:</label>
                </div>
                <div class="col-md-4" style="width: 25%; float: left;">
                    <asp:TextBox ID="txtKM" runat="server" Style="width: 100%;"></asp:TextBox>
                </div>
            </div>

            <div class="row" style="height: 30px">
                <div class="col-md-2" style="width: 20%; float: left;">
                    <label class="label" style="width: 15%">Pedaggi:</label>
                </div>
                <div class="col-md-4" style="width: 25%; float: left;">
                    <asp:TextBox ID="txtPedaggi" runat="server" Style="width: 100%; margin-left: -5px;"></asp:TextBox>
                </div>

                <div class="col-md-2" style="width: 20%; float: left;margin-left: 5px;">
                    <label class="label" style="width: 15%;">Mezzi:</label>
                </div>
                <div class="col-md-4" style="width: 25%; float: left;">
                    <asp:TextBox ID="txtMezzi" runat="server" Style="width: 100%;"></asp:TextBox>
                </div>
            </div>

            <div class="row" style="height: 50px">
                <div class="col-md-2" style="width: 30%; float: left;">
                    <label class="label" style="width: 30%">Descrizione:</label>
                </div>
                <div class="col-md-10">
                    <asp:TextBox ID="txtDescrizione" runat="server" Style="width: 72%; margin-left: -58px; " TextMode="MultiLine" MaxLength="300"></asp:TextBox>
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
