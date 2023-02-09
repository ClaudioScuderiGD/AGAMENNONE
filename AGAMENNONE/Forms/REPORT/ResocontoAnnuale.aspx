<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/MasterPage.master" AutoEventWireup="true" CodeFile="ResocontoAnnuale.aspx.cs" Inherits="Forms_Default" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container mt-5 py-5">
        <table class="mt-5 d-flex justify-content-center align-items-center">
            <tr class="mt-5">
                <td colspan="3" class="text-center">
                    <h3>Qui il fatturato annuo</h3>
                </td>
            </tr>
            <tr>
                <td class="justify-content-center align-items-center text-align-center">
                    <p></p>
                    <asp:Chart ID="Chart1" runat="server" DataSourceID="sdsGrigliaResAnnuale">
                        <Series>
                            <asp:Series Name="Series1" XValueMember="ANNO" YValueMembers="TOTALEVENDITE"></asp:Series>
                        </Series>
                        <ChartAreas>
                            <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                        </ChartAreas>
                    </asp:Chart>
                </td>
                <td style="width: 50px"></td>

                <td class="justify-content-center align-items-center text-align-center">
                    <asp:GridView ID="grigliaAnnuale" runat="server" AutoGenerateColumns="False" DataSourceID="sdsGrigliaResAnnuale">
                        <Columns>
                            <asp:BoundField DataField="TOTALEVENDITE" HeaderText="TOTALEVENDITE" ReadOnly="True" SortExpression="TOTALEVENDITE" />
                            <asp:BoundField DataField="ANNO" HeaderText="ANNO" ReadOnly="True" SortExpression="ANNO" />
                        </Columns>
                    </asp:GridView>               
                    <asp:SqlDataSource ID="sdsGrigliaResAnnuale" runat="server" ConnectionString="<%$ ConnectionStrings:AGAMENNONEConnectionString %>" SelectCommand="select sum(IMPORTO) as TOTALEVENDITE, year(DATAFATTURA) as ANNO
	from FATTURE
group by year(DATAFATTURA)
"></asp:SqlDataSource>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>

