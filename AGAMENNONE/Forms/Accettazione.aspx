<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/MasterPage.master" AutoEventWireup="true" CodeFile="Accettazione.aspx.cs" Inherits="Forms_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container mt-5 ">        <div class="row">            <div class="offset-1 col-lg-11 text-center">                <h3>Accettazione</h3>            </div>        </div>        <div class="row">            <div class="offset-1 col-lg-11 text-center">                <asp:Button ID="btnAccetta" runat="server" Style="height: 30px; margin-top: 20px;" Text="Accetta" OnClick="btnAccetta_Click" />            </div>        </div>        <div class="row mt-4">            <div class="col-lg-11 offset-1" style="overflow: auto">                <asp:GridView ID="grigliaAccettazione" runat="server" AutoGenerateColumns="False" DataKeyNames="chiave" DataSourceID="sdsGrigliaAccettazione" OnSelectedIndexChanged="grigliaAccettazione_SelectedIndexChanged">
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
where L.ACCETTAZIONESPESE=0"></asp:SqlDataSource>            </div>        </div>    </div>
</asp:Content>

