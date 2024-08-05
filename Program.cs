using linq_task.Models;

namespace linq_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>
        {
            new Customer(1, "Tariq Yousef", "tariq.yousef@gmail.com", "123-456-7890", "Nablus")
            {
                PurchasedProducts = new List<Product>
                {
                    new Product(101, "Laptop", "Electronics", 1200, 10),
                    new Product(102, "Smartphone", "Electronics", 800, 15)
                }
            },
            new Customer(2, "Hazem Ali", "hazem.ali@gmail.com", "234-567-8901", "Qalqilia")
            {
                PurchasedProducts = new List<Product>
                {
                    new Product(103, "Tablet", "Electronics", 450, 20),
                    new Product(104, "Headphones", "Accessories", 150, 50)
                }
            },
            new Customer(3, "Ali Ahmad", "ali.ahmad@gmail.com", "345-678-9012", "Hebron")
            {
                PurchasedProducts = new List<Product>
                {
                    new Product(105, "Printer", "Office Equipment", 200, 5),
                    new Product(106, "Router", "Electronics", 100, 30)
                }
            },
            new Customer(4, "Mohammed Salah", "mohammad.salih@gmail.com", "456-789-0123", "Nablus")
            {
                PurchasedProducts = new List<Product>
                {
                    new Product(107, "Monitor", "Electronics", 300, 20),
                    new Product(108, "Keyboard", "Accessories", 70, 80)
                }
            },
            new Customer(5, "Samer Al-Masri", "samer.almasri@gmail.com", "567-890-1234", "Qalqilia")
            {
                PurchasedProducts = new List<Product>
                {
                    new Product(109, "Mouse", "Accessories", 25, 100),
                    new Product(110, "Webcam", "Electronics", 90, 40)
                }
            }
        };

            var customersInNablus = customers.Where(c => c.City == "Nablus");
            Console.WriteLine("Customers In Nablus:");
            foreach (var customer in customersInNablus)
            {
                Console.WriteLine($"{customer.Name} from {customer.City}");
            }
            Console.WriteLine("-----------------------------------");


            var customersName = customers.Select(c => c.Name).ToList();
            Console.WriteLine("Customer Names:");
            foreach (var customer in customersName)
            {
                Console.WriteLine(customer);
            }
            Console.WriteLine("-----------------------------------");


            var customersNameAscending = customers.OrderBy(c => c.Name);
            Console.WriteLine("Customers Ascending by name:");
            foreach (var customer in customersNameAscending)
            {
                Console.WriteLine($"{customer.Name}");
            }
            Console.WriteLine("-----------------------------------");

            
            Console.WriteLine(" first Customers name:");
            var firstCustomer = customers.FirstOrDefault();
            Console.WriteLine(firstCustomer.Name);
            Console.WriteLine("-----------------------------------");


            var customersFirstId = customers.Where(customers=>customers.Id==1).Select(customers=>customers.Name).ToList();
            Console.WriteLine("Customers First Id Print name:");
            foreach (var customer in customersFirstId)
            {
                Console.WriteLine(customer);
            }
            Console.WriteLine("-----------------------------------");


            Console.WriteLine("Calculate the total sum of the prices :");
            decimal totalSum = customers.SelectMany(c => c.PurchasedProducts).Sum(p => p.Price);
            Console.WriteLine($"The total sum of the prices : ${totalSum}");
            Console.WriteLine("-----------------------------------");


            Console.WriteLine("customer In Qalqilia:");
            var customerInQalqilia = customers.Any(c => c.City == "Qalqilia");
            Console.WriteLine(customerInQalqilia);
            Console.WriteLine("-----------------------------------");


            var groupedByCity = customers.GroupBy(c => c.City);
            foreach (var cityGroup in groupedByCity)
            {
                Console.WriteLine($"City:{cityGroup.Key}");
                foreach (var customer in cityGroup)
                {
                    Console.WriteLine($"{customer.Name}");
                }
            }
            Console.WriteLine("-----------------------------------");


            var firstThreeCustomers = customers.Take(3);
            Console.WriteLine("First three customers:");
            foreach (var customer in firstThreeCustomers)
            {
                Console.WriteLine($"Name: {customer.Name}, Email: {customer.Email}, City: {customer.City}");
            }
            Console.WriteLine("-----------------------------------");


        }
    }
}
