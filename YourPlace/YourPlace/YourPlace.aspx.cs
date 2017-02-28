using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YourPlace;

namespace YourPlace
{
    public partial class YourPlace1 : System.Web.UI.Page
    {
        public string Employee_category{ get; set; }
        public string Employee_location { get; set; }

     protected void Page_Load(object sender, EventArgs e)
    {
            
    }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Employee_category = TextBox1.Text;
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            Employee_location = TextBox2.Text;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Server.Transfer("SearchPage.aspx");
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-E7DS46C\MSSQLSRAVYA;Initial Catalog=YourPlace;Integrated Security=True"))

            {
                con.Open();
                SqlCommand com = new SqlCommand("Select * from Employer where category = '" + TextBox1.Text +" 'and user_Location = '" + TextBox2.Text + "'", con);

                SqlDataReader reader = com.ExecuteReader();
                GridView1.DataSource = reader;
                GridView1.DataBind();
            }

        }
    }
}