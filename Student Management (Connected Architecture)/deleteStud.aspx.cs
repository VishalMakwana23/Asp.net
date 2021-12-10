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
        txt_roll_no.Text = "";
       
      
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

    protected void btn_delete_stud_Click(object sender, EventArgs e)
    {
        cn.Open();
        cmd.Connection = cn;
        cmd.CommandType = CommandType.Text;

        
        str = "delete from Students  where rollno = " + txt_roll_no.Text + " AND course = '"+Course_drop.SelectedValue +"'";
        cmd.CommandText = str;

        int i = cmd.ExecuteNonQuery();

        if (i > 0)
        {
            Response.Write("<script>alert('Student delete Successfully..');</script>");
        }
        else
        {
            Response.Write("<script>alert('Please Enter Correct Credential');</script>");
        }
        // rd.Close();
        cmd.Dispose();
        cn.Close();
        clear();
        show();

        cn.Dispose();
    }
}