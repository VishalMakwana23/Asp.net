<%@ Page Title="" Language="C#" MasterPageFile="~/Employee.master" AutoEventWireup="true" CodeFile="findEmp.aspx.cs" Inherits="findEmp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" Runat="Server">
     <br />
     <h2 align="center" style="font-family: system-ui;">Find Employee Page</h2>
    <br />
    <div style="margin: 1rem;padding: 2rem 2rem;text-align: center;">
        <div style="display: inline-block;padding: 1rem 1rem;vertical-align: middle;">
            <table style="width: 111%; height: 75px;">
        <tr>
            <td style="text-align: right">
                <asp:Label ID="Label1" runat="server" Text="Salary : "></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="txt_salary" runat="server" AutoPostBack="True"></asp:TextBox>
            </td>
            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Enter Salary" ControlToValidate="txt_salary" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="text-align: right">
                <asp:Label ID="Label2" runat="server" Text="Designation : "></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="LinqDataSource1" DataTextField="desg_name" DataValueField="desg_name" Height="16px" Width="168px">
                </asp:DropDownList>
                <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="EmpManagementClassesDataContext" EntityTypeName="" Select="new (desg_name)" TableName="Designations">
                </asp:LinqDataSource>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">
                <asp:Button ID="btn_search" runat="server" Text="Search" Width="81px" CausesValidation="False" OnClick="btn_search_Click" />
            
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

