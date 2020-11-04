using System.Collections.Generic;

namespace BasicRestApi.API.Models
{
    public interface IOrdersRepo
    {
        IEnumerable<Order> GetAppOrders();
        Order GetOrderById(int id);
    }
}