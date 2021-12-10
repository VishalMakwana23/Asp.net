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
        txt_emp_id.Text = "";
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
    protected void btn_insert_dept_Click(object sender, EventArgs e)
    {

        DataRow dr = dt.Rows.Find(txt_emp_id.Text);
        dr[3] = DropDownList1.SelectedValue;
        dr[4] = DropDownList2.SelectedValue;
        dr[5] = txt_salary.Text;
        ad.Update(dt);
        Response.Write("<script>alert('Employee Update Successfully..');</script>");
        clear();
        show();

        
    }

    protected void btn_search_Click(object sender, EventArgs e)
    {
        DataRow dr = dt.Rows.Find(txt_emp_id.Text);
        if (dr != null)
        {
           // DropDownList1.Text = dr[3].ToString();
            //DropDownList2.Text = dr[4].ToString();
            txt_salary.Text = dr[5].ToString();
        }
        else
        {
            Response.Write("Data not found!!");
        }
    }

    protected void txt_department_TextChanged(object sender, EventArgs e)
    {

    }
}