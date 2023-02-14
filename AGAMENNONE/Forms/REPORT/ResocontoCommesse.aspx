﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/MasterPage.master" AutoEventWireup="true" CodeFile="ResocontoCommesse.aspx.cs" Inherits="Forms_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
                    <asp:SqlDataSource ID="sdsDDLCOMMESSE" runat="server" ConnectionString="<%$ ConnectionStrings:AGAMENNONEConnectionString %>" SelectCommand="Fatture_Ddl_Commesse" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
                        <Columns>
                            <asp:BoundField DataField="SPESE" HeaderText="SPESE" ReadOnly="True" SortExpression="SPESE" />
                            <asp:BoundField DataField="DATACONSEGNA" HeaderText="DATACONSEGNA" SortExpression="DATACONSEGNA" />
                        </Columns>
                    </asp:GridView>                  
                    
                    <asp:SqlDataSource ID="sdsgrigliaCommesse" runat="server" ConnectionString="<%$ ConnectionStrings:AGAMENNONEConnectionString %>" SelectCommand="FATTURATOCOMMESSE" SelectCommandType="StoredProcedure">
                        <SelectParameters>
                            <asp:Parameter DbType="Date" Name="dataconsegna" />
                        </SelectParameters>
                    </asp:SqlDataSource>
