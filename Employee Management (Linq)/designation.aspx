<%@ Page Title="" Language="C#" MasterPageFile="~/Employee.master" AutoEventWireup="true" CodeFile="designation.aspx.cs" Inherits="designation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" Runat="Server">
     <br />
     <h2 align="center" style="font-family: system-ui;">Designation Page</h2>
    <br />

     <div style="margin: 1rem;padding: 2rem 2rem;text-align: center;">
        <div style="display: inline-block;padding: 1rem 1rem;vertical-align: middle;">
            <table style="width: 111%; height: 75px;">
        <tr>
            <td style="text-align: right">
                <asp:Label ID="Label1" runat="server" Text="Designation Id : "></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="txt_desg_id" runat="server" AutoPostBack="True" TextMode="Number"></asp:TextBox>
            </td>
            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Enter Designation Id" ControlToValidate="txt_desg_id" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="text-align: right">
                <asp:Label ID="Label2" runat="server" Text="Designation Name : "></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="txt_desg_name" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage=" enter designation Name" ControlToValidate="txt_desg_name" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>
        
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">
                <asp:Button ID="btn_insert_designation" runat="server" Text="Insert" Width="83px" OnClick="btn_insert_designation_Click"  />
                <asp:Button ID="btn_delete" runat="server" Text="Delete" Width="83px" CausesValidation="False" OnClick="btn_delete_Click"  />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
        </div>

        <div style="display: inline-block;padding: 1rem 1rem;vertical-align: middle;">
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>

    </div>
</asp:Content>

