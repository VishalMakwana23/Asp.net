<%@ Page Title="" Language="C#" MasterPageFile="~/Employee.master" AutoEventWireup="true" CodeFile="deleteEmp.aspx.cs" Inherits="deleteEmp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" Runat="Server">
 <br />
     <h2 align="center" style="font-family: system-ui;">Delete Employee Page</h2>
    <br />

     <div style="margin: 1rem;padding: 2rem 2rem;text-align: center;">
        <div style="display: inline-block;padding: 1rem 1rem;vertical-align: middle;">
            <table style="width: 111%; height: 75px;">

        <tr>
            <td>Delete employee  age > 58 </td>
            <td class="auto-style1">
                <asp:Button ID="btn_delete" runat="server" Text="delete" Width="81px" OnClick="btn_delete_Click"  />
            </td>
            <td>&nbsp;</td>
        </tr>

        <tr><td></td><td></td><td></td></tr>
         <tr>
            <td style="text-align: right">
                <asp:Label ID="Label1" runat="server" Text="Roll No : "></asp:Label>
             </td>
            <td><asp:TextBox ID="txt_eno" runat="server"></asp:TextBox></td>
            <td>&nbsp;</td>
        </tr>
     
        <tr>  
            <td></td>       
            <td ><asp:Button ID="Button_delete" runat="server" Text="Delete By Roll Number" Width="170px" OnClick="Button_delete_Click"   /></td>
            <td></td>
        </tr>


    </table>
        </div>

        <div style="display: inline-block;padding: 1rem 1rem;vertical-align: middle;">
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>

    </div>
</asp:Content>

