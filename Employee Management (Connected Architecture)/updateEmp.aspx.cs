using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
public partial class updateEmp : System.Web.UI.Page
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
        txt_emp_id.Text = "";
        txt_salary.Text = "";
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
    protected void btn_insert_dept_Click(object sender, EventArgs e)
    {
        cn.Open();
        cmd.Connection = cn;
        cmd.CommandType = CommandType.Text;

       
        str = "update Emp set  designation = '" + DropDownList1.SelectedValue + "',dept = '" + DropDownList2.SelectedValue + "',salary = '" + txt_salary.Text + "' where eno = " + txt_emp_id.Text + "";
        cmd.CommandText = str;

        int i = cmd.ExecuteNonQuery();

        if (i > 0)
        {
            Response.Write("<script>alert('Employee Update Successfully..');</script>");
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

    protected void btn_search_Click(object sender, EventArgs e)
    {
        cn.Open();
        SqlCommand cmd = cn.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "SELECT * FROM Emp WHERE eno = "+txt_emp_id.Text+"";
        cmd.ExecuteNonQuery();

        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);

        da.Fill(dt);
        foreach (DataRow r in dt.Rows)
        {
            //DropDownList1.SelectedValue = r["designation"].ToString();
            //DropDownList2.SelectedValue = r["dept"].ToString();
            txt_salary.Text = r["salary"].ToString();
        }

        cn.Close();
    }

    protected void txt_department_TextChanged(object sender, EventArgs e)
    {

    }
}