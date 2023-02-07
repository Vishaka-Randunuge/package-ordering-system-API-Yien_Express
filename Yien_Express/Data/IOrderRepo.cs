using Yien_Express.Model;

namespace Yien_Express.Data
{
    public interface IOrderRepo
    {
        void CreateOrder(Order order);
        void Delete(Order order);
        bool Update(Order order);

        Order GetOrder(int id);
        IEnumerable<Order> GetOrders();

        bool Save();
    }
}
