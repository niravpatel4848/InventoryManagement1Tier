<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Customers.aspx.cs" Inherits="InventoryManagement2.Customers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-grid gap-2">
        <button class="btn btn-lg btn-info" type="button"><strong>SALESMEN</strong></button>
    </div>
    <fieldset class="p-5">
        <legend>ADD A NEW CUSTOMER</legend>
        <div class="form-group">
            <label for="customerID" class="form-label mt-4">Customer ID</label>
            <asp:TextBox class="form-control" ID="customerID" runat="server" placeholder="ID"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="firstName" class="form-label mt-4">First Name</label>
            <asp:TextBox class="form-control" ID="firstName" runat="server" placeholder="First Name"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="lastName" class="form-label mt-4">Last Name</label>
            <asp:TextBox class="form-control" ID="lastName" runat="server" placeholder="Last Name"></asp:TextBox>
        </div>
        
        <div class="form-group">
            <label for="city" class="form-label mt-4">City</label>
            <asp:TextBox class="form-control" ID="city" runat="server" placeholder="City"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="grade" class="form-label mt-4">Grade</label>
            <asp:TextBox class="form-control" ID="grade" runat="server" placeholder="Grade"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="salesmanID" class="form-label mt-4">Salesman ID</label>
            <asp:TextBox class="form-control" ID="salesmanID" runat="server" placeholder="Salesman ID"></asp:TextBox>
        </div>
        <div class="form-group pt-5">
            <asp:Button CssClass="btn btn-primary" ID="btnSubmit" runat="server" Text="ADD CUSTOMER" OnClick="btnSubmit_Click"></asp:Button>
        </div>
    </fieldset>
    <div class="d-grid gap-2">
        <button class="btn btn-lg btn-info" type="button"><strong>EXISTING CUSTOMERS</strong></button>
    </div>
    <asp:GridView ID="GVCustomers" runat="server"></asp:GridView>
</asp:Content>
