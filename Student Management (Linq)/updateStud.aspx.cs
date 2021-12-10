using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class updateStud : System.Web.UI.Page
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

    protected void clear()
    {
        txt_enroll_no.Text = "";
        txt_email.Text = "";
        txt_mobile.Text = "";
        txt_dob.Text = "";
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

   

    protected void btn_search_stud_Click(object sender, EventArgs e)
    {
        src = new studDataClassesDataContext();
        var s = from student in src.students
                where student.enrollno == Convert.ToInt16(txt_enroll_no.Text)
                select student;

        if (s.Count() > 0)
        {
            student st = s.First();
            txt_email.Text = st.email;
            txt_mobile.Text = st.mobile;
            txt_dob.Text = st.dob;
        }
        else
        {
            Response.Write("<script>alert('No Student data for given Enroll No')</script>");
        }
    }

    protected void btn_update_stud_Click(object sender, EventArgs e)
    {
        try
        {
            upd = new studDataClassesDataContext();
            student ustud = upd.students.Single(em => em.enrollno == Convert.ToInt16(txt_enroll_no.Text));
            ustud.email = txt_email.Text;
            ustud.mobile = txt_mobile.Text;
            ustud.dob = txt_dob.Text;
            upd.SubmitChanges();
            show();
            clear();
            Response.Write("<script>alert('Student Detail Updated');</script>");
            show();
            clear();

        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex + "')</script>");
        }
    }
}