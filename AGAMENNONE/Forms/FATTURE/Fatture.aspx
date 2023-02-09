<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/MasterPage.master" AutoEventWireup="true" CodeFile="Fatture.aspx.cs" Inherits="Forms_Fatture" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container mt-5 ">
        <div class="row">
            <div class="offset-1 col-lg-11 text-center">
                <h3>Gestione Fatture</h3>
            </div>
        </div>
        <div class="row">
            <div class="offset-1 col-lg-11 text-center">
                <%-- pulsante che apre il popup --%>
                <asp:Button ID="btnNuovaAzienda" class="text-center" runat="server" Style="width: 20%; height: 30px; margin-top: 20px;" Text="Inserire nuova fattura" />
                <asp:Button ID="btnModificaAzienda" class="text-center" runat="server" Style="width: 20%; margin-left: 50px; height: 30px; margin-top: 20px;" Text="Modificare fattura" />
            </div>
        </div>

        <div class="row mt-4">
            <div class="col-lg-11 offset-1" style="overflow: auto">
                <asp:GridView ID="grigliaFatture" runat="server" AutoGenerateColumns="False" DataKeyNames="chiave" DataSourceID="sdsGrigliaFatture" OnSelectedIndexChanged="grigliaFatture_SelectedIndexChanged">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="chiave" HeaderText="chiave" InsertVisible="False" ReadOnly="True" SortExpression="chiave" Visible="False" />
                        <asp:BoundField DataField="NUMEROFATTURA" HeaderText="NUMEROFATTURA" SortExpression="NUMEROFATTURA" />
                        <asp:BoundField DataField="DATAFATTURA" HeaderText="DATAFATTURA" SortExpression="DATAFATTURA" />
                        <asp:BoundField DataField="IMPORTO" HeaderText="IMPORTO" SortExpression="IMPORTO" />
                        <asp:BoundField DataField="ALIQUOTA" HeaderText="ALIQUOTA" SortExpression="ALIQUOTA" />
                        <asp:BoundField DataField="DESCRIZIONE" HeaderText="DESCRIZIONE" SortExpression="DESCRIZIONE" />
                        <asp:BoundField DataField="DATASALDO" HeaderText="DATASALDO" SortExpression="DATASALDO" />
                    </Columns>
                     <SelectedRowStyle  BackColor="LightBlue"/>
                </asp:GridView>
                <asp:SqlDataSource ID="sdsGrigliaFatture" runat="server" ConnectionString="<%$ ConnectionStrings:AGAMENNONEConnectionString %>" SelectCommand="FATTURE_SelectAll" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
            </div>
        </div>
    </div>

    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>

    <%-- chiamata del popup --%>
    <cc1:ModalPopupExtender ID="mp1" runat="server" PopupControlID="Panl1" TargetControlID="btnNuovaAzienda"
        CancelControlID="btnChiudiPopup" BackgroundCssClass="Background">
    </cc1:ModalPopupExtender>

    <%-- contenuto del popup --%>
    <asp:Panel
        ID="Panl1"
        runat="server"
        CssClass="PopupFatture"
        align="center"
        Style="display: none">

        <%--l'iframe è un contenitore che ha la possibilità di richiamare una pagina--%>
        <iframe style="width: 98%; height: 250px;" id="Iframe2" src="/Forms/FATTURE/InserisciFattura.aspx" runat="server"></iframe>
        <br />
        <asp:Button ID="btnChiudiPopup" Style="width: 30%; height: 30px;" runat="server" Text="Chiudi" OnClick="btnChiudiPopup_Click" />
        <%--chiude il popup--%>
    </asp:Panel>

    <%-- chiamata del popup --%>
    <cc1:ModalPopupExtender ID="ModalPopupExtender1" runat="server" PopupControlID="Panel1" TargetControlID="btnModificaAzienda"
        CancelControlID="btnChiudiPopup" BackgroundCssClass="Background" Enabled="false">
    </cc1:ModalPopupExtender>

    <%-- contenuto del popup --%>
    <asp:Panel
        ID="Panel1"
        runat="server"
        CssClass="PopupFattura"
        align="center"
        Style="display: none">

        <%--l'iframe è un contenitore che ha la possibilità di richiamare una pagina--%>
        <iframe style="width: 98%; height: 230px;" id="Iframe1" src="/Forms/FATTURE/ModificaFattura.aspx" runat="server"></iframe>
        <br />
        <asp:Button ID="Button2" class="text-center" Style="width: 30%; height: 30px;" runat="server" Text="Chiudi" OnClick="btnChiudiPopup_Click" />
        <%--chiude il popup--%>
    </asp:Panel>
</asp:Content>

