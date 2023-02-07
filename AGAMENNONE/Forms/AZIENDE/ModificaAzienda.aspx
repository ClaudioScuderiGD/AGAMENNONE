﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ModificaAzienda.aspx.cs" Inherits="Forms_ModificaAzienda" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div class="container py-5 mt-5">
            <div class="row d-flex justify-content-center align-items-center" style="height: 25px; margin-bottom:5px; margin-top:-5px">
                <div class="col-md-12 text-center">
                    <center><h2>Modifica i campi</h2></center>
                </div>
            </div>
            <div class="row" style="height: 30px">

                <div class="col-md-2" style="width: 30%; float: left;">
                    <label class="label" style="width: 30%">Ragione sociale:</label>
                </div>
                <div class="col-md-10">
                    <asp:TextBox ID="txtRagione" runat="server" Width="65%"></asp:TextBox>
                </div>
            </div>

            <div class="row" style="height: 30px">
                <div class="col-md-2" style="width: 30%; float: left;">
                    <label class="label" style="width: 30%">Indirizzo:</label>
                </div>
                <div class="col-md-10">
                    <asp:TextBox ID="txtIndirizzo" runat="server" Width="65%"></asp:TextBox>
                </div>
            </div>

            <div class="row" style="height: 30px">
                <div class="col-lg-2" style="width: 15%; float: left;">
                    <label class="label" style="width: 15%">Città:</label>
                </div>
                <div class="col-lg-3" style="width: 25%; float: left;">
                    <asp:TextBox ID="txtCitta" runat="server" Style="width: 100%; margin-left: -15px;"></asp:TextBox>
                </div>
                <div class="col-lg-2" style="width: 15%; float: left; margin-left: 20px;">
                    <label class="label" style="width: 15%; margin-left: -20px;">Provincia:</label>
                </div>
                <div class="col-lg-1" style="width: 8%; float: left;">
                    <asp:TextBox ID="txtProvincia" runat="server" Style="width: 75%; margin-left: -5px;"></asp:TextBox>
                </div>
                <div class="col-lg-2" style="width: 15%; float: left;">
                    <label class="label" style="width: 15%; margin-left: 5px;">CAP:</label>
                </div>
                <div class="col-lg-2" style="width: 15%; float: left;">
                    <asp:TextBox ID="txtCap" runat="server" Style="width: 97%; margin-left: -10px;"></asp:TextBox>
                </div>
            </div>


            <div class="row" style="height: 30px">
                <div class="col-md-2" style="width: 30%; float: left;">
                    <label class="label" style="width: 30%">Email:</label>
                </div>
                <div class="col-md-10">
                    <asp:TextBox ID="txtEmail" runat="server" Width="65%"></asp:TextBox>
                </div>
            </div>

            <div class="row" style="height: 30px">
                <div class="col-lg-2" style="width: 20%; float: left;">
                    <label class="label" style="width: 15%">Telefono:</label>
                </div>
                <div class="col-lg-4" style="width: 25%; float: left;">
                    <asp:TextBox ID="txtTelefono" runat="server" Style="width: 100%; margin-left: -15px;"></asp:TextBox>
                </div>

                <div class="col-lg-2" style="width: 20%; float: left;">
                    <label class="label" style="width: 15%;">Cod Fiscale:</label>
                </div>
                <div class="col-lg-4" style="width: 30%; float: left;">
                    <asp:TextBox ID="txtCodiceFiscale" runat="server" Style="width: 100%;"></asp:TextBox>
                </div>
            </div>

            <div class="row" style="height: 30px">
                <div class="col-lg-2" style="width: 20%; float: left;">
                    <label class="label" style="width: 15%">CFE:</label>
                </div>
                <div class="col-lg-4" style="width: 25%; float: left;">
                    <asp:TextBox ID="txtPartitaIVA" runat="server" Style="width: 100%; margin-left: -15px;"></asp:TextBox>
                </div>

                <div class="col-lg-2" style="width: 20%; float: left;">
                    <label class="label" style="width: 15%;">Partita IVA:</label>
                </div>
                <div class="col-lg-4" style="width: 30%; float: left;">
                    <asp:TextBox ID="txtCFE" runat="server" Style="width: 100%;"></asp:TextBox>
                </div>
            </div>

            <div class="row" style="height: 30px">
                <div class="col-md-2" style="width: 30%; float: left;">
                    <label class="label" style="width: 30%">PEC:</label>
                </div>
                <div class="col-md-10">
                    <asp:TextBox ID="txtPEC" runat="server" Width="65%"></asp:TextBox>
                </div>
            </div>

            <div class="row" style="height: 30px">
                <div class="col-md-2" style="width: 30%; float: left;">
                    <label class="label" style="width: 30%">Titolare:</label>
                </div>
                <div class="col-md-10">
                    <asp:TextBox ID="txtTitolare" runat="server" Width="65%"></asp:TextBox>
                </div>
            </div>

            <div class="row" style="height: 30px">
                <div class="col-md-2" style="width: 30%; float: left;">
                    <label class="label" style="width: 30%">Email titolare:</label>
                </div>
                <div class="col-md-10">
                    <asp:TextBox ID="txtEmailTitolare" runat="server" Width="65%"></asp:TextBox>
                </div>
            </div>

            <div class="row" style="height: 30px">
                <div class="col-md-2" style="width: 30%; float: left;">
                    <label class="label" style="width: 30%">Telefono titolare:</label>
                </div>
                <div class="col-md-10">
                    <asp:TextBox ID="txtTelefonoTitolare" runat="server" Width="65%"></asp:TextBox>
                </div>
            </div>

            <div class="row" style="height: 30px">
                <div class="col-lg-12">
                    <center>
                        <asp:Button ID="btnSalva" runat="server" Text="Salva" Style="width: 30%; height: 25px" />
                    </center>
                </div>
            </div>

            <%--<p></p>
            <div class="card-body">
                <label class="label">Email:</label>
                <asp:TextBox ID="TextBox1" runat="server" Width="54%"></asp:TextBox>
            </div>
            <p></p>
            <div class="card-body">
                <label class="label">Telefono:</label>
                <asp:TextBox ID="TextBox2" runat="server" Width="54%"></asp:TextBox>
            </div>
            <p></p>
            <div class="card-body">
                <label class="label">Codice Fiscale:</label>
                <asp:TextBox ID="TextBox3" runat="server" Width="54%"></asp:TextBox>
            </div>
            <p></p>
            <div class="card-body">
                <label class="label">Partita Iva:</label>
                <asp:TextBox ID="TextBox4" runat="server" Width="35%"></asp:TextBox>
                <div class="card-body">
                    <label class="label">CFE:</label>
                    <asp:TextBox ID="TextBox6" runat="server" Width="34%"></asp:TextBox>
                </div>
            </div>
            <p></p>
            <div class="card-body">
                <label class="label">PEC:</label>
                <asp:TextBox ID="TextBox5" runat="server" Width="54%"></asp:TextBox>
            </div>
            <p></p>
            <div class="card-body">
                <label class="label">Titolare:</label>
                <asp:TextBox ID="TextBox7" runat="server" Width="54%"></asp:TextBox>
            </div>
            <p></p>
            <div class="card-body">
                <label class="label">Email Titolare:</label>
                <asp:TextBox ID="TextBox8" runat="server" Width="44%"></asp:TextBox>
            </div>
            <p></p>
            <div class="card-body">
                <label class="label">Telefono Titolare:</label>
                <asp:TextBox ID="TextBox9" runat="server" Width="44%"></asp:TextBox>
            </div>
            <div class="card-footer text-center">
                <asp:Button ID="btnRegistra" runat="server" Text="Salva" class="btn btn-primary" />
            </div>
        </div>--%>
        </div>


    </form>
</body>
</html>