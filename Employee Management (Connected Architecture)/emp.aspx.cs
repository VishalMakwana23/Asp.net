using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class emp : System.Web.UI.Page
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
        txt_emp_no.Text = "";
        txt_name.Text = "";
        txt_dob.Text = "";
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


    protected void btn_search_Click(object sender, EventArgs e)
    {
        Response.Redirect("findEmp.aspx");
    }

    protected void btn_update_Click(object sender, EventArgs e)
    {
        Response.Redirect("updateEmp.aspx");
    }

    protected void btn_delete_Click(object sender, EventArgs e)
    {
        Response.Redirect("deleteEmp.aspx");
    }

    protected void btn_display_Click(object sender, EventArgs e)
    {
        Response.Redirect("displayEmp.aspx");
    }

    protected void btn_insert_course_Click(object sender, EventArgs e)
    {

    }

    protected void btn_insert_Click(object sender, EventArgs e)
    {
        cn.Open();
        cmd.Connection = cn;
        cmd.CommandType = CommandType.Text;

        str = "insert into Emp values(" + Convert.ToInt64(txt_emp_no.Text) + ",'" + txt_name.Text 
            + "','" + txt_dob.Text + "','" + DropDownList_dept.SelectedValue + "','" + DropDownList_desg.SelectedValue + "','" + Convert.ToString(txt_salary.Text) 
            + "','" + cvupload.FileName + "')";
        cmd.CommandText = str;
        int i = cmd.ExecuteNonQuery();
        if (i > 0)
        {
            if (cvupload.PostedFile.ContentType.Contains("pdf"))
            {
                cvupload.SaveAs(Server.MapPath(cvupload.FileName));
                Response.Write("<script>alert('Employee Added Successfully..');</script>");
            }
            else
            {
                Response.Write("<script>alert('Please upload .pdf file');</script>");
            }
            
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