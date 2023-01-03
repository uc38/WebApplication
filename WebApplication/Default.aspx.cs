using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WebApplication
{
    public partial class Default : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["companyConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into tblEmployee values('" + TextBox1.Text + "', '" + TextBox2.Text + "', '" + TextBox3.Text + "', '" + TextBox4.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Data has been inserted";
            GridView1.DataBind();

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from tblEmployee where empName = '" + TextBox1.Text + "' and empSurname = '"+TextBox2.Text+"'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Data has been Deleted";
            GridView1.DataBind();
        }
    }
}