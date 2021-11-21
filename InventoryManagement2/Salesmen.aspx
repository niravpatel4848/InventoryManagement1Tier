<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Salesmen.aspx.cs" Inherits="InventoryManagement2.Salesmen" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-grid gap-2">
        <button class="btn btn-lg btn-info" type="button"><strong>SALESMEN</strong></button>
    </div>
    <fieldset class="p-5">
        <legend>ADD A NEW SALESMAN</legend>
        <div class="form-group">
            <label for="salesmanNo" class="form-label mt-4">Salesman Number</label>
            <asp:TextBox class="form-control" ID="txtID" runat="server" placeholder="ID"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="salesmanName" class="form-label mt-4">Salesman Name</label>
            <asp:TextBox class="form-control" ID="txtSalesmanName" runat="server" placeholder="Salesman Name"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="city" class="form-label mt-4">City</label>
            <asp:TextBox class="form-control" ID="txtCity" runat="server" placeholder="City"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="commission" class="form-label mt-4">Commission</label>
            <asp:TextBox class="form-control" ID="txtCommission" runat="server" placeholder="Commission"></asp:TextBox>
        </div>
        <div class="form-group pt-5">
            <asp:Button CssClass="btn btn-primary" ID="btnSubmit" runat="server" Text="Add Salesman" OnClick="btnSubmit_Click">

            </asp:Button>
        </div>
    </fieldset>
    <div class="d-grid gap-2">
        <button class="btn btn-lg btn-info" type="button"><strong>EXISTING SALESMEN</strong></button>
    </div>
        <asp:GridView ID="GVSalesman" runat="server"></asp:GridView>
        <asp:PlaceHolder ID = "PlaceHolder1" runat="server" />

</asp:Content>
