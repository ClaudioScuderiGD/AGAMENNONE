<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/MasterPage.master" AutoEventWireup="true" CodeFile="Aziende.aspx.cs" Inherits="Forms_Default" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container mt-5 ">
        <div class="row">
            <div class="col-lg-11 offset-1" style="overflow: auto">

                <asp:GridView ID="griglia" runat="server" AutoGenerateColumns="False" DataKeyNames="chiave" DataSourceID="sdsAziende">
                    <Columns>
                        <asp:BoundField DataField="chiave" HeaderText="chiave" ReadOnly="True" InsertVisible="False" SortExpression="chiave"></asp:BoundField>
                        <asp:BoundField DataField="RAGIONESOCIALE" HeaderText="RAGIONESOCIALE" SortExpression="RAGIONESOCIALE"></asp:BoundField>
                        <asp:BoundField DataField="INDIRIZZO" HeaderText="INDIRIZZO" SortExpression="INDIRIZZO"></asp:BoundField>
                        <asp:BoundField DataField="CITTA" HeaderText="CITTA" SortExpression="CITTA"></asp:BoundField>
                        <asp:BoundField DataField="CAP" HeaderText="CAP" SortExpression="CAP"></asp:BoundField>
                        <asp:BoundField DataField="PROVINCIA" HeaderText="PROVINCIA" SortExpression="PROVINCIA"></asp:BoundField>
                        <asp:BoundField DataField="EMAIL" HeaderText="EMAIL" SortExpression="EMAIL"></asp:BoundField>
                        <asp:BoundField DataField="TELEFONO" HeaderText="TELEFONO" SortExpression="TELEFONO"></asp:BoundField>
                        <asp:BoundField DataField="CODICEFISCALE" HeaderText="CODICEFISCALE" SortExpression="CODICEFISCALE"></asp:BoundField>
                        <asp:BoundField DataField="PIVA" HeaderText="PIVA" SortExpression="PIVA"></asp:BoundField>
                        <asp:BoundField DataField="PEC" HeaderText="PEC" SortExpression="PEC"></asp:BoundField>
                        <asp:BoundField DataField="CFE" HeaderText="CFE" SortExpression="CFE"></asp:BoundField>
                        <asp:BoundField DataField="TITOLARE" HeaderText="TITOLARE" SortExpression="TITOLARE"></asp:BoundField>
                        <asp:BoundField DataField="EMAILTITOLARE" HeaderText="EMAILTITOLARE" SortExpression="EMAILTITOLARE"></asp:BoundField>
                        <asp:BoundField DataField="TELTITOLARE" HeaderText="TELTITOLARE" SortExpression="TELTITOLARE"></asp:BoundField>
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource runat="server" ID="sdsAziende" ConnectionString="<%$ ConnectionStrings:AGAMENNONEConnectionString %>" SelectCommand="SELECT [chiave], [RAGIONESOCIALE], [INDIRIZZO], [CITTA], [CAP], [PROVINCIA], [EMAIL], [TELEFONO], [CODICEFISCALE], [PIVA], [PEC], [CFE], [TITOLARE], [EMAILTITOLARE], [TELTITOLARE] FROM [AZIENDE] ORDER BY [RAGIONESOCIALE]"></asp:SqlDataSource>


            </div>
        </div>
        <div class="row">
            <div class="offset-1 col-lg-11 text-center">
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>

                <%-- pulsante che apre il popup --%>
                <asp:Button ID="btnNuovaAzienda" class="text-center" runat="server" Style="width: 20%; height: 30px; margin-top: 20px;" Text="Inserire nuova azienda" />

                <%-- chiamata del popup --%>
                <cc1:ModalPopupExtender ID="mp1" runat="server" PopupControlID="Panl1" TargetControlID="btnNuovaAzienda"
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
                    <iframe style="width: 98%; height: 490px;" id="irm1" src="/Forms/AZIENDE/InserisciAzienda.aspx" runat="server"></iframe>
                    <br />
                    <asp:Button ID="btnChiudiPopup" Style="width: 30%; height: 20px;" runat="server" Text="Chiudi" OnClick="btnChiudiPopup_Click" />
                    <%--chiude il popup--%>
                </asp:Panel>





                <%-- pulsante che apre il popup --%>
                <asp:Button ID="btnModificaAzienda" class="text-center" runat="server" Style="width: 20%; margin-left: 50px; height: 30px; margin-top: 20px;" Text="Modificare azienda" />

                <%-- chiamata del popup --%>
                <cc1:ModalPopupExtender ID="ModalPopupExtender1" runat="server" PopupControlID="Panel1" TargetControlID="btnModificaAzienda"
                    CancelControlID="btnChiudiPopup" BackgroundCssClass="Background">
                </cc1:ModalPopupExtender>

                <%-- contenuto del popup --%>
                <asp:Panel
                    ID="Panel1"
                    runat="server"
                    CssClass="Popup"
                    align="center"
                    Style="display: none">

                    <%--l'iframe è un contenitore che ha la possibilità di richiamare una pagina--%>
                    <iframe style="width: 98%; height: 490px;" id="Iframe1" src="/Forms/AZIENDE/ModificaAzienda.aspx" runat="server"></iframe>
                    <br />
                    <asp:Button ID="Button2" class="text-center" Style="width: 30%; height: 20px;" runat="server" Text="Chiudi" OnClick="btnChiudiPopup_Click" />
                    <%--chiude il popup--%>
                </asp:Panel>



            </div>

        </div>


    </div>
</asp:Content>

