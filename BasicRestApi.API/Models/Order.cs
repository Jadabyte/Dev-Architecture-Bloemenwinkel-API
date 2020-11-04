using System.Collections.Generic;

namespace BasicRestApi.API.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int Store_Id { get; set; }
        public string Store_City { get; set; }
        public int Client_Id { get; set; }
        public string Client_Name { get; set; }
        public int Product_Id { get; set; }
        public string Product_Name { get; set; }
        // public List<Product> Products { get; set; }
    }

    /*
    public class Product
    {
        public int Product_Id { get; set; }
        public string Product_Name { get; set; }
        public string Product_Category { get; set; }
        public decimal Product_Price { get; set; }
    }
    */
}