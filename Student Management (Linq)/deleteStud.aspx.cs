using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
public partial class deleteStud : System.Web.UI.Page
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
        txt_roll_no.Text = "";
       
      
    }
    protected void show()
    {
        disp = new studDataClassesDataContext();
        var show = from student in disp.students
                   select student;
        GridView1.DataSource = show;
        GridView1.DataBind();
    }

    protected void btn_delete_stud_Click(object sender, EventArgs e)
    {
        try
        {
            del = new studDataClassesDataContext();
            student dlstud = del.students.Single(d => d.rollno == Convert.ToInt32(txt_roll_no.Text) && d.course == Course_drop.SelectedValue);
            del.students.DeleteOnSubmit(dlstud);
            del.SubmitChanges();
            Response.Write("<script>alert('Student Deleted')</script>");
            show();
            clear();
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex + "')</script>");
        }
    }
}