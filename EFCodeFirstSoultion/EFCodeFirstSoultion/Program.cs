using EFCodeFirstSoultion.Models;
using System;
using System.Threading.Tasks;

namespace EFCodeFirstSoultion
{
    class Program
    {
        static async Task Main(string[] args)
        {

            //var custctr = new CustomerController();
            //var cChas = new Customer
            //{
            //    Id = 0,
            //    Code = "Chasj09",
            //    Name = "Chas Johnson",
            //    IsNational = false,
            //    Sales = 123.98m
            //};

            //var cKayla = new Customer
            //{
            //    Id = 0,
            //    Code = "Kayla12",
            //    Name = "Kayla Bialaszewski",
            //    IsNational = false,
            //    Sales = 467.98m
            //};
            ////var cChasNew = await custctr.Create(cChas);
            ////var cKaylaNew = await custctr.Create(cKayla);
            //var customers = await custctr.GetAll();
            //foreach(var c in customers)
            //{
            //    Console.WriteLine($"The ID = {c.Id} | Code = {c.Code} | Name = {c.Name} | Is national = {c.IsNational} Sales = {c.Sales} | Date Created = {c.DateCreated}");
            //}
            //Console.WriteLine($" ");

            //var cust = await custctr.GetbyPK(4);
            //cust.Name = "Poops";
            //await custctr.Change(cust);

            //foreach (var c in customers)
            //{
            //    Console.WriteLine($"The ID = {c.Id} | Code = {c.Code} | Name = {c.Name} | Is national = {c.IsNational} Sales = {c.Sales} | Date Created = {c.DateCreated}");
            //}
            //Console.WriteLine($" ");


            //var custremoved = await custctr.Remove(4);

            //foreach (var c in customers)
            //{
            //    Console.WriteLine($"The ID = {c.Id} | Code = {c.Code} | Name = {c.Name} | Is national = {c.IsNational} Sales = {c.Sales} | Date Created = {c.DateCreated}");
            //}
            //Console.WriteLine($" ");



            //------------------------------------------------------------------------------------------------------------------------


            //var ordctr = new OrderController();
            //var order1 = new Order
            //{
            //    Id = 0,
            //    Description = "This is my first order!!!!",
            //    OrderStatus = "NEW",
            //    OrderTotal = 123.45m,
            //    CustomerId = 1
            //};

            //var order2 = new Order
            //{
            //    Id = 0,
            //    Description = "SECOND ORDER!!!",
            //    OrderStatus = "NEW",
            //    OrderTotal = 657.45m,
            //    CustomerId = 1
            //};
            //var neworder1 = await ordctr.Create(order1);
            //var neworder2 = await ordctr.Create(order2);
            //var orders = await ordctr.GetAll();
            //foreach (var o in orders)
            //{
            //    Console.WriteLine($"The ID = {o.Id} | Description = {o.Description} | Order status = {o.OrderStatus} | Order Total = {o.OrderTotal} | Customer ID = {o.CustomerId}");
            //}
            //Console.WriteLine($" ");

            //var ord = await ordctr.GetbyPK(2);
            //ord.Description = "Changed the Description!!!!!!!";
            //await ordctr.Change(ord);

            //foreach (var o in orders)
            //{
            //    Console.WriteLine($"The ID = {o.Id} | Description = {o.Description} | Order status = {o.OrderStatus} | Order Total = {o.OrderTotal} | Customer ID = {o.CustomerId}");
            //}
            //Console.WriteLine($" ");


            //var ordremoved = await ordctr.Remove(2);

            //foreach (var o in orders)
            //{
            //    Console.WriteLine($"The ID = {o.Id} | Description = {o.Description} | Order status = {o.OrderStatus} | Order Total = {o.OrderTotal} | Customer ID = {o.CustomerId}");
            //}
            //Console.WriteLine($" ");


//-------------------------------------------------------------------------------------------------------------------------------


            var itmctr = new ItemController();
            var item1 = new Item
            {
                Id = 0,
                Name = "Iphone 12 pro",
                Price = 1249.99m
            };

            var item2 = new Item
            {
                Id = 0,
                Name = "Macbook Pro",
                Price = 2499.99m
    };
            var newitem1 = await itmctr.Create(item1);
            var newitem2 = await itmctr.Create(item2);
            var items = await itmctr.GetAll();
            foreach (var i in items)
            {
                Console.WriteLine($"Id= {i.Id} | Name = {i.Name} | Price =${i.Price}");
            }
            Console.WriteLine($" ");

            var itm = await itmctr.GetbyPK(2);
            itm.Price = 3000.00m;
            await itmctr.Change(itm);

            foreach (var i in items)
            {
                Console.WriteLine($"Id= {i.Id} | Name = {i.Name} | Price =${i.Price}");
            }
            Console.WriteLine($" ");

            var ordremoved = await itmctr.Remove(2);

            foreach (var i in items)
            {
                Console.WriteLine($"Id= {i.Id} | Name = {i.Name} | Price =${i.Price}");
            }
            Console.WriteLine($" ");
        }
    }
}
