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
    SqlDataAdapter ad;
    DataSet ds;
    DataTable dt;
    protected void Page_Load(object sender, EventArgs e)
    {
        cn = new SqlConnection(ConfigurationManager.ConnectionStrings["mycn"].ConnectionString);
       
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
            SqlCommand cmd = new SqlCommand("Select * from Student", cn);
            ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds);
            dt = ds.Tables[0];
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
            SqlCommandBuilder cmdb = new SqlCommandBuilder(ad);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex + "')</script>");
        }
    }

   

    protected void btn_search_stud_Click(object sender, EventArgs e)
    {
        DataRow dr = dt.Rows.Find(txt_enroll_no.Text);
        if (dr != null)
        {
            txt_email.Text = dr[5].ToString();
            txt_mobile.Text = dr[6].ToString();
            txt_dob.Text = dr[7].ToString();
        }
        else
        {
            Response.Write("<script>alert(' No record found')</script>");
        }
    }

    protected void btn_update_stud_Click(object sender, EventArgs e)
    {
        DataRow dr = dt.Rows.Find(txt_enroll_no.Text);
        dr[5] = txt_email.Text;
        dr[6] = txt_mobile.Text;
        dr[7] = txt_dob.Text;
        ad.Update(dt);
        Response.Write("<script>alert('Updated Successfully')</script>");
        clear();
        show();
    }
}