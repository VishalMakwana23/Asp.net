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
            SqlCommand cmd = new SqlCommand("Select * from Emp", cn);
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
    protected void btn_delete_Click(object sender, EventArgs e)
    {
        //DataRow dr = dt.Rows.Find();
        //if (dr != null)
        //{
          
        //    dr.Delete();
        //    ad.Update(dt);
        //    Response.Write("<script>alert(' Deleted Successfully!!!')</script>");
        //    show();
           
           

        //}
        //else
        //{
        //    Response.Write("<script>alert('No record Found!!!')</script>");
            
        //}
    }

    protected void Button_delete_Click(object sender, EventArgs e)
    {
        DataRow dr = dt.Rows.Find(Convert.ToInt32(txt_eno.Text));
        if (dr != null)
        {
            
            dr.Delete();
            ad.Update(dt);
            Response.Write("<script>alert('Employee Deleted Successfully!!!')</script>");
            show();
            txt_eno.Text = "";


        }
        else
        {
            Response.Write("<script>alert('Employee not exist!!!')</script>");
            txt_eno.Text = "";
        }
    }
}