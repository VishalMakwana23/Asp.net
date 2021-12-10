﻿<%@ Page Title="" Language="C#" MasterPageFile="~/StudentManagement.master" AutoEventWireup="true" CodeFile="findStud.aspx.cs" Inherits="findStud" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" Runat="Server">
    <br />
     <h2 align="center" style="font-family: system-ui;">Find Student</h2>
    <br />

     <div style="margin: 1rem;padding: 2rem 2rem;text-align: center;">
        <div style="display: inline-block;padding: 1rem 1rem;vertical-align: middle;">
            <table style="width: 100%; height: 75px;">
        <tr>
            <td style="text-align: right">
                <asp:Label ID="Label1" runat="server" Text="Name : "></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="txt_name" runat="server" AutoPostBack="True"></asp:TextBox>
            </td>
            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Enter Name" ControlToValidate="txt_name" ForeColor="Red" EnableTheming="True"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="text-align: right">
                <asp:Label ID="Label2" runat="server" Text="Course name : "></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:DropDownList ID="Course_drop" runat="server" DataSourceID="LinqDataSource1" DataTextField="course_name" DataValueField="course_name" Height="27px" Width="169px">
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
                <asp:Button ID="btn_find_stud" runat="server" Text="Find" Width="168px" OnClick="btn_find_click" CausesValidation="False" />
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

