using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class findStud : System.Web.UI.Page
{
    studDataClassesDataContext upd;
    studDataClassesDataContext disp;
    studDataClassesDataContext src;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            show();
        }

    }

    protected void show()
    {
        try
        {
            disp = new studDataClassesDataContext();
            var show = from student in disp.students
                       select student;
            GridView1.DataSource = show;
            GridView1.DataBind();
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex + "')</script>");
        }
    }
    protected void clear()
    {
        txt_name.Text = "";
 
    }

    protected void btn_find_click(object sender, EventArgs e)
    {
        try
        {
            disp = new studDataClassesDataContext();
            var f = from student in disp.students
                    where student.name == txt_name.Text && student.course == Course_drop.SelectedValue
                    select student;

            
            GridView1.DataSource = f;
            GridView1.DataBind();
            clear();


        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex + "')</script>");
        }
    }
}