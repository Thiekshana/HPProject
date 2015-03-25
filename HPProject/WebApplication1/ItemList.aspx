<%@ Page Title="ItemList" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ItemList.aspx.cs" Inherits="WebApplication1.ItemList" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <%--<h3>Inventory</h3>--%>
    <p></p>
    <p></p>
    <p>
        ItemName:
        <asp:DropDownList ID="DropDownList1" DatatextField="ItemName" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true">
        </asp:DropDownList>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Quantity:
        <asp:Label ID="lblQty" runat="server"></asp:Label>
    </p>
    <p>

        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnTake" runat="server" Text="Take" />
&nbsp;&nbsp;&nbsp;
        
    </p>
    <p>Use this area to provide additional information.</p>
</asp:Content>
