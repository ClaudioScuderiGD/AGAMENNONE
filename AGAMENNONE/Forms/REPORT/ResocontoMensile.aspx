<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/MasterPage.master" AutoEventWireup="true" CodeFile="ResocontoMensile.aspx.cs" Inherits="Forms_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="container mt-5 py-5">
        <table class="mt-5 d-flex justify-content-center align-items-center">
            <tr>
             <td colspan="3" class="auto-style1">
                 <h3>Qui il fatturato mensile</h3>
             </td>      
         </tr> 
            <tr>
                <td>                                                    
                </td>
                <td>
                    <asp:DropDownList ID="ddlAnno" runat="server" DataSourceID="sdsGrigliaMese" DataTextField="ANNO" DataValueField="ANNO" OnSelectedIndexChanged="ddlAnno_SelectedIndexChanged"></asp:DropDownList>
                </td>
                <td></td>
            </tr>
            <tr>
                <td class="justify-content-center align-items-center text-align-center">
                    <p></p>
                    <asp:Chart ID="graficoMese" runat="server" DataSourceID="sdsGrigliaMese">
                        <Series>
                            <asp:Series Name="Series1" XValueMember="MESE" YValueMembers="TOTALEVENDITE"></asp:Series>
                        </Series>
                        <ChartAreas>
                            <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                        </ChartAreas>
                    </asp:Chart>
                </td>
                <td style="width: 50px"></td>

                <td class="justify-content-center align-items-center text-align-center">
                    <asp:GridView ID="grigliaMese" runat="server" AutoGenerateColumns="False" DataSourceID="sdsGrigliaMese">
                        <Columns>
                            <asp:BoundField DataField="TOTALEVENDITE" HeaderText="TOTALEVENDITE" ReadOnly="True" SortExpression="TOTALEVENDITE" />
                            <asp:BoundField DataField="MESE" HeaderText="MESE" ReadOnly="True" SortExpression="MESE" />
                            <asp:BoundField DataField="ANNO" HeaderText="ANNO" ReadOnly="True" SortExpression="ANNO" />
                        </Columns>
                    </asp:GridView>
                    <asp:SqlDataSource ID="sdsGrigliaMese" runat="server" ConnectionString="<%$ ConnectionStrings:AGAMENNONEConnectionString %>" SelectCommand="FATTURATOMENSILE" SelectCommandType="StoredProcedure">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="ddlAnno" DefaultValue="2023" Name="anno" PropertyName="SelectedValue" Type="Int32" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </td>
            </tr>

        </table>
    </div>
</asp:Content>

