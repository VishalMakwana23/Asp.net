using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class Course : System.Web.UI.Page
{

    studDataClassesDataContext ins;
    studDataClassesDataContext disp;
    studDataClassesDataContext del;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            show();
        }
    }

    protected void clear()
    {
        txt_course_id.Text = "";
        txt_course_name.Text = "";
    }
    protected void show()
    {
        disp = new studDataClassesDataContext();
        var show = from student in disp.courses
                   select student;
        GridView1.DataSource = show;
        GridView1.DataBind();

    }
    protected void btn_insert_course_Click(object sender, EventArgs e)
    {
        try
        {
            ins = new studDataClassesDataContext();

            course cr = new course();
            cr.course_id = Convert.ToInt16(txt_course_id.Text);
            cr.course_name = txt_course_name.Text;

            ins.courses.InsertOnSubmit(cr);
            ins.SubmitChanges();


            Response.Write("<script>alert('Course Added Successfully')</script>");
            show();
            clear();


        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex + "')</script>");
        }
    }

    protected void btn_delete_Click(object sender, EventArgs e)
    {
        try
        {
            del = new studDataClassesDataContext();
            course dlcr = del.courses.Single(d => d.course_id == Convert.ToInt32(txt_course_id.Text));
            del.courses.DeleteOnSubmit(dlcr);
            del.SubmitChanges();
            Response.Write("<script>alert('Course Deleted')</script>");
            show();
            clear();
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex + "')</script>");
        }
    }
}