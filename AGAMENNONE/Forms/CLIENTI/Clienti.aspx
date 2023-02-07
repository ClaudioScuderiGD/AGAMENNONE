<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/MasterPage.master" AutoEventWireup="true" CodeFile="Clienti.aspx.cs" Inherits="Forms_Clienti" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <div class="container mt-5 ">
        <div class="row">
            <div class="offset-1 col-lg-11 text-center">
                <h3>Gestione Clienti</h3>
            </div>
        </div>
        <div class="row">
            <div class="offset-1 col-lg-11 text-center">
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>

                <%-- pulsante che apre il popup --%>
                <asp:Button ID="btnNuovaAzienda" class="text-center" runat="server" Style="width: 20%; height: 30px; margin-top: 20px;" Text="Inserire nuova azienda" />

                <%-- chiamata del popup --%>
                <cc1:modalpopupextender ID="mp1" runat="server" PopupControlID="Panl1" TargetControlID="btnNuovaAzienda"
                    CancelControlID="btnChiudiPopup" BackgroundCssClass="Background">
                </cc1:modalpopupextender>

                <%-- contenuto del popup --%>
                <asp:Panel
                    ID="Panl1"
                    runat="server"
                    CssClass="Popup"
                    align="center"
                    Style="display: none">

                    <%--l'iframe è un contenitore che ha la possibilità di richiamare una pagina--%>
                    <iframe style="width: 98%; height: 388px;" id="Iframe2" src="/Forms/CLIENTI/InserisciCliente.aspx" runat="server"></iframe>
                    <br />
                    <asp:Button ID="btnChiudiPopup" Style="width: 30%; height: 30px;" runat="server" Text="Chiudi" OnClick="btnChiudiPopup_Click" />
                    <%--chiude il popup--%>
                </asp:Panel>

                <%-- pulsante che apre il popup --%>
                <asp:Button ID="btnModificaAzienda" class="text-center" runat="server" Style="width: 20%; margin-left: 50px; height: 30px; margin-top: 20px;" Text="Modificare azienda" />

                <%-- chiamata del popup --%>
                <cc1:modalpopupextender ID="ModalPopupExtender1" runat="server" PopupControlID="Panel1" TargetControlID="btnModificaAzienda"
                    CancelControlID="btnChiudiPopup" BackgroundCssClass="Background">
                </cc1:modalpopupextender>

                <%-- contenuto del popup --%>
                <asp:Panel
                    ID="Panel1"
                    runat="server"
                    CssClass="Popup"
                    align="center"
                    Style="display: none">

                    <%--l'iframe è un contenitore che ha la possibilità di richiamare una pagina--%>
                    <iframe style="width: 98%; height: 388px;" id="Iframe1" src="/Forms/CLIENTI/ModificaCliente.aspx" runat="server"></iframe>
                    <br />
                    <asp:Button ID="Button2" class="text-center" Style="width: 30%; height: 30px;" runat="server" Text="Chiudi" OnClick="btnChiudiPopup_Click" />
                    <%--chiude il popup--%>
                </asp:Panel>
            </div>
        </div>

        <div class="row mt-4">
            <div class="col-lg-11 offset-1" style="overflow: auto">
                <asp:GridView ID="grigliaClienti" runat="server" AutoGenerateColumns="False" DataKeyNames="chiave" DataSourceID="sdsGrigliaClienti">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="chiave" HeaderText="chiave" InsertVisible="False" ReadOnly="True" SortExpression="chiave" Visible="False" />
                        <asp:BoundField DataField="RAGIONESOCIALE" HeaderText="RAGIONESOCIALE" SortExpression="RAGIONESOCIALE" />
                        <asp:BoundField DataField="INDIRIZZO" HeaderText="INDIRIZZO" SortExpression="INDIRIZZO" />
                        <asp:BoundField DataField="CITTA" HeaderText="CITTA" SortExpression="CITTA" />
                        <asp:BoundField DataField="CAP" HeaderText="CAP" SortExpression="CAP" />
                        <asp:BoundField DataField="PROVINCIA" HeaderText="PROVINCIA" SortExpression="PROVINCIA" />
                        <asp:BoundField DataField="EMAIL" HeaderText="EMAIL" SortExpression="EMAIL" />
                        <asp:BoundField DataField="TELEFONO" HeaderText="TELEFONO" SortExpression="TELEFONO" />
                        <asp:BoundField DataField="CODICEFISCALE" HeaderText="CODICEFISCALE" SortExpression="CODICEFISCALE" />
                        <asp:BoundField DataField="PIVA" HeaderText="PIVA" SortExpression="PIVA" />
                        <asp:BoundField DataField="PEC" HeaderText="PEC" SortExpression="PEC" />
                        <asp:BoundField DataField="CFE" HeaderText="CFE" SortExpression="CFE" />
                        <asp:BoundField DataField="TITOLARE" HeaderText="TITOLARE" SortExpression="TITOLARE" />
                        <asp:BoundField DataField="EMAILTITOLARE" HeaderText="EMAILTITOLARE" SortExpression="EMAILTITOLARE" />
                        <asp:BoundField DataField="TELTITOLARE" HeaderText="TELTITOLARE" SortExpression="TELTITOLARE" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="sdsGrigliaClienti" runat="server" ConnectionString="<%$ ConnectionStrings:AGAMENNONEConnectionString %>" SelectCommand="CLIENTI_SelectAll" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
                </div>
        </div>
    </div>
</asp:Content>

