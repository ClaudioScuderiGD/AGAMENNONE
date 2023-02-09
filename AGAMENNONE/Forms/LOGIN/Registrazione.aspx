<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registrazione.aspx.cs" Inherits="Forms_Registrati" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-GLhlTQ8iRABdZLl6O3oVMWSktQOp6b7In1Zl3/Jr59b6EGGoI1aFkw7cmDA6j6gD" crossorigin="anonymous" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container py-5 mt-3">
            <div class="row">
                <div class="col-md-12 text-center mb-5">
                    <img src="/assets/images/fotoSito.jpg" class="img-fluid" alt="Sample image" />
                    <h3 class="mt-3">Registrazione Aziendale</h3>
                </div>
            </div>
            <center>
                <table>
                    <tr>
                        <td>
                            <label>Azienda</label>
                            <asp:DropDownList ID="ddlAzienda" runat="server" DataSourceID="sdsDDLAziende" DataTextField="RAGIONESOCIALE" DataValueField="chiave"></asp:DropDownList>
                            <asp:SqlDataSource ID="sdsDDLAziende" runat="server" ConnectionString="<%$ ConnectionStrings:AGAMENNONEConnectionString %>" SelectCommand="SELECT [RAGIONESOCIALE], [chiave] FROM [AZIENDE]"></asp:SqlDataSource>
                        </td>
                        <td style="width: 10%"></td>
                        <td>
                            <label>Email</label>
                            <asp:TextBox ID="txtEmail" runat="server" class="form-control form-control-lg"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label>Cognome</label>
                            <asp:TextBox ID="txtCognome" runat="server" class="form-control form-control-lg"></asp:TextBox>
                        </td>
                        <td style="width: 10%"></td>
                        <td>
                            <label>Nome</label>
                            <asp:TextBox ID="txtNome" runat="server" class="form-control form-control-lg"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label>Indirizzo</label>
                            <asp:TextBox ID="txtIndirizzo" runat="server" class="form-control form-control-lg"></asp:TextBox>
                        </td>
                        <td style="width: 10%"></td>
                        <td>
                            <label>Citta</label>
                            <asp:TextBox ID="txtCitta" runat="server" class="form-control form-control-lg"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label>Cap</label>
                            <asp:TextBox ID="txtCap" runat="server" class="form-control form-control-lg"></asp:TextBox>
                        </td>
                        <td style="width: 10%"></td>
                        <td>
                            <label>Provincia</label>
                            <asp:TextBox ID="txtProvincia" runat="server" class="form-control form-control-lg"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label>Telefono</label>
                            <asp:TextBox ID="txtTelefono" runat="server" class="form-control form-control-lg"></asp:TextBox>
                        </td>
                        <td style="width: 10%"></td>
                        <td>
                            <center style="margin-top: 25px">
                                <asp:Button ID="btnRegistra" runat="server" Text="Registrati" class="btn btn-primary btn-lg" Style="width: 50%" OnClick="btnRegistra_Click" />
                            </center>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td style="width: 10%"></td>
                        <td>
                            <center style="margin-top: 15px">
                                <a href="/Forms/LOGIN/Login.aspx" class="text-body">Sei già registrato?</a>
                            </center>
                        </td>
                    </tr>
                </table>
            </center>
        </div>
    </form>
</body>
</html>
