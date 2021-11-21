<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Orders.aspx.cs" Inherits="InventoryManagement2.Orders" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-grid gap-2">
        <button class="btn btn-lg btn-info" type="button"><strong>SALESMEN</strong></button>
    </div>
    <fieldset class="p-5">
        <legend>ADD A NEW ORDER</legend>
        <div class="form-group">
            <label for="orderNo" class="form-label mt-4">Order Number</label>
            <asp:TextBox class="form-control" ID="orderNo" runat="server" placeholder="ID"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="purchaseAmount" class="form-label mt-4">Purchase Amount</label>
            <asp:TextBox class="form-control" ID="purchaseAmount" runat="server" placeholder="Purchase Amount"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="orderDate" class="form-label mt-4">Order Date</label>
            <asp:TextBox class="form-control" ID="orderDate" runat="server" placeholder="Order Date"></asp:TextBox>
        </div>
        
        <div class="form-group">
            <label for="customerID" class="form-label mt-4">Customer ID</label>
            <asp:TextBox class="form-control" ID="customerID" runat="server" placeholder="Customer ID"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="salesmanID" class="form-label mt-4">Salesman ID</label>
            <asp:TextBox class="form-control" ID="salesmanID" runat="server" placeholder="Salesman ID"></asp:TextBox>
        </div>
        <div class="form-group pt-5">
            <asp:Button CssClass="btn btn-primary" ID="btnSubmit" runat="server" Text="Add Order" OnClick="btnSubmit_Click"></asp:Button>
        </div>
    </fieldset>
    <div class="d-grid gap-2">
        <button class="btn btn-lg btn-info" type="button"><strong>ORDER HISTORY</strong></button>
    </div>
    <asp:GridView ID="GVOrders" runat="server"></asp:GridView>
</asp:Content>
