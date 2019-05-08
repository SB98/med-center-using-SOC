using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WcfServicetobeusedindotnetclient
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
       // List<int> session = new List<int>();
        public Resp PostCustomerList(Customer p)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CustomerDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            string query = "insert into Customer values (@uname,@pass,@cpass,@email,@address,@pnumber)";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@uname", p.Username);
            cmd.Parameters.AddWithValue("@pass", p.Password);
            cmd.Parameters.AddWithValue("@cpass", p.ConfirmPassword);
            cmd.Parameters.AddWithValue("@email", p.Email);
            cmd.Parameters.AddWithValue("@address", p.Address);
            cmd.Parameters.AddWithValue("@pnumber", p.PhoneNumber);

            con.Open();
            int tmp = cmd.ExecuteNonQuery();
            Resp res = new Resp();
            if (tmp > 0)
            {
                res.ok = 1;
            }
            else
            {
                res.ok = 0;
            }
            con.Close();
            return res;
        }

        //[HttpGet]
        public Resp CustomerList(string email, string password)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CustomerDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            string query = "select * from Customer where Email=@email and Password=@pass";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@pass", password);

            con.Open();
            Resp res = new Resp();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                res.ok = 1;
                //session.Add(rd[""]);
            }
            else
                res.ok = 0;
            con.Close();
            //Resp res = new Resp();
            //res.ok = 1;
            return res;
        }


        public Resp DeleteProduct(string id)
        {
            Resp res = new Resp();
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CustomerDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            string query = "delete from Products where ProductId=@id";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();

            cmd.Parameters.AddWithValue("@id", id);

            int tmp = cmd.ExecuteNonQuery();
            //tmp = id;

            if (tmp > 0)
            {
                res.ok = 1;
            }
            else
            {
                res.ok = 0;
            }
            con.Close();
            return res;
        }

        public List<Products> GetProducts()
        {
            List<Products> prod = new List<Products>();
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CustomerDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            string query = "select * from Products";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                Products p = new Products();
                p.ProductId = rd.GetValue(1).ToString();
                p.ProductName = rd.GetValue(2).ToString();
                p.ProductPrice = Convert.ToDecimal(rd.GetValue(3).ToString());
                p.Category = rd.GetValue(4).ToString();
                p.Quantity = Convert.ToInt32(rd.GetValue(5).ToString());

                prod.Add(p);
            }
            con.Close();

            return prod;
        }

        public Resp PostProductList(string pid, string pname, string pprice, string cat, string qty)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CustomerDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            string query = "insert into Products values(@pid,@pname,@pprice,@cat,@qty)";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@pid", pid);
            cmd.Parameters.AddWithValue("@pname", pname);
            cmd.Parameters.AddWithValue("@pprice", pprice);
            cmd.Parameters.AddWithValue("@cat", cat);
            cmd.Parameters.AddWithValue("@qty", qty);


            con.Open();
            int tmp = cmd.ExecuteNonQuery();
            Resp res = new Resp();
            if (tmp > 0)
            {
                res.ok = 1;
            }
            else
            {
                res.ok = 0;
            }
            con.Close();
            return res;
        }


        //Check this method once..
        public Resp PutProduct(string pid, string pname, string pprice, string cat, string qty)
        {
            Resp res = new Resp();
            //if (id!=p.Id)
            //{
            //    res.ok = 0;
            //    return res;   
            //}


            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CustomerDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            string query = "update Products set ProductId=@pid,ProductName=@pname,ProductPrice=@pp,Category=@cat,Quantity=@qty where ProductId = @ii";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ii", pid);
            cmd.Parameters.AddWithValue("@pid", pid);
            cmd.Parameters.AddWithValue("@pname", pname);
            cmd.Parameters.AddWithValue("@pp", pprice);
            cmd.Parameters.AddWithValue("@cat", cat);
            cmd.Parameters.AddWithValue("@qty", qty);



            con.Open();
            cmd.ExecuteNonQuery();

            con.Close();
            return res;
        }
    }
}
