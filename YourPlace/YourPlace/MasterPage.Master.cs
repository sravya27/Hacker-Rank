using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YourPlace;

namespace YourPlace
{
    public partial class YourPlace : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HyperLink1.NavigateUrl = "Login.aspx";
            HyperLink2.NavigateUrl = "Employer.aspx";
            HyperLink3.NavigateUrl = "YourPlace.aspx";
        }
    }
}