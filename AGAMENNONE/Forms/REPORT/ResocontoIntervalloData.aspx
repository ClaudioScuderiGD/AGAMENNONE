<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/MasterPage.master" AutoEventWireup="true" CodeFile="ResocontoIntervalloData.aspx.cs" Inherits="Forms_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container mt-5 py-5">
        <table class="mt-5 d-flex justify-content-center align-items-center">
            <tr>
                <td colspan="3" class="auto-style1">
                    <h3>Qui il fatturato per intervallo data</h3>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Label">Da:</asp:Label>
                    <asp:TextBox ID="txtDataInizio" runat="server" TextMode="Date"></asp:TextBox>
                </td>
                <td style="width: 20px">
                    <asp:Label ID="Label2" runat="server" Text="Label">A:</asp:Label>
                    <asp:TextBox ID="txtDataFine" runat="server" TextMode="Date"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnCarica" runat="server" Text="Carica" />
                </td>
            </tr>
            <tr>
                <td class="justify-content-center align-items-center text-align-center">
                    <p></p>
                    <asp:Chart ID="graficoIntervallo" runat="server" DataSourceID="sdsGraficoIntervallo">
                        <Series>
                            <asp:Series Name="Series1" ></asp:Series>
                        </Series>
                        <ChartAreas>
                            <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                        </ChartAreas>
                    </asp:Chart>
                    <asp:SqlDataSource runat="server" ID="sdsGraficoIntervallo" ConnectionString="<%$ ConnectionStrings:AGAMENNONEConnectionString %>" SelectCommand="FATTURE_SelectDate_Interval" SelectCommandType="StoredProcedure">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="txtDataInizio" PropertyName="Text" DbType="Date" Name="startdate"></asp:ControlParameter>
                            <asp:ControlParameter ControlID="txtDataFine" PropertyName="Text" DbType="Date" Name="enddate"></asp:ControlParameter>
                        </SelectParameters>
                    </asp:SqlDataSource>
                </td>
                <td style="width: 50px"></td>
                <td class="justify-content-center align-items-center text-align-center">
                    <asp:GridView ID="grigliaIntervallo" runat="server" AutoGenerateColumns="False" DataSourceID="sdsGrigliaIntervallo">
                        <Columns>
                           
                        </Columns>
                    </asp:GridView>
                    <asp:SqlDataSource runat="server" ID="sdsGrigliaIntervallo" ConnectionString="<%$ ConnectionStrings:AGAMENNONEConnectionString %>" SelectCommand="FATTURE_SelectDate_Interval" SelectCommandType="StoredProcedure">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="txtDataInizio" PropertyName="Text" DbType="Date" Name="startdate"></asp:ControlParameter>
                            <asp:ControlParameter ControlID="txtDataFine" PropertyName="Text" DbType="Date" Name="enddate"></asp:ControlParameter>
                        </SelectParameters>
                    </asp:SqlDataSource>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>

