using System.Collections.Generic;

namespace WebAPI.Interfaces
{
    public interface IOrderEntries
    {
        public IEnumerable<IOrder> GetOrders();
        public IOrder GetOrdersById(int id);
        public void AddOrder(IOrder order);
        public void EditOrder(IOrder order);
        public void RemoveOrder(int id);
    }
}
