using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class deleteEmp : System.Web.UI.Page
{
    EmpManagementClassesDataContext del;
    EmpManagementClassesDataContext disp;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            show();
        }
    }
   
    protected void show()
    {
        disp = new EmpManagementClassesDataContext();
        var show = from Emp in disp.Emps
                   select Emp;
        GridView1.DataSource = show;
        GridView1.DataBind();
    }
    protected void btn_delete_Click(object sender, EventArgs e)
    {
        
    }

    protected void Button_delete_Click(object sender, EventArgs e)
    {
        try
        {
            del = new EmpManagementClassesDataContext();

            Emp demp = del.Emps.Single(em => em.eno == Convert.ToInt16(txt_eno.Text));
            del.Emps.DeleteOnSubmit(demp);
            del.SubmitChanges();
            Response.Write("<script>alert('Employee Deleted')</script>");
            txt_eno.Text = "";
            show();


        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex + "')</script>");
            txt_eno.Text = "";
        }
    }
}