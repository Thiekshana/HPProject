<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="DengfuTesting._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <asp:Label ID="lblSession" runat="server" Text="Welcome"></asp:Label>
</p>
    <div class="jumbotron">
        <h1>Update Overall List Dengfu Handsome</h1>
        <p>
            <table style="width:100%;">
                <tr>
                    <td>ItemNames</td>
                    <td>Qty</td>
                    <td>&nbsp;</td>
                    <td>Remarks</td>
                </tr>
                <tr>
                    <td style="height: 23px">
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSourceInventoryList" DataTextField="ItemName" DataValueField="ItemName">
            </asp:DropDownList>
                    </td>
                    <td style="height: 23px">
                        <asp:TextBox ID="qtyTextBox" runat="server"></asp:TextBox>
                    </td>
                    <td style="height: 23px">
                        <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
                    </td>
                    <td style="height: 23px">
                        <asp:Label ID="qtyLabel" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </p>
        <h1>Insert Item List&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </h1>
        <p>
            <table style="width:100%;">
                <tr>
                    <td>ItemName</td>
                    <td>Qty</td>
                    <td>&nbsp;</td>
                    <td>Remarks</td>
                </tr>
                <tr>
                    <td style="height: 23px">
            <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSourceInventoryList" DataTextField="ItemName" DataValueField="ItemName">
            </asp:DropDownList>
                    </td>
                    <td style="height: 23px">
                        <asp:TextBox ID="insertTextBox" runat="server"></asp:TextBox>
                    </td>
                    <td style="height: 23px">
                        <asp:Button ID="btnInsert" runat="server" OnClick="btnInsert_Click" Text="Insert" />
                    </td>
                    <td style="height: 23px">
                        <asp:Label ID="lblInsert" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>

                    <td>&nbsp;</td>
                </tr>
            </table>
            </p>
        <h1>Delete Item List&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </h1>
        <p>
            <table style="width:100%;">
                <tr>
                    <td>ItemName</td>
                    <td>Qty</td>
                    <td>&nbsp;</td>
                    <td>Remarks</td>
                </tr>
                <tr>
                    <td style="height: 23px">
            <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSourceInventoryList" DataTextField="ItemName" DataValueField="ItemName">
            </asp:DropDownList>
                    </td>
                    <td style="height: 23px">
                        <asp:TextBox ID="deleteTextBox" runat="server"></asp:TextBox>
                    </td>
                    <td style="height: 23px">
                        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
                    </td>
                    <td style="height: 23px">
                        <asp:Label ID="lblDelete" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>

                    <td>&nbsp;</td>
                </tr>
            </table>
        </p>
        <p class="lead"><asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSourceInventoryList" AllowPaging="True" AllowSorting="True" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None" Width="843px">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="ItemName" HeaderText="ItemName" SortExpression="ItemName" />
                    <asp:BoundField DataField="Qty" HeaderText="Qty" SortExpression="Qty" />
                    <asp:BoundField DataField="location" HeaderText="location" SortExpression="location" />
                </Columns>
                <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#594B9C" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#33276A" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSourceInventoryList" runat="server" ConnectionString="<%$ ConnectionStrings:inventoryListConnectionString %>" SelectCommand="SELECT * FROM [inventoryTable]"></asp:SqlDataSource>
        </p>
    </div>

    <div class="row">
    </div>

</asp:Content>
