using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YourPlace
{
    public partial class Employer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-E7DS46C\MSSQLSRAVYA;Initial Catalog=YourPlace;Integrated Security=True"))

            {
                con.Open();
                SqlCommand com = new SqlCommand("insert into Employer(company,category,user_Location,job_title,job_description) values('" + TextBox1.Text + "', '" + TextBox4.Text + "', '" + TextBox5.Text + "', '" + TextBox2.Text + "', '" + TextBox3.Text + "')", con);

                SqlDataReader reader = com.ExecuteReader();
               
            }
            Response.Write("Job Uploaded");
        }
    }
}