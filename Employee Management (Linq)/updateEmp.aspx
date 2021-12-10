<%@ Page Title="" Language="C#" MasterPageFile="~/Employee.master" AutoEventWireup="true" CodeFile="updateEmp.aspx.cs" Inherits="updateEmp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" Runat="Server">
     <br />
     <h2 align="center" style="font-family: system-ui;">Update Employee Page</h2>
    <br />

    <div style="margin: 1rem;padding: 2rem 2rem;text-align: center;">
        <div style="display: inline-block;padding: 1rem 1rem;vertical-align: middle;">
            <table style="width: 111%; height: 75px;">
        <tr>
            <td style="text-align: right">
                <asp:Label ID="Label1" runat="server" Text="Emp Id : "></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="txt_emp_id" runat="server" AutoPostBack="True"></asp:TextBox>
            </td>
            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Enter employee Id" ControlToValidate="txt_emp_id" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="text-align: right">
                <asp:Label ID="Label2" runat="server" Text="Designation : "></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="LinqDataSource1" DataTextField="desg_name" DataValueField="desg_name" Height="18px" Width="168px">
                </asp:DropDownList>
                <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="EmpManagementClassesDataContext" EntityTypeName="" Select="new (desg_name)" TableName="Designations">
                </asp:LinqDataSource>
            </td>
            <td>
                &nbsp;</td>
        </tr>
         <tr>
            <td style="text-align: right">
                <asp:Label ID="Label3" runat="server" Text="Department : "></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="LinqDataSource2" DataTextField="dept_name" DataValueField="dept_name" Height="16px" Width="168px">
                </asp:DropDownList>
                <asp:LinqDataSource ID="LinqDataSource2" runat="server" ContextTypeName="EmpManagementClassesDataContext" EntityTypeName="" Select="new (dept_name)" TableName="Departments">
                </asp:LinqDataSource>
            </td>
            <td>
                &nbsp;</td>
        </tr>
         <tr>
            <td style="text-align: right">
                <asp:Label ID="Label4" runat="server" Text="Salary : "></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="txt_salary" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please enter Salary" ControlToValidate="txt_salary" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>
        
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">
                <asp:Button ID="btn_search" runat="server" Text="Search" Width="81px" CausesValidation="False" OnClick="btn_search_Click" />
            &nbsp;&nbsp;
                <asp:Button ID="btn_update" runat="server" Text="Update" Width="81px" OnClick="btn_update_Click"  />
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

