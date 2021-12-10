<%@ Page Title="" Language="C#" MasterPageFile="~/StudentManagement.master" AutoEventWireup="true" CodeFile="updateStud.aspx.cs" Inherits="updateStud" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" Runat="Server">
    <br />
     <h2 align="center" style="font-family: system-ui;">Update Student Page</h2>
    <br />

      <div style="margin: 1rem;padding: 2rem 2rem;text-align: center;">
        <div style="display: inline-block;padding: 1rem 1rem;vertical-align: middle;">
            <table style="width: 100%; height: 75px;">
        <tr>
            <td style="text-align: right">
                <asp:Label ID="Label1" runat="server" Text="Enroll No : "></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="txt_enroll_no" runat="server" AutoPostBack="True"></asp:TextBox>
            </td>
            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Enter Enroll Number" ControlToValidate="txt_enroll_no" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="text-align: right">
                <asp:Label ID="Label2" runat="server" Text="Email : "></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="txt_email" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Please enter Email" ControlToValidate="txt_email" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txt_email" ErrorMessage="Invalid Email !" ForeColor="Blue" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></td>
        </tr>
        <tr>
            <td style="text-align: right">
                <asp:Label ID="Label3" runat="server" Text="Mobile : "></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="txt_mobile" runat="server"></asp:TextBox>
            </td>
            <td>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Please enter Mobile" ControlToValidate="txt_mobile" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txt_mobile" ErrorMessage="Invalid Mobile No !" ForeColor="Blue" ValidationExpression="\d{10}"></asp:RegularExpressionValidator></td>
        </tr>
        <tr>
            <td style="text-align: right">
                <asp:Label ID="Label4" runat="server" Text="DOB : "></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="txt_dob" runat="server" TextMode="Date" ClearTime="true" Width="168px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please enter DOB" ControlToValidate="txt_dob" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">
                <asp:Button ID="btn_search_stud" runat="server" Text="Search" Width="90px" CausesValidation="False" OnClick="btn_search_stud_Click" />
                <asp:Button ID="btn_update_stud" runat="server" Text="Update" Width="90px" OnClick="btn_update_stud_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
        </div>

        <div style="display: inline-block;padding: 1rem 1rem;vertical-align: middle;">
            <asp:GridView ID="GridView1" runat="server" align="center"></asp:GridView>
        </div>


</asp:Content>

