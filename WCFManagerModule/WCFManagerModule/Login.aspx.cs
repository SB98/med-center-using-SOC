using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WCFManagerModule
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsignin_Click(object sender, EventArgs e)
        {
            if(txtemail.Text.Equals("Admin@gmail.com")&&txtpass.Text.Equals("Admin"))
            {
                Response.Redirect("~/Manager.aspx");
            }
            else
            {
                ServiceReference1.Service1Client csc = new ServiceReference1.Service1Client();
                ServiceReference1.Resp res = new ServiceReference1.Resp();
                res = csc.CustomerList(txtemail.Text.ToString(),txtpass.Text.ToString());
                
            }
        }
    }
}