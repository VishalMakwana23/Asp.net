using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


public partial class Student : System.Web.UI.Page
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
        txt_roll_no.Text = "";
        txt_name.Text = "";
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
   

    protected void btn_display_Click(object sender, EventArgs e)
    {
        clear();
        show();
    }

    protected void btn_search_Click(object sender, EventArgs e)
    {
        Response.Redirect("findStud.aspx");
    }

    protected void btn_update_Click(object sender, EventArgs e)
    {

        
        Response.Redirect("updateStud.aspx");
    }

    protected void btn_delete_Click(object sender, EventArgs e)
    {
       
        Response.Redirect("deleteStud.aspx");
    }

    protected void btn_display_birth_Click(object sender, EventArgs e)
    {
        Response.Redirect("birthDisplay.aspx");
    }

    protected void btn_insert_Click(object sender, EventArgs e)
    {
        try
        {
            DataRow dr = dt.NewRow();
            dr[0] = Convert.ToInt32(txt_enroll_no.Text);
            dr[1] = Convert.ToInt32(txt_roll_no.Text);
            dr[2] = txt_name.Text;
            dr[3] = DropDownList1.SelectedValue;
            dr[4] = DropDownList2.SelectedValue;
            dr[5] = txt_email.Text;
            dr[6] = txt_mobile.Text;
            dr[7] = txt_dob.Text;
            dt.Rows.Add(dr);
            ad.Update(dt);
            Response.Write("<script>alert('Student Inserted!!!')</script>");
            show();
            clear();
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex + "')</script>");
        }
    }
}