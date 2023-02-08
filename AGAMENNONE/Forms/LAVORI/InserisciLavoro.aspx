﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InserisciLavoro.aspx.cs" Inherits="Forms_LAVORI_InserisciLavoro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
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
                    <label class="label" style="width: 15%">Data e Ora:</label>
                </div>
                <div class="col-md-4" style="width: 25%; float: left;">
                    <asp:TextBox ID="txtDataOra" runat="server" Style="width: 100%; margin-left: -5px;" TextMode="DateTime"></asp:TextBox>
                </div>
                <div class="col-md-2" style="width: 20%; float: left; margin-left: 5px;">
                    <label class="label" style="width: 15%;">Ore:</label>
                </div>
                <div class="col-md-4" style="width: 25%; float: left;">
                    <asp:TextBox ID="txtOre" runat="server" Style="width: 100%;"></asp:TextBox>
                </div>
            </div>
            <div class="row" style="height: 50px">
                <div class="col-md-2" style="width: 30%; float: left;">
                    <label class="label" style="width: 30%">Descrizione:</label>
                </div>
                <div class="col-md-10">
                    <asp:TextBox ID="txtDescrizione" runat="server" Style="width: 72%; margin-left: -58px;" TextMode="MultiLine" MaxLength="300"></asp:TextBox>
                </div>
            </div>
            <div class="row" style="height: 30px">
                <div class="col-md-2" style="width: 20%; float: left;">
                    <label class="label" style="width: 15%">Importo corpo:</label>
                </div>
                <div class="col-md-4" style="width: 25%; float: left;">
                    <asp:TextBox ID="txtImportoCorpo" runat="server" Style="width: 100%; margin-left: -5px;"></asp:TextBox>
                </div>
                <div class="col-md-2" style="width: 20%; float: left; margin-left: 5px;">
                    <label class="label" style="width: 15%;">Importo orario:</label>
                </div>
                <div class="col-md-4" style="width: 25%; float: left;">
                    <asp:TextBox ID="txtImportoOrario" runat="server" Style="width: 100%;"></asp:TextBox>
                </div>
            </div>
            <div class="row" style="height: 30px">
                <div class="col-md-2" style="width: 20%; float: left;">
                    <label class="label" style="width: 15%;">Pernottamento:</label>
                </div>
                <div class="col-md-4" style="width: 25%; float: left;">
                    <asp:TextBox ID="txtPernottamento" runat="server" Style="width: 100%; margin-left: -5px;"></asp:TextBox>
                </div>
                <div class="col-md-2" style="width: 20%; float: left; margin-left: 5px;">
                    <label class="label" style="width: 15%">Pasto:</label>
                </div>
                <div class="col-md-4" style="width: 25%; float: left;">
                    <asp:TextBox ID="txtPasto" runat="server" Style="width: 100%; margin-left: 0px;"></asp:TextBox>
                </div>
            </div>
            <div class="row" style="height: 30px">
                <div class="col-md-2" style="width: 20%; float: left;">
                    <label class="label" style="width: 15%;">KM:</label>
                </div>
                <div class="col-md-4" style="width: 25%; float: left;">
                    <asp:TextBox ID="txtKM" runat="server" Style="width: 100%; margin-left: -5px;"></asp:TextBox>
                </div>
                <div class="col-md-2" style="width: 20%; float: left; margin-left: 5px;">
                    <label class="label" style="width: 15%">Pedaggi:</label>
                </div>
                <div class="col-md-4" style="width: 25%; float: left;">
                    <asp:TextBox ID="txtPedaggi" runat="server" Style="width: 100%; margin-left: 0px;"></asp:TextBox>
                </div>
            </div>
            <div class="row" style="height: 30px">
                <div class="col-md-2" style="width: 20%; float: left;">
                    <label class="label" style="width: 15%;">Mezzi:</label>
                </div>
                <div class="col-md-4" style="width: 25%; float: left;">
                    <asp:TextBox ID="txtMezzi" runat="server" Style="width: 100%; margin-left: -5px;"></asp:TextBox>
                </div>
                <div class="col-md-2" style="width: 20%; float: left; margin-left: 5px;">
                    <label class="label" style="width: 15%">Spese extra:</label>
                </div>
                <div class="col-md-4" style="width: 25%; float: left;">
                    <asp:TextBox ID="txtSpeseExtra" runat="server" Style="width: 100%; margin-left: 0px;"></asp:TextBox>
                </div>
            </div>
            <div class="row" style="height: 50px">
                <div class="col-md-2" style="width: 30%; float: left;">
                    <label class="label" style="width: 30%">Descrizione spese extra:</label>
                </div>
                <div class="col-md-10">
                    <asp:TextBox ID="txtDescrizioneSpeseExtra" runat="server" Style="width: 61%; margin-left: 0px;" TextMode="MultiLine" MaxLength="300"></asp:TextBox>
                </div>
            </div>
            <div>
                <asp:Label ID="Label1" runat="server" Text="Necessaria accettazione spese extra da parte dell'admin"></asp:Label>
                <asp:CheckBox ID="CheckBox1" runat="server" />
            </div>
            <div class="row" style="height: 30px">
                <div class="col-md-12">
                    <center>
                        <asp:Button ID="btnSalva" runat="server" Text="Salva" Style="width: 30%; height: 25px" />
                    </center>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
