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
    EmpManagementClassesDataContext ins;
    EmpManagementClassesDataContext disp;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            show();
        }
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

        disp = new EmpManagementClassesDataContext();
        var show = from Emp in disp.Emps
                   select Emp;
        GridView1.DataSource = show;
        GridView1.DataBind();
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
            ins = new EmpManagementClassesDataContext();

            Emp d = new Emp();
            d.eno = Convert.ToInt16(txt_emp_no.Text);
            d.name = txt_name.Text;
            d.dob = txt_dob.Text;
            d.designation = DropDownList1.SelectedValue;
            d.dept = DropDownList2.SelectedValue;
            d.salary = txt_salary.Text;
            d.cv = cvupload.FileName;


            ins.Emps.InsertOnSubmit(d);
            ins.SubmitChanges();

                if (cvupload.PostedFile.ContentType.Contains("pdf"))
                {
                    cvupload.SaveAs(Server.MapPath(cvupload.FileName));
                    Response.Write("<script>alert('Employee Added Successfully..');</script>");
                }
                else
                {
                    Response.Write("<script>alert('Please upload .pdf file and Enter Correct Detail');</script>");
                }

           
            show();
            clear();
           


        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex + "')</script>");
        }

    }
}