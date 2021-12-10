<%@ Page Title="" Language="C#" MasterPageFile="~/StudentManagement.master" AutoEventWireup="true" CodeFile="Student.aspx.cs" Inherits="Student" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 207px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" Runat="Server">
    <br />
     <h2 align="center" style="font-family: system-ui;">Student Page</h2>
    <br />

     <div style="margin: 1rem;padding: 2rem 2rem;">
        <div style="display: inline-block;padding: 1rem 1rem;vertical-align: middle;">
             <table style="width: 101%; height: 75px;">
        <tr>
            <td style="text-align: right">
                <asp:Label ID="Label1" runat="server" Text="Enroll No : "></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="txt_enroll_no" runat="server" AutoPostBack="True" Width="180px"></asp:TextBox>
            </td>
            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Enter Enroll No" ControlToValidate="txt_enroll_no" ForeColor="Red" style="text-align: left"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="text-align: right">
                <asp:Label ID="Label2" runat="server" Text="Roll No : "></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="txt_roll_no" runat="server" Width="180px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please enter Roll No" ControlToValidate="txt_roll_no" ForeColor="Red" style="text-align: left"></asp:RequiredFieldValidator></td>
        </tr>
          <tr>
            <td style="text-align: right">
                <asp:Label ID="Label3" runat="server" Text="Name : "></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="txt_name" runat="server" Width="180px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please enter Name" ControlToValidate="txt_name" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>
          <tr>
            <td style="text-align: right">
                <asp:Label ID="Label4" runat="server" Text="Class : "></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="class_name" DataValueField="class_name" Height="26px" Width="189px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:mycn %>" SelectCommand="SELECT [class_name] FROM [Class]"></asp:SqlDataSource>
            </td>
            <td>
                &nbsp;</td>
        </tr>
          <tr>
            <td style="text-align: right">
                <asp:Label ID="Label5" runat="server" Text="Course : "></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="course_name" DataValueField="course_name" Height="25px" Width="187px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:mycn %>" SelectCommand="SELECT [course_name] FROM [Course]"></asp:SqlDataSource>
            </td>
            <td>
                &nbsp;</td>
        </tr>
          <tr>
            <td style="text-align: right">
                <asp:Label ID="Label6" runat="server" Text="Email : "></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="txt_email" runat="server" Width="180px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Please enter Email" ControlToValidate="txt_email" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txt_email" ErrorMessage="Invalid Email !" ForeColor="Blue" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
              </td>
        </tr>
          <tr>
            <td style="text-align: right">
                <asp:Label ID="Label7" runat="server" Text="Mobile : "></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="txt_mobile" runat="server" Width="180px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Please enter Mobile" ControlToValidate="txt_mobile" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txt_mobile" ErrorMessage="Invalid Mobile No !" ForeColor="Blue" ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
              </td>
        </tr>
          <tr>
            <td style="text-align: right">
                <asp:Label ID="Label8" runat="server" Text="DOB : "></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="txt_dob" runat="server" TextMode="Date" ClearTime="true" Width="180px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Please enter Date Of Birth" ControlToValidate="txt_dob" ForeColor="Red"></asp:RequiredFieldValidator></td>
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
            <td class="auto-style1"><asp:Button ID="btn_display" runat="server" Text="Display" OnClick="btn_display_Click" Width="185px" CausesValidation="False" />
                <br />
                <asp:Button ID="btn_display_birth" runat="server" Text="Birth Wise List" Width="185px" CausesValidation="False" OnClick="btn_display_birth_Click" /></td>

        </tr>
    </table>
        </div>

        <div style="display: inline-block;padding: 1rem 1rem;vertical-align: middle;">
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </div>

    </div>


    
</asp:Content>

