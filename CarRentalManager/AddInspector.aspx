<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddInspector.aspx.cs" Inherits="CarRentalManager.AddInspector" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ValidationSummary runat="server" ShowModelStateErrors="true" />
    <asp:FormView runat="server" ID="addInspectorForm"
        ItemType="CarRentalManager.Models.INSPECTOR" 
        InsertMethod="addInspectorForm_InsertItem" DefaultMode="Insert"
        RenderOuterTable="false" OnItemInserted="addInspectorForm_ItemInserted">
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
