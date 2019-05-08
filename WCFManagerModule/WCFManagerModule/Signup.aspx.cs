using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WCFManagerModule
{
    public partial class Signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsignup_Click(object sender, EventArgs e)
        {
            //object o = new object();
            ServiceReference1.Customer c = new ServiceReference1.Customer();
            ServiceReference1.Service1Client scs = new ServiceReference1.Service1Client();
            
            c.Username = txtusername.Text.ToString();
            c.Password = txtpass.Text.ToString();
            c.ConfirmPassword = txtconfirmpass.Text.ToString();
            c.Email = txtemail.Text.ToString();
            c.Address = txtaddress.Text.ToString();
            c.PhoneNumber = txtphonenumber.Text.ToString();
            scs.PostCustomerList(c);

            Response.Redirect("~/Login.aspx");
        }
    }
}