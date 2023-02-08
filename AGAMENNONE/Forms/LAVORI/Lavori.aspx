﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/MasterPage.master" AutoEventWireup="true" CodeFile="Lavori.aspx.cs" Inherits="Forms_Lavori" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="chiave" HeaderText="chiave" InsertVisible="False" ReadOnly="True" SortExpression="chiave" Visible="False" />
                        <asp:BoundField DataField="DATAORA" HeaderText="DATAORA" SortExpression="DATAORA" />
                        <asp:BoundField DataField="ORE" HeaderText="ORE" SortExpression="ORE" />
                        <asp:BoundField DataField="DESCRIZIONE" HeaderText="DESCRIZIONE" SortExpression="DESCRIZIONE" />
                        <asp:BoundField DataField="PERNOTTAMENTO" HeaderText="PERNOTTAMENTO" SortExpression="PERNOTTAMENTO" />
                        <asp:BoundField DataField="PASTO" HeaderText="PASTO" SortExpression="PASTO" />
                        <asp:BoundField DataField="KM" HeaderText="KM" SortExpression="KM" />
                        <asp:BoundField DataField="PEDAGGI" HeaderText="PEDAGGI" SortExpression="PEDAGGI" />
                        <asp:BoundField DataField="MEZZI" HeaderText="MEZZI" SortExpression="MEZZI" />
                        <asp:BoundField DataField="SPESEEXTRA" HeaderText="SPESEEXTRA" SortExpression="SPESEEXTRA" />
                        <asp:BoundField DataField="DESCRIZIONESPESEEXTRA" HeaderText="DESCRIZIONESPESEEXTRA" SortExpression="DESCRIZIONESPESEEXTRA" />
                        <asp:CheckBoxField DataField="ACCETTAZIONESPESE" HeaderText="ACCETTAZIONESPESE" SortExpression="ACCETTAZIONESPESE" />
                    </Columns>
                    <SelectedRowStyle  BackColor="LightBlue"/>
                </asp:GridView>
                <asp:SqlDataSource ID="sdsGrigliaLavori" runat="server" ConnectionString="<%$ ConnectionStrings:AGAMENNONEConnectionString %>" SelectCommand="LAVORI_SelectAll" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
