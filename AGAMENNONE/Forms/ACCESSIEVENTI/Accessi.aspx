<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/MasterPage.master" AutoEventWireup="true" CodeFile="Accessi.aspx.cs" Inherits="Forms_Accessi" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container mt-5 ">
        <div class="row">
            <div class="offset-1 col-lg-11 text-center">
                <h3>Gestione Log Accessi</h3>
            </div>
        </div>
        <div class="row">
            <div class="offset-1 col-lg-11 text-center">
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>

                <%-- pulsante che apre il popup --%>
                <asp:Button ID="btnNuovoLogAccesso" class="text-center" runat="server" Style="width: 20%; height: 30px; margin-top: 20px;" Text="Inserire nuovo accesso" />

                <%-- chiamata del popup --%>
                <cc1:ModalPopupExtender ID="mp1" runat="server" PopupControlID="Panl1" TargetControlID="btnNuovoLogAccesso"
                    CancelControlID="btnChiudiPopup" BackgroundCssClass="Background">
                </cc1:ModalPopupExtender>

                <%-- contenuto del popup --%>
                <asp:Panel
                    ID="Panl1"
                    runat="server"
                    CssClass="PopupLog"
                    align="center"
                    Style="display: none">

                    <%--l'iframe è un contenitore che ha la possibilità di richiamare una pagina--%>
                    <iframe style="width: 98%; height: 170px;" id="Iframe2" src="/Forms/ACCESSIEVENTI/InserisciLogAccessi.aspx" runat="server"></iframe>
                    <br />
                    <asp:Button ID="btnChiudiPopup" Style="width: 30%; height: 30px;" runat="server" Text="Chiudi" OnClick="btnChiudiPopup_Click" />
                    <%--chiude il popup--%>
                </asp:Panel>

                <%-- pulsante che apre il popup --%>
                <asp:Button ID="btnEliminaLogAccesso" class="text-center" runat="server" Style="width: 20%; margin-left: 50px; height: 30px; margin-top: 20px;" Text="Elimina accesso" />

                <%-- chiamata del popup --%>
                <cc1:ModalPopupExtender ID="ModalPopupExtender1" runat="server" PopupControlID="Panel1" TargetControlID="btnEliminaLogAccesso"
                    CancelControlID="btnChiudiPopup" BackgroundCssClass="Background" Enabled="false">
                </cc1:ModalPopupExtender>

                <%-- contenuto del popup --%>
                <asp:Panel
                    ID="Panel1"
                    runat="server"
                    CssClass="PopupLog"
                    align="center"
                    Style="display: none">

                    <%--l'iframe è un contenitore che ha la possibilità di richiamare una pagina--%>
                    <iframe style="width: 98%; height: 150px;" id="Iframe1" src="/Forms/ACCESSIEVENTI/EliminaLogAccessi.aspx" runat="server"></iframe>
                    <br />
                    <asp:Button ID="Button2" class="text-center" Style="width: 30%; height: 30px;" runat="server" Text="Chiudi" OnClick="btnChiudiPopup_Click" />
                    <%--chiude il popup--%>
                </asp:Panel>
            </div>
        </div>

        <div class="row mt-4">
            <div class="col-lg-11 offset-1" style="overflow: auto">

                <asp:GridView ID="grigliaLogAccessi" runat="server" AutoGenerateColumns="False" DataKeyNames="chiave" DataSourceID="sdsGrigliaAccessi" OnSelectedIndexChanged="grigliaLogAccessi_SelectedIndexChanged">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="chiave" HeaderText="chiave" InsertVisible="False" ReadOnly="True" SortExpression="chiave" Visible="False" />
                        <asp:BoundField DataField="DATAORA" HeaderText="DATAORA" SortExpression="DATAORA" />
                        <asp:BoundField DataField="EVENTO" HeaderText="EVENTO" SortExpression="EVENTO" />
                    </Columns>
                     <SelectedRowStyle  BackColor="LightBlue"/>
                </asp:GridView>
                <asp:SqlDataSource ID="sdsGrigliaAccessi" runat="server" ConnectionString="<%$ ConnectionStrings:AGAMENNONEConnectionString %>" SelectCommand="ACCESSI_SelectAll" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
            </div>
        </div>
    </div>
</asp:Content>

