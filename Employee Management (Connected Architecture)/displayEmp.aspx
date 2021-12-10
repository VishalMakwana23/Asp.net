<%@ Page Title="" Language="C#" MasterPageFile="~/Employee.master" AutoEventWireup="true" CodeFile="displayEmp.aspx.cs" Inherits="displayEmp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" Runat="Server">
    <br />
     <h2 align="center" style="font-family: system-ui;">Display All Employee Page</h2>
    <br />
     <div style="margin: 1rem;padding: 2rem 2rem;text-align: center;">
        <div style="display: inline-block;padding: 1rem 1rem;vertical-align: middle;">
               <asp:GridView runat="server" ID="grvDocuments" Width="100%" CssClass="table table-bordered"
            AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="eno" HeaderText="eno" SortExpression="eno" />
                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                <asp:BoundField DataField="dob" HeaderText="dob" SortExpression="dob" />
                <asp:BoundField DataField="designation" HeaderText="designation" SortExpression="designation" />
                <asp:BoundField DataField="dept" HeaderText="dept" SortExpression="dept" />
                <asp:BoundField DataField="salary" HeaderText="salary" SortExpression="salary" />
                <asp:BoundField DataField="cv" HeaderText="cv" SortExpression="cv" />
                
                <asp:HyperLinkField DataNavigateUrlFields="cv" HeaderText="View" Target="_blank" Text="View" />
                
            </Columns>
        </asp:GridView>
               <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:mycn %>" SelectCommand="SELECT * FROM [Emp]"></asp:SqlDataSource>
        </div>
    </div>
</asp:Content>

