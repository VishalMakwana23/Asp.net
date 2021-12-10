using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


public partial class Student : System.Web.UI.Page
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
        txt_enroll_no.Text = "";
        txt_roll_no.Text = "";
        txt_name.Text = "";
        txt_email.Text = "";
        txt_mobile.Text = "";
        txt_dob.Text = "";
    } 
    protected void show()
    {
        disp = new studDataClassesDataContext();
        var show = from student in disp.students
                   select student;
        GridView1.DataSource = show;
        GridView1.DataBind();
    }
    protected void btn_insert_course_Click(object sender, EventArgs e)
    {
        try
        {
            ins = new studDataClassesDataContext();

            student stud = new student();
            stud.enrollno = Convert.ToInt16(txt_enroll_no.Text);
            stud.rollno = Convert.ToInt16(txt_roll_no.Text);
            stud.name = txt_name.Text;
            stud.@class = Class_drop.SelectedValue;
            stud.course = Course_drop.SelectedValue;
            stud.email = txt_email.Text;
            stud.mobile = txt_mobile.Text;
            stud.dob = txt_dob.Text;

            ins.students.InsertOnSubmit(stud);
            ins.SubmitChanges();


            Response.Write("<script>alert('Student Added Successfully')</script>");
            show();
            clear();


        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex + "')</script>");
        }
    }

    protected void btn_display_Click(object sender, EventArgs e)
    {
        clear();
        show();
    }

    protected void btn_search_Click(object sender, EventArgs e)
    {
        Response.Redirect("findStud.aspx");
    }

    protected void btn_update_Click(object sender, EventArgs e)
    {

       
        Response.Redirect("updateStud.aspx");
    }

    protected void btn_delete_Click(object sender, EventArgs e)
    {
      
        Response.Redirect("deleteStud.aspx");
    }

    protected void btn_display_birth_Click(object sender, EventArgs e)
    {
        Response.Redirect("birthDisplay.aspx");
    }
}