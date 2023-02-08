<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InserisciFattura.aspx.cs" Inherits="Forms_FATTURE_InserisciFattura" %>

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
                <div class="col-md-2" style="width: 30%; float: left;">
                    <label class="label" style="width: 30%">Numero Fattura:</label>
                </div>
                <div class="col-md-10">
                    <asp:TextBox ID="txtNumFattura" runat="server" Width="65%" MaxLength="10"></asp:TextBox>
                </div>
            </div>
        
            <div class="row" style="height: 30px">
                <div class="col-md-2" style="width: 20%; float: left;">
                    <label class="label" style="width: 15%">Data Fattura:</label>
                </div>
                <div class="col-md-4" style="width: 25%; float: left;">
                    <asp:TextBox ID="txtDataFattura" type="date" runat="server" Style="width: 100%; margin-left: -15px;"></asp:TextBox>
                </div>

                <div class="col-md-2" style="width: 20%; float: left;">
                    <label class="label" style="width: 15%;">Data Saldo:</label>
                </div>
                <div class="col-md-4" style="width: 30%; float: left;">
                    <asp:TextBox ID="txtDataSaldo" type="date" runat="server" Style="width: 100%;"></asp:TextBox>
                </div>
            </div>

            <div class="row" style="height: 30px">
                <div class="col-md-2" style="width: 20%; float: left;">
                    <label class="label" style="width: 15%">Importo:</label>
                </div>
                <div class="col-md-4" style="width: 25%; float: left;">
                    <asp:TextBox ID="txtImporto" runat="server" Style="width: 100%; margin-left: -15px;"></asp:TextBox>
                </div>

                <div class="col-md-2" style="width: 20%; float: left;">
                    <label class="label" style="width: 15%;">Aliquota:</label>
                </div>
                <div class="col-md-4" style="width: 30%; float: left;">
                    <asp:TextBox ID="txtAliquota" runat="server" Style="width: 100%;"></asp:TextBox>
                </div>
            </div>

            <div class="row" style="height: 50px">
                <div class="col-md-2" style="width: 30%; float: left;">
                    <label class="label" style="width: 30%">Descrizione:</label>
                </div>
                <div class="col-md-10">
                    <asp:TextBox ID="txtDescrizione" runat="server" Width="65%" TextMode="MultiLine" MaxLength="300"></asp:TextBox>
                </div>
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
