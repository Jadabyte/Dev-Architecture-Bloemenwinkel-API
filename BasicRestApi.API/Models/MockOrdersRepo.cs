using System.Collections.Generic;


namespace BasicRestApi.API.Models
{
    public class MockOrdersRepo : IOrdersRepo
    {
        public IEnumerable<Order> GetAppOrders()
        {
            var Orders = new List<Order>
            {
                new Order { id = 0, Store_Id = 2, Store_City = "Antwerpen", Client_Id = 1, Client_Name = "James Dean", Product_Id = 2, Product_Name = "Rose" },
                new Order { id = 1, Store_Id = 1, Store_City = "Mechelen", Client_Id = 4, Client_Name = "Marilyn Monroe", Product_Id = 21, Product_Name = "Dafodil" },
                new Order { id = 2, Store_Id = 3, Store_City = "Gent", Client_Id = 34, Client_Name = "George Washington", Product_Id = 17, Product_Name = "Tulip" }
            };

            return Orders;
        }

        public Order GetOrdersById(int id)
        {
            return new Order { id = 0, Store_Id = 2, Store_City = "Antwerpen", Client_Id = 1, Client_Name = "James Dean", Product_Id = 2, Product_Name = "Rose" };
        }
    }

}