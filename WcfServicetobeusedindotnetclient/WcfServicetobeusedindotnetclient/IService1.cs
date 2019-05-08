using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServicetobeusedindotnetclient
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        Resp PostProductList(string pid, string pname, string pprice, string cat, string qty);


        [OperationContract]
        Resp PutProduct(string pid, string pname, string pprice, string cat, string qty);


        [OperationContract]
        List<Products> GetProducts();

        [OperationContract]
        Resp DeleteProduct(string id);

        [OperationContract]
        Resp PostCustomerList(Customer p);


        [OperationContract]
        Resp CustomerList(string email, string password);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Products
    {
        [DataMember]
        public int Id;
        [DataMember]
        public string ProductId;
        [DataMember]
        public string ProductName;
        [DataMember]
        public decimal ProductPrice;
        [DataMember]
        public string Category;
        [DataMember]
        public int Quantity;
    }

    [DataContract]
    public class Customer
    {
        [DataMember]
        public string Username;
        [DataMember]
        public string Password;
        [DataMember]
        public string ConfirmPassword;
        [DataMember]
        public string Email;
        [DataMember]
        public string Address;
        [DataMember]
        public string PhoneNumber;

    }
}
