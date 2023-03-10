<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/MasterPage.master" AutoEventWireup="true" CodeFile="Dipendenti.aspx.cs" Inherits="Forms_Dipendenti" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <div class="container mt-5 ">
        <div class="row">
            <div class="offset-1 col-lg-11 text-center">
                <h3>Gestione Dipendenti</h3>
            </div>
        </div>
        <div class="row">
            <div class="offset-1 col-lg-11 text-center">
                <asp:Button ID="btnNuovaAzienda" class="text-center" runat="server" Style="width: 20%; height: 30px; margin-top: 20px;" Text="Inserire il nuovo dipendente" />
                <asp:Button ID="btnModificaAzienda" class="text-center" runat="server" Style="width: 20%; margin-left: 50px; height: 30px; margin-top: 20px;" Text="Modificare il dipendente" /> 
            </div>
        </div>

        <div class="row mt-4">
            <div class="col-lg-11 offset-1" style="overflow: auto">
                <asp:GridView ID="grigliaDipendenti" runat="server" AutoGenerateColumns="False" DataKeyNames="chiave" DataSourceID="sdsGrigliaDipendenti" OnSelectedIndexChanged="grigliaDipendenti_SelectedIndexChanged">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="chiave" HeaderText="chiave" InsertVisible="False" ReadOnly="True" SortExpression="chiave" Visible="False" />
                        <asp:BoundField DataField="RAGIONESOCIALE" HeaderText="RAGIONESOCIALE" SortExpression="RAGIONESOCIALE" />
                        <asp:BoundField DataField="EMAIL" HeaderText="EMAIL" SortExpression="EMAIL" />
                        <asp:BoundField DataField="PWD" HeaderText="PWD" SortExpression="PWD" />
                        <asp:CheckBoxField DataField="ABILITATO" HeaderText="ABILITATO" SortExpression="ABILITATO" />
                        <asp:CheckBoxField DataField="PRIMOACCESSO" HeaderText="PRIMOACCESSO" SortExpression="PRIMOACCESSO" />
                        <asp:BoundField DataField="RUOLO" HeaderText="RUOLO" SortExpression="RUOLO" />
                        <asp:BoundField DataField="COGNOME" HeaderText="COGNOME" SortExpression="COGNOME" />
                        <asp:BoundField DataField="NOME" HeaderText="NOME" SortExpression="NOME" />
                        <asp:BoundField DataField="INDIRIZZO" HeaderText="INDIRIZZO" SortExpression="INDIRIZZO" />
                        <asp:BoundField DataField="CITTA" HeaderText="CITTA" SortExpression="CITTA" />
                        <asp:BoundField DataField="CAP" HeaderText="CAP" SortExpression="CAP" />
                        <asp:BoundField DataField="PROVINCIA" HeaderText="PROVINCIA" SortExpression="PROVINCIA" />
                        <asp:BoundField DataField="TELEFONO" HeaderText="TELEFONO" SortExpression="TELEFONO" />
                        <asp:BoundField DataField="COSTOORARIO" HeaderText="COSTOORARIO" SortExpression="COSTOORARIO" />
                        <asp:BoundField DataField="DATAINIZIORAPPORTO" HeaderText="DATAINIZIORAPPORTO" SortExpression="DATAINIZIORAPPORTO" />
                        <asp:BoundField DataField="DATAFINERAPPORTO" HeaderText="DATAFINERAPPORTO" SortExpression="DATAFINERAPPORTO" />
                    </Columns>
                  <SelectedRowStyle  BackColor="LightBlue"/>
                </asp:GridView>
                <asp:SqlDataSource ID="sdsGrigliaDipendenti" runat="server" ConnectionString="<%$ ConnectionStrings:AGAMENNONEConnectionString %>" SelectCommand="DIPENDENTI_SelectAll" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
                </div>
        </div>
    </div>
     <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
                <%-- chiamata del popup --%>
                <cc1:modalpopupextender ID="mp1" runat="server" PopupControlID="Panl1" TargetControlID="btnNuovaAzienda"
                    CancelControlID="btnChiudiPopup" BackgroundCssClass="Background">
                </cc1:modalpopupextender>

                <%-- contenuto del popup --%>
                <asp:Panel
                    ID="Panl1"
                    runat="server"
                    CssClass="PopupDipendenti"
                    align="center"
                    Style="display: none">

                    <%--l'iframe è un contenitore che ha la possibilità di richiamare una pagina--%>
                    <iframe style="width: 98%; height: 340px;" id="Iframe2" src="/Forms/DIPENDENTI/InserisciDipendente.aspx" runat="server"></iframe>
                    <br />
                    <asp:Button ID="btnChiudiPopup" Style="width: 30%; height: 30px;" runat="server" Text="Chiudi" OnClick="btnChiudiPopup_Click" />
                    <%--chiude il popup--%>
                </asp:Panel>

              

                <%-- chiamata del popup --%>
                <cc1:modalpopupextender ID="ModalPopupExtender1" runat="server" PopupControlID="Panel1" TargetControlID="btnModificaAzienda"
                    CancelControlID="btnChiudiPopup" BackgroundCssClass="Background" Enabled="false">
                </cc1:modalpopupextender>

                <%-- contenuto del popup --%>
                <asp:Panel
                    ID="Panel1"
                    runat="server"
                    CssClass="PopupDipendenti"
                    align="center"
                    Style="display: none">

                    <%--l'iframe è un contenitore che ha la possibilità di richiamare una pagina--%>
                    <iframe style="width: 98%; height: 340px;" id="Iframe1" src="/Forms/DIPENDENTI/ModificaDipendente.aspx" runat="server"></iframe>
                    <br />
                    <asp:Button ID="Button2" class="text-center" Style="width: 30%; height: 30px;" runat="server" Text="Chiudi" OnClick="btnChiudiPopup_Click" />
                    <%--chiude il popup--%>
                </asp:Panel>
</asp:Content>

