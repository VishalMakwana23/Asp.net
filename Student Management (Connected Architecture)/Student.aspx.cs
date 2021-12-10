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

    SqlConnection cn;
    SqlCommand cmd;
    SqlDataReader rd;
    string str;
    protected void Page_Load(object sender, EventArgs e)
    {
        cn = new SqlConnection(ConfigurationManager.ConnectionStrings["mycn"].ConnectionString);
        cmd = new SqlCommand();
        show();
        
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
        try
        {
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Students", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            cn.Close();
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex + "')</script>");
        }
    }
    protected void btn_insert_course_Click(object sender, EventArgs e)
    {
        try
        {

            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["mycn"].ConnectionString);
            cmd = new SqlCommand();
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            string dobDate = Convert.ToDateTime(txt_dob.Text).ToString("dd-MM-yyyy");
            str = "insert into Students values(" + Convert.ToInt64(txt_enroll_no.Text) + "," + Convert.ToInt64(txt_roll_no.Text) + ",'" + txt_name.Text + "','" + Class_drop.SelectedValue + "','" + Course_drop.SelectedValue + "','" + txt_email.Text + "','" + txt_mobile.Text + "','" + dobDate + "')";
            cmd.CommandText = str;

            int i = cmd.ExecuteNonQuery();

            if (i > 0)
            {

                Response.Write("<script>alert('Student Inserted Successfully..');</script>");
            }
            else
            {
                Response.Write("<script>alert('Please Enter Correct Credential');</script>");
            }
          
            cmd.Dispose();
            cn.Close();
            clear();
            show();
            cn.Dispose();
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