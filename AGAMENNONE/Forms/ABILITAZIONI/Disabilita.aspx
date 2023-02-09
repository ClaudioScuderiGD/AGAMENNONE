<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/MasterPage.master" AutoEventWireup="true" CodeFile="Disabilita.aspx.cs" Inherits="Forms_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container mt-5 ">
        <div class="row">
            <div class="offset-1 col-lg-11 text-center">
                <h3>Abilita Account</h3>
            </div>
        </div>
        <div class="row">
            <div class="offset-1 col-lg-11 text-center">
                <asp:Button ID="btnDisabilita" runat="server" Style="height: 30px; margin-top: 20px;" Text="Disabilita" OnClick="btnDisabilita_Click" />
            </div>
        </div>
        <div class="row mt-4">
            <div class="col-lg-11 offset-1" style="overflow: auto">
                   <asp:GridView ID="grigliaDisabilita" runat="server" AutoGenerateColumns="False" DataKeyNames="chiave" DataSourceID="sdsGrigliaDisabilita" OnSelectedIndexChanged="grigliaDisabilita_SelectedIndexChanged">
                       <Columns>
                           <asp:CommandField ShowSelectButton="True" />
                           <asp:BoundField DataField="chiave" HeaderText="chiave" InsertVisible="False" ReadOnly="True" SortExpression="chiave" Visible="False" />
                           <asp:BoundField DataField="RAGIONESOCIALE" HeaderText="RAGIONESOCIALE" SortExpression="RAGIONESOCIALE" />
                           <asp:BoundField DataField="EMAIL" HeaderText="EMAIL" SortExpression="EMAIL" />
                           <asp:BoundField DataField="PWD" HeaderText="PWD" SortExpression="PWD" />
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
                   <asp:SqlDataSource ID="sdsGrigliaDisabilita" runat="server" ConnectionString="<%$ ConnectionStrings:AGAMENNONEConnectionString %>" SelectCommand="select D.chiave, A.RAGIONESOCIALE, D.EMAIL, D.PWD, D.RUOLO, D.COGNOME, D.NOME, D.INDIRIZZO,
        D.CITTA, D.CAP, D.PROVINCIA, D.TELEFONO, D.COSTOORARIO, D.DATAINIZIORAPPORTO, D.DATAFINERAPPORTO
from DIPENDENTI as D
join AZIENDE as A
on D.chiaveAZIENDA=A.chiave 
where D.ABILITATO = 1
order by COGNOME, NOME, RAGIONESOCIALE"></asp:SqlDataSource>
            </div>
        </div>
    </div>
</asp:Content>

