<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DengfuTesting.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Login Page<br />
        <br />
        UserName:
        <asp:TextBox ID="userNameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Password:
        <asp:TextBox ID="passwordTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
        <br />
    
    </div>
    </form>
</body>
</html>
