<%@ Page Title="" Language="C#" MasterPageFile="~/Employee.master" AutoEventWireup="true" CodeFile="department.aspx.cs" Inherits="department" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" Runat="Server">
      <br />
     <h2 align="center" style="font-family: system-ui;">Department Page</h2>
    <br />

     <div style="margin: 1rem;padding: 2rem 2rem;text-align: center;">
        <div style="display: inline-block;padding: 1rem 1rem;vertical-align: middle;">
            <table style="width: 111%; height: 75px;">
        <tr>
            <td style="text-align: right">
                <asp:Label ID="Label1" runat="server" Text="Dept Id : "></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="txt_dept_id" runat="server" AutoPostBack="True" TextMode="Number"></asp:TextBox>
            </td>
            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Enter department Id" ControlToValidate="txt_dept_id" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="text-align: right">
                <asp:Label ID="Label2" runat="server" Text="Dept Name : "></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="txt_dept_name" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please enter Department Name" ControlToValidate="txt_dept_name" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>
        
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">
                <asp:Button ID="btn_insert_dept" runat="server" Text="Insert" Width="168px" OnClick="btn_insert_dept_Click" />
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

