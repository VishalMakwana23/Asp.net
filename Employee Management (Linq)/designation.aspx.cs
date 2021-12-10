using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class designation : System.Web.UI.Page
{
    EmpManagementClassesDataContext ins;
    EmpManagementClassesDataContext disp;
    EmpManagementClassesDataContext del;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            show();
        }
    }
    protected void clear()
    {
        txt_desg_id.Text = "";
        txt_desg_name.Text = "";
    }
    protected void show()
    {
        disp = new EmpManagementClassesDataContext();
        var show = from Designation in disp.Designations
                   select Designation;
        GridView1.DataSource = show;
        GridView1.DataBind();

    }
    protected void btn_insert_designation_Click(object sender, EventArgs e)
    {
        try
        {
            ins = new EmpManagementClassesDataContext();

            Designation d = new Designation();
            d.desg_id = Convert.ToInt16(txt_desg_id.Text);
            d.desg_name = txt_desg_name.Text;

            ins.Designations.InsertOnSubmit(d);
            ins.SubmitChanges();


            Response.Write("<script>alert('Designation Added Successfully')</script>");
            show();
            clear();


        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex + "')</script>");
        }
    }

    protected void btn_delete_Click(object sender, EventArgs e)
    {
        try
        {
            del = new EmpManagementClassesDataContext();
            Designation dld = del.Designations.Single(d => d.desg_id == Convert.ToInt32(txt_desg_id.Text));
            del.Designations.DeleteOnSubmit(dld);
            del.SubmitChanges();
            Response.Write("<script>alert('Designation Deleted')</script>");
            show();

            txt_desg_id.Text = "";
            txt_desg_name.Text = "";
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex + "')</script>");
        }
    }
}