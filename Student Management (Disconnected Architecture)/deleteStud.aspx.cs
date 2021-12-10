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
        txt_roll_no.Text = "";
      
      
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

    protected void btn_delete_stud_Click(object sender, EventArgs e)
    {
        DataRow dr = dt.Rows.Find(Convert.ToInt32(txt_roll_no.Text)) ;
        if (dr != null)
        {
            ////DataRow dl = dt.Rows.Find(txt_course.Text.ToString());
            ////    if (dl != null)
            ////{
                dr.Delete();
                ad.Update(dt);
                Response.Write("<script>alert('Student Deleted Successfully!!!')</script>");
                show();
                clear();
            //}
            //else
            //{
            //    Response.Write("<script>alert('Please enter course name')</script>");
            //}
            

        }
        else
        {
            Response.Write("<script>alert('Student not exist!!!')</script>");
            clear();
        }
    }
}