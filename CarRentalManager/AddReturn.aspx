<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddReturn.aspx.cs" Inherits="CarRentalManager.AddReturn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ValidationSummary runat="server" ShowModelStateErrors="true" />
    <asp:FormView runat="server" ID="addReturnForm"
        ItemType="CarRentalManager.Models.RETURN" 
        InsertMethod="addReturnForm_InsertItem" DefaultMode="Insert"
        RenderOuterTable="false" OnItemInserted="addReturnForm_ItemInserted">
        <InsertItemTemplate>
            <fieldset>
                <ol>
                    <asp:DynamicEntity runat="server" Mode="Insert" />
                </ol>
                <asp:Button runat="server" Text="Insert" CommandName="Insert" />
                <asp:Button runat="server" Text="Cancel" CausesValidation="false" OnClick="onCancel_Click" />
            </fieldset>
        </InsertItemTemplate>
    </asp:FormView>
</asp:Content>
