using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
public partial class birthDisplay : System.Web.UI.Page
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
    protected void show()
    {
        disp = new studDataClassesDataContext();
        var show = from student in disp.students
                   select student;
        GridView1.DataSource = show;
        GridView1.DataBind();
    }

    protected void btn_display_Click(object sender, EventArgs e)
    {
     

        try
        {
            //string year = DateTime.Parse(txt_dob.Text).ToString("yyyy");
            disp = new studDataClassesDataContext();
            var f = from student in disp.students
                    where student.dob == txt_dob.Text
                    select student;
            GridView1.DataSource = f;
            GridView1.DataBind();
            


        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex + "')</script>");
        }
    }
}