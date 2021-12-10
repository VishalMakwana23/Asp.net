using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class findEmp : System.Web.UI.Page
{
    EmpManagementClassesDataContext find;
    EmpManagementClassesDataContext disp;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            show();
        }
    }
    protected void show()
    {
        disp = new EmpManagementClassesDataContext();
        var show = from Emp in disp.Emps
                   select Emp;
        GridView1.DataSource = show;
        GridView1.DataBind();

    }

    protected void btn_search_Click(object sender, EventArgs e)
    {

        try
        {
            disp = new EmpManagementClassesDataContext();
            var f = from Emp in disp.Emps
                    where Emp.designation == DropDownList1.SelectedValue
                    select Emp;
            GridView1.DataSource = f;
            GridView1.DataBind();
            txt_salary.Text = "";
            

        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex + "')</script>");
        }
    }
}