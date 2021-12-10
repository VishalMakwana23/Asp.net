using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class updateEmp : System.Web.UI.Page
{

    EmpManagementClassesDataContext src;
    EmpManagementClassesDataContext disp;
    EmpManagementClassesDataContext upd;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            show();
        }
    }
    protected void clear()
    {
        txt_emp_id.Text = "";
        txt_salary.Text = "";
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
        src = new EmpManagementClassesDataContext();
        var s = from Emp in src.Emps
                where Emp.eno == Convert.ToInt16(txt_emp_id.Text)
                select Emp;

        if (s.Count() > 0)
        {
            Emp st = s.First();

            //DropDownList1.Items.Clear();
            //DropDownList2.Items.Clear();
            //DropDownList1.SelectedValue = st.designation.ToString(); 
            //DropDownList2.SelectedValue = st.dept.ToString();
            txt_salary.Text = st.salary;
        }
        else
        {
            Response.Write("<script>alert('No Employee data for given Emp No')</script>");
        }
    }


    protected void btn_update_Click(object sender, EventArgs e)
    {

        try
        {
            upd = new EmpManagementClassesDataContext();
            Emp uemp = upd.Emps.Single(em => em.eno == Convert.ToInt16(txt_emp_id.Text));
            uemp.designation = DropDownList1.SelectedValue;
            uemp.dept = DropDownList2.SelectedValue;
            uemp.salary = txt_salary.Text;
            upd.SubmitChanges();
            show();
            clear();
            Response.Write("<script>alert('Employee Detail Updated');</script>");
            show();
            clear();

        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex + "')</script>");
        }
    }
}