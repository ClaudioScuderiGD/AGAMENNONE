<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/MasterPage.master" AutoEventWireup="true" CodeFile="Commesse.aspx.cs" Inherits="Forms_Commesse" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container mt-5 ">
        <div class="row">
            <div class="offset-1 col-lg-11 text-center">
                <h3>Gestione Commesse</h3>
            </div>
        </div>
        <div class="row">
            <div class="offset-1 col-lg-11 text-center">
                <asp:Button ID="btnNuovaCommessa" class="text-center" runat="server" Style="width: 20%; height: 30px; margin-top: 20px;" Text="Inserire nuova azienda" />
                <asp:Button ID="btnModificaCommessa" class="text-center" runat="server" Style="width: 20%; margin-left: 50px; height: 30px; margin-top: 20px;" Text="Modificare azienda" />

            </div>
        </div>

        <div class="row mt-4">
            <div class="col-lg-11 offset-1" style="overflow: auto">

                <asp:GridView ID="grigliaCommesse" runat="server" AutoGenerateColumns="False" DataKeyNames="chiave" DataSourceID="sdsGrigliaCommesse" OnSelectedIndexChanged="grigliaCommesse_SelectedIndexChanged">
                     <Columns>
                         <asp:CommandField ShowSelectButton="True" />
                         <asp:BoundField DataField="chiave" HeaderText="chiave" InsertVisible="False" ReadOnly="True" SortExpression="chiave" Visible="False" />
                         <asp:BoundField DataField="CORPOORA" HeaderText="CORPOORA" SortExpression="CORPOORA" />
                         <asp:BoundField DataField="DATAAPERTURA" HeaderText="DATAAPERTURA" SortExpression="DATAAPERTURA" />
                         <asp:BoundField DataField="DATACHIUSURA" HeaderText="DATACHIUSURA" SortExpression="DATACHIUSURA" />
                         <asp:BoundField DataField="DATACONSEGNA" HeaderText="DATACONSEGNA" SortExpression="DATACONSEGNA" />
                         <asp:BoundField DataField="DESCRIZIONE" HeaderText="DESCRIZIONE" SortExpression="DESCRIZIONE" />
                         <asp:BoundField DataField="IMPORTOCORPO" HeaderText="IMPORTOCORPO" SortExpression="IMPORTOCORPO" />
                         <asp:BoundField DataField="IMPORTOORARIO" HeaderText="IMPORTOORARIO" SortExpression="IMPORTOORARIO" />
                         <asp:BoundField DataField="ANTICIPO" HeaderText="ANTICIPO" SortExpression="ANTICIPO" />
                         <asp:BoundField DataField="PERNOTTAMENTO" HeaderText="PERNOTTAMENTO" SortExpression="PERNOTTAMENTO" />
                         <asp:BoundField DataField="PASTO" HeaderText="PASTO" SortExpression="PASTO" />
                         <asp:BoundField DataField="KM" HeaderText="KM" SortExpression="KM" />
                         <asp:BoundField DataField="PEDAGGI" HeaderText="PEDAGGI" SortExpression="PEDAGGI" />
                         <asp:BoundField DataField="MEZZI" HeaderText="MEZZI" SortExpression="MEZZI" />
                     </Columns>
                     <SelectedRowStyle  BackColor="LightBlue"/>
                </asp:GridView>
                <asp:SqlDataSource ID="sdsGrigliaCommesse" runat="server" ConnectionString="<%$ ConnectionStrings:AGAMENNONEConnectionString %>" SelectCommand="COMMESSE_SelectAll" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
            </div>
        </div>
    </div>

    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>

    <%-- pulsante che apre il popup --%>

    <%-- chiamata del popup --%>
    <cc1:ModalPopupExtender ID="mp1" runat="server" PopupControlID="Panl1" TargetControlID="btnNuovaCommessa"
        CancelControlID="btnChiudiPopup" BackgroundCssClass="Background">
    </cc1:ModalPopupExtender>

    <%-- contenuto del popup --%>
    <asp:Panel
        ID="Panl1"
        runat="server"
        CssClass="Popup"
        align="center"
        Style="display: none">

        <%--l'iframe è un contenitore che ha la possibilità di richiamare una pagina--%>
        <iframe style="width: 98%; height: 388px;" id="Iframe2" src="/Forms/COMMESSE/InserisciCommessa.aspx" runat="server"></iframe>
        <br />
        <asp:Button ID="btnChiudiPopup" Style="width: 30%; height: 30px;" runat="server" Text="Chiudi" OnClick="btnChiudiPopup_Click" />
        <%--chiude il popup--%>
    </asp:Panel>

    <%-- pulsante che apre il popup --%>

    <%-- chiamata del popup --%>
    <cc1:ModalPopupExtender ID="ModalPopupExtender1" runat="server" PopupControlID="Panel1" TargetControlID="btnModificaCommessa"
        CancelControlID="btnChiudiPopup" BackgroundCssClass="Background" Enabled="false">
    </cc1:ModalPopupExtender>

    <%-- contenuto del popup --%>
    <asp:Panel
        ID="Panel1"
        runat="server"
        CssClass="Popup"
        align="center"
        Style="display: none">

        <%--l'iframe è un contenitore che ha la possibilità di richiamare una pagina--%>
        <iframe style="width: 98%; height: 388px;" id="Iframe1" src="/Forms/COMMESSE/ModificaCommessa.aspx" runat="server"></iframe>
        <br />
        <asp:Button ID="Button2" class="text-center" Style="width: 30%; height: 30px;" runat="server" Text="Chiudi" OnClick="btnChiudiPopup_Click" />
        <%--chiude il popup--%>
    </asp:Panel>
</asp:Content>

