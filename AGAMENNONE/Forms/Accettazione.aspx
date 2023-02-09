﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/MasterPage.master" AutoEventWireup="true" CodeFile="Accettazione.aspx.cs" Inherits="Forms_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container mt-5 ">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="chiave" HeaderText="chiave" InsertVisible="False" ReadOnly="True" SortExpression="chiave" Visible="False" />
                        <asp:BoundField DataField="PERNOTTAMENTO" HeaderText="PERNOTTAMENTO" SortExpression="PERNOTTAMENTO" />
                        <asp:BoundField DataField="PASTO" HeaderText="PASTO" SortExpression="PASTO" />
                        <asp:BoundField DataField="KM" HeaderText="KM" SortExpression="KM" />
                        <asp:BoundField DataField="PEDAGGI" HeaderText="PEDAGGI" SortExpression="PEDAGGI" />
                        <asp:BoundField DataField="MEZZI" HeaderText="MEZZI" SortExpression="MEZZI" />
                        <asp:BoundField DataField="SPESEEXTRA" HeaderText="SPESEEXTRA" SortExpression="SPESEEXTRA" />
                        <asp:BoundField DataField="DESCRIZIONESPESEEXTRA" HeaderText="DESCRIZIONESPESEEXTRA" SortExpression="DESCRIZIONESPESEEXTRA" />
                    </Columns>
                    <SelectedRowStyle  BackColor="LightBlue"/>
                </asp:GridView>           
                <asp:SqlDataSource ID="sdsGrigliaAccettazione" runat="server" ConnectionString="<%$ ConnectionStrings:AGAMENNONEConnectionString %>" SelectCommand="select L.chiave, L.PERNOTTAMENTO, L.PASTO, L.KM, L.PEDAGGI, L.MEZZI, L.SPESEEXTRA, L.DESCRIZIONESPESEEXTRA
	from LAVORI as L
	join COMMESSE as C
	on L.chiaveCOMMESSA=C.chiave
where L.ACCETTAZIONESPESE=0"></asp:SqlDataSource>
</asp:Content>
