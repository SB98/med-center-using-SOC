using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WCFManagerModule
{
    public partial class Manager : System.Web.UI.Page
    {
        string connectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CustomerDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                populategridview();
            }
        }

        void populategridview()
        {
            DataTable dttbl = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select ProductId,ProductName,ProductPrice,Category,Quantity from Products",con);
                da.Fill(dttbl);
                                
            }
            if (dttbl.Rows.Count > 0)
            {
                GridView1.DataSource = dttbl;
                GridView1.DataBind();
            }
            else
            {
                dttbl.Rows.Add(dttbl.NewRow());
                GridView1.DataSource = dttbl;
                GridView1.DataBind();

                GridView1.Rows[0].Cells.Clear();
                GridView1.Rows[0].Cells.Add(new TableCell());
                GridView1.Rows[0].Cells[0].ColumnSpan = dttbl.Columns.Count;

                GridView1.Rows[0].Cells[0].Text = "No Data Found...";

                GridView1.Rows[0].Cells[0].HorizontalAlign = HorizontalAlign.Center;

            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string prodid = (GridView1.FooterRow.FindControl("txtprodidFooter") as TextBox).Text.Trim();
            string prodname = (GridView1.FooterRow.FindControl("txtprodnameFooter") as TextBox).Text.Trim();
            string prodprice = (GridView1.FooterRow.FindControl("txtprodpriceFooter") as TextBox).Text.Trim();
            string category = (GridView1.FooterRow.FindControl("txtCategoryFooter") as TextBox).Text.Trim();
            string quantity = (GridView1.FooterRow.FindControl("txtquantityFooter") as TextBox).Text.Trim();

            try
            {
                if (e.CommandName.Equals("Addnew"))
                {
                    ServiceReference1.Service1Client psc = new ServiceReference1.Service1Client();
                    psc.PostProductList(prodid, prodname, prodprice, category, quantity);
                    populategridview();
                    lblSuccessMessage.Text = "New Product Added";
                    lblErrorMessage.Text = "";
                }
            }
            catch (Exception ex)
            {
                lblSuccessMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //Used to make the row in the edit mode.
            GridView1.EditIndex = e.NewEditIndex;
            populategridview();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            populategridview();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string prodid = (GridView1.Rows[e.RowIndex].FindControl("txtprodid") as TextBox).Text.Trim();
            string prodname = (GridView1.Rows[e.RowIndex].FindControl("txtprodname") as TextBox).Text.Trim();
            string prodprice = (GridView1.Rows[e.RowIndex].FindControl("txtprodprice") as TextBox).Text.Trim();
            string category = (GridView1.Rows[e.RowIndex].FindControl("txtCategory") as TextBox).Text.Trim();
            string quantity = (GridView1.Rows[e.RowIndex].FindControl("txtquantity") as TextBox).Text.Trim();

            try
            {
                    ServiceReference1.Service1Client psc = new ServiceReference1.Service1Client();
                    psc.PutProduct(prodid, prodname, prodprice, category, quantity);
                    GridView1.EditIndex = -1;
                    populategridview();
                    lblSuccessMessage.Text = "Product Updated Successfully...";
                    lblErrorMessage.Text = "";
            }
            catch (Exception ex)
            {
                lblSuccessMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string prodid = GridView1.DataKeys[e.RowIndex].Value.ToString();
            try
            {
                ServiceReference1.Service1Client psc = new ServiceReference1.Service1Client();
                psc.DeleteProduct(prodid);
                GridView1.EditIndex = -1;
                populategridview();
                lblSuccessMessage.Text = "Product Deleted Successfully...";
                lblErrorMessage.Text = "";
            }
            catch (Exception ex)
            {
                lblSuccessMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }
        }
    }
}