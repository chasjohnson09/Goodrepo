using Remedial_project.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remedial_project
{
    class Program
    {
        static void Main(string[] args)
        {
            var smallbasic = new Widget
            {
                Id = 1,
                Description = "Small basic",
                Unit = "Each",
                Price = 50
            };
            var mediumbasic = new Widget
            {
                Id = 2,
                Description = "Medium basic",
                Unit = "Each",
                Price = 100
            };
            var largebasic = new Widget
            {
                Id = 3,
                Description = "Large basic",
                Unit = "Each",
                Price = 150
            };
            var smalladvanced = new Widget
            {
                Id = 4,
                Description = "Small Advanced",
                Unit = "Each",
                Price = 125
            };
            var mediumadvanced = new Widget
            {
                Id = 5,
                Description = "Medium Advanced",
                Unit = "Each",
                Price = 200
            };
            var largeadvanced = new Widget
            {
                Id = 6,
                Description = "Large Advanced",
                Unit = "Each",
                Price = 275
            };
            var smallenterprise = new Widget
            {
                Id = 7,
                Description = "Small Enterprise",
                Unit = "Each",
                Price = 250
            };
            var mediumenterprise = new Widget
            {
                Id = 8,
                Description = "Medium Enterprise",
                Unit = "Each",
                Price = 400
            };
            var largeenterprise = new Widget
            {
                Id = 9,
                Description = "Large Enterprise",
                Unit = "Each",
                Price = 550
            };

            

            var companyA = new List<Widget>();
            companyA.Add(largeenterprise);
            companyA.AddRange(Enumerable.Repeat(smalladvanced, 3));
            companyA.AddRange(Enumerable.Repeat(mediumbasic, 7));

            var companyB = new List<Widget>();
            companyB.AddRange(Enumerable.Repeat(mediumenterprise, 4));
            companyB.AddRange(Enumerable.Repeat(largeadvanced, 5));
            companyB.AddRange(Enumerable.Repeat(smallbasic, 2));

            var companyC = new List<Widget>();
            companyC.AddRange(Enumerable.Repeat(smallenterprise, 7));
            companyC.AddRange(Enumerable.Repeat(mediumadvanced, 3));
            companyC.AddRange(Enumerable.Repeat(largebasic, 10));



            var Atotal = 0.0;
            var Asubtotal = 0.0;
            foreach(var i in companyA)
            {
                Asubtotal += i.Price;
                var serviceA = new Service
                {
                    WidgetId = i.Id,
                    Price = i.Price * 0.25,
                    ServiceYears = 3
                };
                Atotal += serviceA.Price * serviceA.ServiceYears;
            }
            Atotal += Asubtotal;

            var Btotal = 0.0;
            var Bsubtotal = 0.0;
            foreach (var i in companyB)
            {
                Bsubtotal += i.Price;
                var serviceB = new Service
                {
                    WidgetId = i.Id,
                    Price = i.Price * 0.25,
                    ServiceYears = 4
                };
                Btotal += serviceB.Price * serviceB.ServiceYears;
            }
            Btotal += Bsubtotal;

            var Ctotal = 0.0;
            var Csubtotal = 0.0;
            foreach (var i in companyC)
            {
                Csubtotal += i.Price;
                var serviceC = new Service
                {
                    WidgetId = i.Id,
                    Price = i.Price * 0.25,
                    ServiceYears = 5
                };
                Ctotal += serviceC.Price * serviceC.ServiceYears;
            }
            Ctotal += Csubtotal;

            Console.WriteLine($"Subtotal for Company A = {Asubtotal}");
            Console.WriteLine($"Total for company A = {Atotal}");
            Console.WriteLine($"Subtotal for Company B = {Bsubtotal}");
            Console.WriteLine($"Total for company B = {Btotal}");
            Console.WriteLine($"Subtotal for Company C = {Csubtotal}");
            Console.WriteLine($"Total for Company C = {Ctotal}");

            Console.ReadLine();
        }
    }
}
