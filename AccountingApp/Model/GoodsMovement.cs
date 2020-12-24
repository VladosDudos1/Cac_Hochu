using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingApp.Model
{
    public class GoodsMovement
    {
        public int Id { get; set; }
        public string Product { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public decimal Sum { get; set; }
        public DateTime Date { get; set; }

        public GoodsMovement(int id, string product, int amount, decimal price, DateTime date)
        {
            this.Id = id;
            this.Product = product;
            this.Amount = amount;
            this.Price = price;
            this.Sum = price * amount;
            this.Date = date;
        }
    }
}
