using System;
using System.Collections.Generic;
using System.Text;

namespace Thread
{
     class Order
    {
        //Müəllim bu şərtdə verilməmişdi sadəcə "_no" artmasi hemiwe yaziriq ona gore
        static int _no;
        public  int No { get; }
        public Order(int productCount,double totalAmount)
        {

            _no++;
            No = _no;
            TotalAmount = totalAmount;
            ProductCount = productCount;
        }
        public int ProductCount { get; set; }
        public double TotalAmount { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
