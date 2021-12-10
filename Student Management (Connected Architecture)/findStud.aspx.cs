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

    protected void show()
    {
        try
        {
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Students ", cn);
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
    protected void clear()
    {
        txt_name.Text = "";
      
       
    }
    protected void btn_insert_course_Click(object sender, EventArgs e)
    {
       

        cn.Open();
        cmd.Connection = cn;
        cmd.CommandType = CommandType.Text;
        str = "select * from Students where name = '"+txt_name.Text+"'";
        cmd.CommandText = str;


        int i = cmd.ExecuteNonQuery();

        if (i > 0)
        {

            Response.Write("<script>alert('Found Duplicate Name Please Provide Course Name..');</script>");
        }
        //else if (i <= 1)
        //{
        //    str = "select * from Students where name = '" + txt_name.Text + "' and course='"+txt_course_name.Text+"'";
        //    cmd.CommandText = str;
        //    DataTable dt = new DataTable();
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    da.Fill(dt);
        //    GridView1.DataSource = dt;
        //    GridView1.DataBind();
        //}
        else
        {
            
            //Response.Write("<script>alert('Please Enter Correct Credential');</script>");
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            cn.Close();
            //clear();
        }



       
    }
}