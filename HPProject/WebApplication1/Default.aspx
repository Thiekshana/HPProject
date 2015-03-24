<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Spares Management</h1>
        <p class="lead">Spare Parts Managment System for HP-TIJ4 Division</p>
        <p><a runat="server" href="~/ItemList" class="btn btn-primary btn-lg">Inventory List</a></p>
        <!--<p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>-->
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Part tracking list</h2>
            <p>
                This section allows you to keep track of your items
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301948">Click here &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Latest inventories</h2>
            <p>
                All the latest items added can be viewed here</p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301949">Click here &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Admin Panel</h2>
            <p>
                This section is for the admins to add,delete, modify inventories</p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301950">Click here &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
