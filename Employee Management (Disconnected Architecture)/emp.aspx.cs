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
        txt_emp_no.Text = "";
        txt_name.Text = "";
        txt_dob.Text = "";
        txt_salary.Text = "";
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

  

    protected void btn_insert_Click(object sender, EventArgs e)
    {
         try
        {
            DataRow dr = dt.NewRow();
            dr[0] = Convert.ToInt32(txt_emp_no.Text);
            dr[1] = txt_name.Text;
            dr[2] = txt_dob.Text;
            dr[3] = DropDownList_desg.Text;
            dr[4] = DropDownList_dept.Text;
            dr[5] = txt_salary.Text;
            dr[6] = cvupload.FileName;

            if (cvupload.PostedFile.ContentType.Contains("pdf"))
            {
                dt.Rows.Add(dr);
                ad.Update(dt);
                cvupload.SaveAs(Server.MapPath(cvupload.FileName));
                Response.Write("<script>alert('Employee Added Successfully..');</script>");
                show();
                clear();
            }
            else
            {
                Response.Write("<script>alert('Please upload .pdf file');</script>");
            }
           
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex + "')</script>");
        }
  
    }
}