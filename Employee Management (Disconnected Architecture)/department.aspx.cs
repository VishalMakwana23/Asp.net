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
        txt_dept_id.Text = "";
        txt_dept_name.Text = "";
    }
    protected void show()
    {
        try
        {
            SqlCommand cmd = new SqlCommand("Select * from Department", cn);
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
    protected void btn_insert_dept_Click(object sender, EventArgs e)
    {
        try
        {
            DataRow dr = dt.NewRow();
            dr[0] = Convert.ToInt32(txt_dept_id.Text);
            dr[1] = txt_dept_name.Text;
            

            dt.Rows.Add(dr);
            ad.Update(dt);
            Response.Write("<script>alert('Department Inserted!!!')</script>");
            show();
            clear();
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex + "')</script>");
        }
    }
}