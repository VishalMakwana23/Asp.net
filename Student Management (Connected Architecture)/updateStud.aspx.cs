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

   

    protected void btn_search_stud_Click(object sender, EventArgs e)
    {
        cn.Open();
        SqlDataAdapter da = new SqlDataAdapter("select * from Students where enrollno = '" + txt_enroll_no.Text + "'", cn);
        DataTable dt = new DataTable();
        da.Fill(dt);


        foreach (DataRow r in dt.Rows)
        {
            txt_email.Text = r["email"].ToString();
            txt_mobile.Text = r["mobile"].ToString();
            txt_dob.Text = r["dob"].ToString();
        }

        cn.Close();
    }

    protected void btn_update_stud_Click(object sender, EventArgs e)
    {
        cn.Open();
        cmd.Connection = cn;
        cmd.CommandType = CommandType.Text;

        str = "update Students set  email = '" + txt_email.Text + "',mobile = '" + txt_mobile.Text + "',dob = '" + txt_dob.Text + "' where enrollno = "+txt_enroll_no.Text+"";
        cmd.CommandText = str;

        int i = cmd.ExecuteNonQuery();

        if (i > 0)
        {
            Response.Write("<script>alert('Student Update Successfully..');</script>");
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
}