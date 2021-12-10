using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
public partial class department : System.Web.UI.Page
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
    protected void clear()
    {
        txt_dept_id.Text = "";
        txt_dept_name.Text = "";
    }
    protected void show()
    {
        cn.Open();
        SqlCommand cmd = cn.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "SELECT * FROM Department";
        cmd.ExecuteNonQuery();

        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);

        da.Fill(dt);

        GridView1.DataSource = dt;
        GridView1.DataBind();
        cn.Close();

    }
    protected void btn_insert_dept_Click(object sender, EventArgs e)
    {
        cn.Open();
        cmd.Connection = cn;
        cmd.CommandType = CommandType.Text;

        str = "insert into Department values(" + Convert.ToInt64(txt_dept_id.Text) + ",'" + txt_dept_name.Text + "')";
        cmd.CommandText = str;
        int i = cmd.ExecuteNonQuery();
        if (i > 0)
        {

            Response.Write("<script>alert('Department Inserted Successfully..');</script>");
        }
        else
        {
            Response.Write("<script>alert('Please Enter Correct Detail');</script>");
        }

        cmd.Dispose();
        cn.Close();
        show();
        clear();
        cn.Dispose();
    }
}