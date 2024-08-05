using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_task.Models
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public List<Product> PurchasedProducts { get; set; }

        public Customer(int id, string name, string email, string phone, string city)
        {
            Id = id;
            Name = name;
            Email = email;
            Phone = phone;
            City = city;
            PurchasedProducts = new List<Product>();
        }
        
    }
}
