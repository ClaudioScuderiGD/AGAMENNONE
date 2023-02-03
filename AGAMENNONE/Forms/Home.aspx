<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/MasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Forms_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container mt-5">
        <div class="row">
            <div class="col-md-6 offset-md-1">                          
                <asp:GridView runat="server" AutoGenerateColumns="False" DataKeyNames="chiave" DataSourceID="sdsGrigliaDipendenti">
                    <Columns>
                        <asp:BoundField DataField="chiave" HeaderText="chiave" InsertVisible="False" ReadOnly="True" SortExpression="chiave" />
                        <asp:BoundField DataField="chiaveAZIENDA" HeaderText="chiaveAZIENDA" SortExpression="chiaveAZIENDA" />
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
                </asp:GridView>
                <asp:SqlDataSource ID="sdsGrigliaDipendenti" runat="server" ConnectionString="<%$ ConnectionStrings:AGAMENNONEConnectionString %>" SelectCommand="SELECT * FROM [DIPENDENTI]"></asp:SqlDataSource>
             
                <div class="col-md-4 offset-md-7">      
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </div>
            </div>
        </div>


    </div>
</asp:Content>

