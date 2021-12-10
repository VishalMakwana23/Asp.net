using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
public partial class deleteEmp : System.Web.UI.Page
{
    SqlConnection cn;
    SqlCommand cmd;
    string str;
    protected void Page_Load(object sender, EventArgs e)
    {
        cn = new SqlConnection(ConfigurationManager.ConnectionStrings["mycn"].ConnectionString);
        cmd = new SqlCommand();
        show();
    }
   
    protected void show()
    {
        cn.Open();
        SqlCommand cmd = cn.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "SELECT * FROM Emp";
        cmd.ExecuteNonQuery();

        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);

        da.Fill(dt);

        GridView1.DataSource = dt;
        GridView1.DataBind();
        cn.Close();

    }
    protected void btn_delete_Click(object sender, EventArgs e)
    {
        cn.Open();
        cmd.Connection = cn;
        cmd.CommandType = CommandType.Text;

        str = "delete from Emp ";
        cmd.CommandText = str;

        int i = cmd.ExecuteNonQuery();

        if (i > 0)
        {
            Response.Write("<script>alert('Employee deleted Successfully..');</script>");
        }
        else
        {
            Response.Write("<script>alert('Please Enter Correct Credential');</script>");
        }
        cmd.Dispose();
        cn.Close();
       
        show();

        cn.Dispose();
    }

    protected void Button_delete_Click(object sender, EventArgs e)
    {
        cn.Open();
        cmd.Connection = cn;
        cmd.CommandType = CommandType.Text;


        str = "delete from Emp  where eno = " + txt_eno.Text + "";
        cmd.CommandText = str;

        int i = cmd.ExecuteNonQuery();

        if (i > 0)
        {
            Response.Write("<script>alert('Employee deleted Successfully..');</script>");
        }
        else
        {
            Response.Write("<script>alert('Please Enter Correct Credential');</script>");
        }
        cmd.Dispose();
        cn.Close();
        show();
        cn.Dispose();
        txt_eno.Text = "";
    }
}