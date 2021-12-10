using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
public partial class birthDisplay : System.Web.UI.Page
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

    protected void btn_display_Click(object sender, EventArgs e)
    {
        try
        {
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Student where YEAR(dob) = "+txt_dob.Text+"", cn);
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
}