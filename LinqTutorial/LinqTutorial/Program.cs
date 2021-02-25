using System;
using System.Linq;

namespace LinqTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var customers = new Customer[]
            {
               new Customer {Id = 1, Name = "Max"},
               new Customer {Id = 2, Name = "Jimmy Johns"}
            };

            var orders = new Order[]
            {
                new Order {Id = 1, Total = 100m, CustId = 2},
                new Order {Id = 2, Total = 200m, CustId = 1},
                new Order {Id = 3, Total = 300m, CustId = 2}
            };

            var orderlines = new Orderline[]
            {
                new Orderline {Id = 1, OrderId = 1, Product = "Echo", Quantity = 1, Price = 100m},
                new Orderline {Id = 2, OrderId = 2, Product = "Echo", Quantity = 1, Price = 100m},
                new Orderline {Id = 3, OrderId = 2, Product = "Echo dot", Quantity = 2, Price = 50m},
                new Orderline {Id = 4, OrderId = 3, Product = "Echo", Quantity = 2, Price = 100m},
                new Orderline {Id = 5, OrderId = 3, Product = "Echo Show 8", Quantity = 1, Price = 140m},
                new Orderline {Id = 6, OrderId = 3, Product = "FireTv stick", Quantity = 1, Price = 60m}
            };

            var result2 = from o in orders              // joining the order table to the orderline table
                          join ol in orderlines
                          on o.Id equals ol.OrderId
                          orderby o.Total
                          select new
                          {
                              o.Id,
                              o.Total,
                              ol.Product,
                              ol.Price,
                              ol.Quantity,
                              Subtotal = ol.Quantity * ol.Price // setting the alias of the left side of the equals and then give the parameters on the right side 
                          };

            var result = from c in customers            // joining the customer table to the orders table
                         join o in orders
                         on c.Id equals o.CustId
                         join ol in orderlines
                         on o.Id equals ol.OrderId
                         orderby o.Total descending
                         select new
                         {
                             o.Id,
                             c.Name,
                             o.Total,
                             ol.Product,
                             ol.Quantity,
                             ol.Price,
                             LineTotal = ol.Quantity * ol.Price
                         };
            foreach (var col in result)
            {
                Console.WriteLine($"Id = {col.Id} | Name = {col.Name} | Total = {col.Total} | Product = {col.Product} | Price = {col.Price} | Quantity = {col.Quantity}");
            };

            //var result3 = from c in customers            // joining the customer table to the orders table and then also joining the orderline table 
            //             join o in orders
            //             on c.Id equals o.CustId
            //             join ol in orderlines
            //             on o.Id equals ol.OrderId
            //             orderby o.Total descending
            //             group o by o.Id into ord
            //             select new
            //             {
            //                 ord.Key, o.total
            //             };





            var numbers = new int[] {                                       // new int array
                8927, 2150, 2883, 2221, 3643, 4126, 5256, 9275, 7016, 1169,
                2681, 3087, 8256, 8125, 6865, 9366, 9547, 6634, 4739, 7914,
                9636, 8905, 9553, 4122, 8553, 9658, 8406, 8915, 7426, 7525,
                2279, 2724, 7744, 5838, 2630, 1483, 7161, 4514, 9937, 9453,
                3173, 5348, 3380, 4891, 5079, 8044, 5584, 6619, 8953, 4438,
                2543, 3843, 7468, 4139, 1426, 9309, 4631, 7133, 2527, 7507,
                2196, 2993, 3333, 9427, 3895, 3532, 8503, 4874, 2459, 5657,
                3086, 4653, 2396, 7749, 9524, 3291, 1895, 8809, 6948, 7992,
                3187, 4512, 1318, 6572, 9904, 2175, 6726, 9956, 3943, 3190,
                6469, 5237, 7988, 1240, 7585, 1458, 4339, 3120, 2976, 3659
            };

            var numbers2 = new int[] {                                      // new int array
                3374, 6512, 6885, 4146, 4229, 2752, 3990, 6406, 1712, 8844,
                9113, 7676, 5021, 1455, 7621, 4933, 4415, 8245, 4973, 7931,
                9027, 4463, 7382, 2411, 7650, 9282, 1539, 6115, 7877, 5338,
                1442, 6126, 2612, 5965, 7712, 4034,	3496, 7151, 3998, 9566,
                3682, 4607, 6566, 6383, 7370, 9807, 9922, 1355, 7195, 3687
            };



            var hello2 = from nbr in numbers    // number between 1500 and 3000 or 6500 and 8500
                         where (6500 <= nbr && nbr <= 8500) || (1500 <= nbr && nbr <= 3000)
                         orderby nbr
                         select nbr;


            var numbersinboth = from n1 in numbers     // find all of the numbers that are shared between numbers and numbers2
                                join n2 in numbers2
                                on n1 equals n2
                                select n1;
            Console.WriteLine();
            foreach(var n in numbersinboth)
            {
                Console.WriteLine($"the numbers shared are {n}");
            }


            var divideby3 = from nbr in numbers
                            where (nbr % 3 == 0)
                            select nbr;
            var divideby3two = from nbr in numbers2
                               where (nbr % 3 == 0)
                               select nbr;


            var sumhello2 = (from nbr in numbers    // sum of the numbers between 1500 and 3000 or 6500 and 8500
                             where (6500 <= nbr && nbr <= 8500) || (1500 <= nbr && nbr <= 3000)
                             orderby nbr
                             select nbr).Sum(nmb => nmb);   // pay attention to the sum function added to the end of the statement   
                                                            // this is an example of how to use query based and method based together


            var hello2M = numbers.Where(nbr => (nbr >= 1500 && nbr <= 3000 || nbr >= 6500 && nbr <= 8500)).OrderBy(nbr => nbr).ToList();  // method based 


            
            var lessThan5000 = from nbr in numbers  // selecting the numbers collection -- query syntax
                               where nbr < 5000     // if the number is less than 5000
                               orderby nbr          // order the numbers asscending
                               select nbr;


            var lessThan5000M = numbers.Where(nbr => nbr < 5000).OrderBy(nbr => nbr).ToList();      //method based for above 


            var lessThan5000A = numbers.Where(nbr => nbr < 5000).OrderBy(nbr => nbr).ToList();  // method based syntax-- same type of parameters as the one above
                                                                                                // just written differently for query based vs method based

            var query25007500 = from nbr in numbers // query based syntax to find all nmbers that fall between 2500 and 7500
                                where 2500 <= nbr && nbr <= 7500
                                orderby nbr
                                select nbr;



            var method25007500 = numbers.Where(nbr => nbr >= 2500 && nbr <= 7500).OrderByDescending(nbr => nbr).ToList(); //method based for above 


            
            var hello = from nbr in numbers         // query based-- numbers less than 2000 and greater than 8000
                        where nbr < 2000 || nbr > 8000
                        orderby nbr descending
                        select nbr;


            
            var helloM = numbers.Where(nbr => nbr < 2000 || nbr > 8000).OrderBy(nbr => nbr).ToList();   //method based for above
            
        }
    }
}
