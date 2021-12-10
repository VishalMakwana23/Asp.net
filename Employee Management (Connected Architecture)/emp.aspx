<%@ Page Title="" Language="C#" MasterPageFile="~/Employee.master" AutoEventWireup="true" CodeFile="emp.aspx.cs" Inherits="emp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 236px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" Runat="Server">
      <br />
     <h2 align="center" style="font-family: system-ui;">Employee Page</h2>
    <br />

     <div style="margin: 1rem;padding: 2rem 2rem;">
        <div style="display: inline-block;padding: 1rem 1rem;vertical-align: middle;">
             <table style="width: 101%; height: 75px;">
        <tr>
            <td style="text-align: right">
                <asp:Label ID="Label1" runat="server" Text="Employee No : "></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="txt_emp_no" runat="server" AutoPostBack="True" Width="180px" TextMode="Number"></asp:TextBox>
            </td>
            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Enter Employee No" ControlToValidate="txt_emp_no" ForeColor="Red" style="text-align: left"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="text-align: right">
                <asp:Label ID="Label2" runat="server" Text="Name : "></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="txt_name" runat="server" Width="180px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please enter Name" ControlToValidate="txt_name" ForeColor="Red" style="text-align: left"></asp:RequiredFieldValidator></td>
        </tr>
          <tr>
            <td style="text-align: right">
                <asp:Label ID="Label3" runat="server" Text="D.O.B : "></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="txt_dob" runat="server" TextMode="Date"   Width="180px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please enter D.O.B" ControlToValidate="txt_dob" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>
          <tr>
            <td style="text-align: right">
                <asp:Label ID="Label4" runat="server" Text="Designation : "></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:DropDownList ID="DropDownList_desg" runat="server" Height="16px" Width="180px" DataSourceID="SqlDataSource1" DataTextField="desg_name" DataValueField="desg_name">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:mycn %>" SelectCommand="SELECT [desg_name] FROM [Designation]"></asp:SqlDataSource>
            </td>
            <td>
                &nbsp;</td>
        </tr>
          <tr>
            <td style="text-align: right">
                <asp:Label ID="Label5" runat="server" Text="Department : "></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:DropDownList ID="DropDownList_dept" runat="server" Height="16px" Width="181px" DataSourceID="SqlDataSource2" DataTextField="dept_name" DataValueField="dept_name">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:mycn %>" SelectCommand="SELECT [dept_name] FROM [Department]"></asp:SqlDataSource>
            </td>
            <td>
                &nbsp;</td>
        </tr>
          <tr>
            <td style="text-align: right">
                <asp:Label ID="Label6" runat="server" Text="Salary : "></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="txt_salary" runat="server" Width="180px" TextMode="Number"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Please enter Salary" ControlToValidate="txt_salary" ForeColor="Red"></asp:RequiredFieldValidator>
              </td>
        </tr>
          <tr>
            <td style="text-align: right">
                <asp:Label ID="Label7" runat="server" Text="CV : "></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:FileUpload ID="cvupload" runat="server" Width="184px" accept=".pdf" />
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Please Uplaod CV" ControlToValidate="cvUpload" ForeColor="Red"></asp:RequiredFieldValidator>
              </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">
                <br />
                <asp:Button ID="btn_insert" runat="server" Text="Insert" Width="85px" OnClick="btn_insert_Click" /> 
                &nbsp;&nbsp;&nbsp;&nbsp; 
                <asp:Button ID="btn_search" runat="server" Text="Search" CausesValidation="False" OnClick="btn_search_Click" Width="85px" />
                <br />
                <asp:Button ID="btn_update" runat="server" Text="Update" CausesValidation="False" OnClick="btn_update_Click" Width="85px" />
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btn_delete" runat="server" Text="Delete" CausesValidation="False" OnClick="btn_delete_Click" Width="85px" />
            </td>
            
        </tr>
        <tr> 
            <td></td>
            <td class="auto-style1"><asp:Button ID="btn_display" runat="server" Text="Display All Employee" OnClick="btn_display_Click" Width="196px" CausesValidation="False" /></td>

        </tr>
    </table>
        </div>

        <div style="display: inline-block;padding: 1rem 1rem;vertical-align: middle;">
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </div>

    </div>
</asp:Content>

