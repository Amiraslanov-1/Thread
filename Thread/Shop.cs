using System;
using System.Collections.Generic;
using System.Text;

namespace Thread
{
     class Shop
    {
        private List<Order> _orders;
        public Shop()
        {
            _orders = new List<Order>();

        }

        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }
        public double GetOrdersAvg()
        {
            double sum =0;
            foreach (var item in _orders)
            {
                sum += item.TotalAmount;
            }
                sum /= _orders.Count;

            return sum;
        }
        public double GetOrdersAvg(DateTime date)
        { 
            double sum = 0;
            var result = _orders.FindAll(order => order.CreatedAt > date);
            foreach (var item in result)
            {
                sum += item.TotalAmount;
            }
            sum /= result.Count;
            return sum;
        }
        public void RemoveOrderByNo(int? orderNo)
        {
            if (orderNo == null)
            {
                throw new ArgumentNullException("Argument is Null!");
            }
            var result = _orders.Find(order => order.No == orderNo);
            if (result == null)
            {
                throw new ArgumentNullException("Result is Null!");
            }
            _orders.Remove(result);
        }
        public List<Order> FilterOrderByPrice(double min, double max)
        {
            return _orders.FindAll(order => order.TotalAmount >= min && order.TotalAmount <= max);
        }
    }
}
