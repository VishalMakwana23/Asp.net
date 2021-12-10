<%@ Page Title="" Language="C#" MasterPageFile="~/StudentManagement.master" AutoEventWireup="true" CodeFile="Class.aspx.cs" Inherits="_Class" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 186px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" Runat="Server">
    <br />
    <h2 align="center" style="font-family: system-ui;">Class Page</h2>
    <br />
 

     <div style="margin: 1rem;padding: 2rem 2rem;text-align: center;">
        <div style="display: inline-block;padding: 1rem 1rem;vertical-align: middle;">
            <table style="width: 111%; height: 75px;">
        <tr>
            <td style="text-align: right">
                <asp:Label ID="Label1" runat="server" Text="Class Id : "></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="txt_class_id" runat="server" AutoPostBack="True"></asp:TextBox>
            </td>
            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Enter Course id" ControlToValidate="txt_class_id" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="text-align: right">
                <asp:Label ID="Label2" runat="server" Text="Course Id : "></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="course_id" DataValueField="course_id">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:mycn %>" SelectCommand="SELECT [course_id] FROM [Course]"></asp:SqlDataSource>
            </td>
            <td>
                &nbsp;</td>
        </tr>
         <tr>
            <td style="text-align: right">
                <asp:Label ID="Label3" runat="server" Text="Class Name : "></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="txt_class_name" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please enter Classname" ControlToValidate="txt_class_name" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">
                <asp:Button ID="btn_insert" runat="server" Text="Insert" Width="85px" OnClick="btn_insert_Click" />
            &nbsp;
                <asp:Button ID="btn_delete" runat="server" Text="Delete" Width="85px" CausesValidation="False" OnClick="btn_delete_Click" />
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

