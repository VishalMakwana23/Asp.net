using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


public partial class _Class : System.Web.UI.Page
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
        txt_class_id.Text = "";
        txt_class_name.Text = "";
    }
    protected void show()
    {
        disp = new studDataClassesDataContext();
        var show = from student in disp.classes
                   select student;
        GridView1.DataSource = show;
        GridView1.DataBind();

    }
    protected void btn_insert_class_Click(object sender, EventArgs e)
    {
        try
        {
            ins = new studDataClassesDataContext();

            @class cl = new @class();
            cl.class_id = Convert.ToInt16(txt_class_id.Text);
            cl.course_id = Convert.ToInt16(DropDownList_course_d.SelectedValue);
            cl.class_name = txt_class_name.Text;

            ins.classes.InsertOnSubmit(cl);
            ins.SubmitChanges();


            Response.Write("<script>alert('Class Added Successfully')</script>");
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
            @class dlcl = del.classes.Single(d => d.class_id == Convert.ToInt32(txt_class_id.Text));
            del.classes.DeleteOnSubmit(dlcl);
            del.SubmitChanges();
            Response.Write("<script>alert('Class Deleted')</script>");
            show();
            clear();
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex + "')</script>");
        }
    }
}