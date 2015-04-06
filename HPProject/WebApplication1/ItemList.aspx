<%@ Page Title="ItemList" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ItemList.aspx.cs" Inherits="WebApplication1.ItemList" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <script type="text/javascript" language="javascript">
        function ConfirmOnDelete() {
            if (confirm("Are you sure?") == true)
                return true;
            else
                return false;
        }

    </script>

    <script type = "text/javascript">
    function calopen(x)    
    {
        var confirmss = document.createElement("input");
        confirmss.name = "confirmvalue";
        if (confirm("Are you sure you want to add "+ x+"?"+  '\n' + "Confirm?"))
            {   
            confirmss.value = "Yes";
            return confirmss;
            }
            else   
            {   
                return false;
            }    
        document.forms[0].appendChild(confirmss);
        }
        </script>

    <script type = "text/javascript">
        function Confirm() {
            var confirm_value = document.createElement("INPUT");
            confirm_value.type = "hidden";
            confirm_value.name = "confirm_value";
            if (confirm("Do you want to save data?")) {
                confirm_value.value = "Yes";
            } else {
                confirm_value.value = "No";
            }
            document.forms[0].appendChild(confirm_value);
        }
    </script>



<center>
    <h2><%: Title %>.</h2>
    <%--<h3>Inventory</h3>--%>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>
        <asp:Label ID="lblitemname" runat="server" Text="ItemName"></asp:Label>
&nbsp;
        <asp:DropDownList ID="DropDownList1" DatatextField="ItemName" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true">
        </asp:DropDownList>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Quantity:
        <asp:Label ID="lblQty" runat="server"></asp:Label>
    </p>
    <p>
        &nbsp;<p>
            <asp:Label ID="lblAddQty" runat="server" Text="Add Qty" Visible="False"></asp:Label>
&nbsp;<asp:TextBox ID="tbQty" runat="server" Visible="False"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnConfirm" runat="server" Text="Confirm" Visible="False" OnClick="btnConfirm_Click" />

    </p>
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" Visible="False" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnTake" runat="server" Text="Take" Visible="False" />
&nbsp;&nbsp;&nbsp;
        
    </p>
    <p>Use this area to provide additional information.</p>
</center>
   
</asp:Content>
