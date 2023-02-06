<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ModificaAzienda.aspx.cs" Inherits="Forms_ModificaAzienda" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="container py-5 mt-5">
                <div class="row d-flex justify-content-center align-items-center">

                    <div class="card internbg text-light">
                        <div class="card-body">
                            <div class="col-md-5">
                                <label class="label">Ragione sociale:</label>
                            </div>
                            <div class="col-md-5">
                                <asp:TextBox ID="txtRagione" runat="server" class=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="card-body">
                            <label class="label">Indirizzo:</label>
                            <asp:TextBox ID="txtIndirizzo" runat="server" Width="" class=""></asp:TextBox>
                        </div>
                        <div class="card-body">
                            <label class="label">Città:</label>
                            <asp:TextBox ID="txtCitta" runat="server" Width="30%" class=""></asp:TextBox>
                            <label class="label">Provincia:</label>
                            <asp:TextBox ID="txtProvincia" runat="server" Width="10%" class=""></asp:TextBox>
                            <label class="label">CAP:</label>
                            <asp:TextBox ID="txtCap" runat="server" Width="10%" class=""></asp:TextBox>
                        </div>
                        <div class="card-footer text-center">
                            <asp:Button ID="btnRegistra" runat="server" Text="Salva" class="btn btn-primary" />
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </form>
</body>
</html>
