<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InserisciReferentiCommesse.aspx.cs" Inherits="Forms_COMMESSE_InserisciReferentiCommesse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container py-5 mt-5">            <div class="row d-flex justify-content-center align-items-center" style="height: 25px; margin-bottom: 15px; margin-top: -5px">                <div class="col-md-12 text-center">                    <center>                        <h2>Seleziona i campi</h2>                    </center>                </div>                <div class="row" style="height: 30px">                    <div class="col-md-6 text-center" style="width: 45%; float: left">                        <center><asp:DropDownList ID="ddlReferenti" runat="server" style="width: 90%"></asp:DropDownList></center>                    </div>                    <div class="col-md-6 text-center" style="width: 45%; float: left">                        <center><asp:DropDownList ID="ddlCommesse" runat="server" style="width: 90%"></asp:DropDownList></center>                    </div>                </div>                <div class="row" style="height: 30px">                    <div class="col-md-12" style="width:80%">                        <center>                            <asp:Button ID="btnSalva" runat="server" style="width:30%" Text="Salva" />                        </center>                    </div>                </div>            </div>        </div>
    </form>
</body>
</html>
