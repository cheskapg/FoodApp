using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace FoodApp.Model
{
    public class Customer
    {
        public string OrderId { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string Barangay { get; set; }
        public string StreetAddress { get; set; }
        public string ContactNo { get; set; }
        public string PaymentMethod { get; set; }
        public string OrderList { get; set; }


        public static string InsertDeliveryInfo(string Firstname, string Lastname, string Barangay, string StreetAddress, string ContactNo, string PaymentMethod, string OrderList)
        {
            var client = new RestClient("https://nacho.cheez/FoodApp/insert/InsertDeliveryInfo.php");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AlwaysMultipartFormData = true;
            request.AddParameter("FirstName", Firstname);
            request.AddParameter("LastName", Lastname);
            request.AddParameter("Barangay", Barangay);
            request.AddParameter("StreetAddress", StreetAddress);
            request.AddParameter("ContactNo", ContactNo);
            request.AddParameter("PaymentMethod", PaymentMethod);
            request.AddParameter("OrderList", "");
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

        public static string InsertOrderList(string OrderId, string OrderList)
        {
            var client = new RestClient("https://nacho.cheez/FoodApp/insert/InsertOrder.php");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AlwaysMultipartFormData = true;
            request.AddParameter("OrderId", OrderId);
            request.AddParameter("OrderList", OrderList);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }


        public static List<Customer> GetCustomerOrder()
        {
            var client = new RestClient("https://nacho.cheez/FoodApp/insert/GetOrderList.php");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            var customer = JsonConvert.DeserializeObject<List<Customer>>(response.Content);
            return customer;
        }

        public static string EditCustomer (Customer editCustomer)
        {
            var client = new RestClient("https://nacho.cheez/FoodApp/insert/EditOrderInfo.php");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AlwaysMultipartFormData = true;
            request.AddParameter("OrderId", editCustomer.OrderId);
            request.AddParameter("FirstName", editCustomer.Firstname);
            request.AddParameter("LastName", editCustomer.LastName);
            request.AddParameter("Barangay", editCustomer.Barangay);
            request.AddParameter("StreetAddress", editCustomer.StreetAddress);
            request.AddParameter("ContactNo", editCustomer.ContactNo);
            request.AddParameter("PaymentMethod", editCustomer.PaymentMethod);
            request.AddParameter("OrderList", editCustomer.OrderList);
            IRestResponse response = client.Execute(request);
            return (response.Content);
        }

        public static string DeleteOrder(string OrderId)
        {
            var client = new RestClient("https://nacho.cheez/FoodApp/insert/DeleteOrder.php");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AlwaysMultipartFormData = true;
            request.AddParameter("OrderId", OrderId);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }



    }

    public class OrderID
    {
        public string OrderId { get; set; }
        public string Firstname { get; set; }
        public static List<OrderID> GetOrderID()
        {
            var client = new RestClient("https://nacho.cheez/FoodApp/insert/GetOrderID.php");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            var orderid = JsonConvert.DeserializeObject<List<OrderID>>(response.Content);
            return orderid;

        }
    }
    /*    public class PaymentMethod
        {
            public string paymentAcc { get; set; }

            public static List<PaymentMethod> GetPaymentMethod()
            {
                var client = new RestClient("https://nacho.cheez/FoodApp/insert/GetPaymentMethodAcc.php");
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                var PaymentAcc = JsonConvert.DeserializeObject<List<PaymentMethod>>(response.Content);
                return PaymentAcc;
            }
        }*/        
    
}


