using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class department : System.Web.UI.Page
{
    EmpManagementClassesDataContext ins;
    EmpManagementClassesDataContext disp;
    EmpManagementClassesDataContext del;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            show();
        }

    }
    protected void clear()
    {
        txt_dept_id.Text = "";
        txt_dept_name.Text = "";
    }
    protected void show()
    {
        disp = new EmpManagementClassesDataContext();
        var show = from Department in disp.Departments
                select Department;
        GridView1.DataSource = show;
        GridView1.DataBind();

    }
    protected void btn_insert_dept_Click(object sender, EventArgs e)
    {
        try
        {
            ins = new EmpManagementClassesDataContext();

            Department d = new Department();
            d.dept_id = Convert.ToInt16(txt_dept_id.Text);
            d.dept_name =txt_dept_name.Text;

            ins.Departments.InsertOnSubmit(d);
            ins.SubmitChanges();

          
            Response.Write("<script>alert('Department Added Successfully')</script>");
            show();
            txt_dept_id.Text = "";
            txt_dept_name.Text = "";
           

        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex + "')</script>");
        }

        //cl = new DataClassesDataContext();
        //var s = from Class in cl.Classes
        //        where Class.class_id == Convert.ToInt16(txt_class_id.Text)
        //        select Class;

        //if (s.Count() > 0)
        //{
        //    Class st = s.First();
        //    txt_class_name.Text = st.class_name;
        //}
        //else
        //{
        //    Response.Write("<script>alert('No student data for given Roll No')</script>");
        //}
    }

    protected void btn_delete_Click(object sender, EventArgs e)
    {
        
        try
        {
            del = new EmpManagementClassesDataContext();
            Department dld = del.Departments.Single(d => d.dept_id == Convert.ToInt32(txt_dept_id.Text));
            del.Departments.DeleteOnSubmit(dld);
            del.SubmitChanges();
            Response.Write("<script>alert('Department Deleted')</script>");
            show();

            txt_dept_id.Text = "";
            txt_dept_name.Text = "";
        }
         catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex + "')</script>");
        }
    }
}