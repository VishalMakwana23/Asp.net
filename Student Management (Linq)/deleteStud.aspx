<%@ Page Title="" Language="C#" MasterPageFile="~/StudentManagement.master" AutoEventWireup="true" CodeFile="deleteStud.aspx.cs" Inherits="deleteStud" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" Runat="Server">
    <br />
     <h2 align="center" style="font-family: system-ui;">Delete Student Page</h2>
    <br />
    <div style="margin: 1rem;padding: 2rem 2rem;text-align: center;">
        <div style="display: inline-block;padding: 1rem 1rem;vertical-align: middle;">
            <table style="width: 100%; height: 75px;">
        <tr>
            <td style="text-align: right">
                <asp:Label ID="Label1" runat="server" Text="Roll No : "></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="txt_roll_no" runat="server" AutoPostBack="True"></asp:TextBox>
            </td>
            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Enter Roll Number" ControlToValidate="txt_roll_no" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="text-align: right">
                <asp:Label ID="Label2" runat="server" Text="Course : "></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:DropDownList ID="Course_drop" runat="server" DataSourceID="LinqDataSource1" DataTextField="course_name" DataValueField="course_name" Width="167px">
                </asp:DropDownList>
                <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="studDataClassesDataContext" EntityTypeName="" Select="new (course_name)" TableName="courses">
                </asp:LinqDataSource>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">
                <asp:Button ID="btn_delete_stud" runat="server" Text="Delete" Width="90px" OnClick="btn_delete_stud_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
        </div>

        <div style="display: inline-block;padding: 1rem 1rem;vertical-align: middle;">
            <asp:GridView ID="GridView1" runat="server" align="center"></asp:GridView>
        </div>

</asp:Content>

