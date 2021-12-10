<%@ Page Title="" Language="C#" MasterPageFile="~/StudentManagement.master" AutoEventWireup="true" CodeFile="birthDisplay.aspx.cs" Inherits="birthDisplay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            height: 34px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" Runat="Server">
      <br />
     <h2 align="center" style="font-family: system-ui;">List of students whose birth date is in specific year.</h2>
    <br />

      <div style="margin: 1rem;padding: 2rem 2rem;text-align: center;">
        <div style="display: inline-block;padding: 1rem 1rem;vertical-align: middle;">
            <table style="width: 100%; height: 75px;">
      
        <tr>
            <td style="text-align: right" class="auto-style1">
                <asp:Label ID="Label4" runat="server" Text="DOB : "></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="txt_dob" runat="server" Width="168px"></asp:TextBox>
            </td>
            <td class="auto-style1">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please enter Year" ControlToValidate="txt_dob" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">
                
                <asp:Button ID="btn_display" runat="server" Text="Display" Width="90px" OnClick="btn_display_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
        </div>

        <div style="display: inline-block;padding: 1rem 1rem;vertical-align: middle;">
            <asp:GridView ID="GridView1" runat="server" align="center"></asp:GridView>
        </div>
    </div>
</asp:Content>

