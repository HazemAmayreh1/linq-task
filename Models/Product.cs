using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_task.Models
{
    internal class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public Product(int id, string productName, string category, decimal price, int stock)
        {
            Id = id;
            ProductName = productName;
            Category = category;
            Price = price;
            Stock = stock;
        }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {ProductName}, Category: {Category}, Price: {Price}, Stock: {Stock}";
        }
    }
}
