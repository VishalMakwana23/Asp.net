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
            SqlDataAdapter da = new SqlDataAdapter("select * from Class", cn);
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
        cn = new SqlConnection(ConfigurationManager.ConnectionStrings["mycn"].ConnectionString);
        cmd = new SqlCommand();
        cn.Open();
        cmd.Connection = cn;
        cmd.CommandType = CommandType.Text;

        str = "insert into Class values(" + txt_class_id.Text + "," + DropDownList1.SelectedValue + ",'" + txt_class_name.Text + "')";
        cmd.CommandText = str;

        int i = cmd.ExecuteNonQuery();

        if (i > 0)
        {

            Response.Write("<script>alert('Class Inserted Successfully..');</script>");
        }
        else
        {
            Response.Write("<script>alert('Please Enter Correct Detail');</script>");
        }
        // rd.Close();
        cmd.Dispose();
        cn.Close();
        show();
        cn.Dispose();
    }

    protected void btn_delete_Click(object sender, EventArgs e)
    {
        cn.Open();
        cmd.Connection = cn;
        cmd.CommandType = CommandType.Text;


        str = "delete from Class where class_id = " + txt_class_id.Text + "";
        cmd.CommandText = str;

        int i = cmd.ExecuteNonQuery();

        if (i > 0)
        {
            Response.Write("<script>alert('Class delete Successfully..');</script>");
            txt_class_id.Text = "";
            txt_class_name.Text = "";
           
        }
        else
        {
            Response.Write("<script>alert('Please Enter Correct Credential');</script>");
        }
        // rd.Close();
        cmd.Dispose();
        cn.Close();
        show();

        cn.Dispose();
    }
}