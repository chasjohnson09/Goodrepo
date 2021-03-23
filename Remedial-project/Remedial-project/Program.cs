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
            var widget = new List<Widget>();
            var basicsmall = new Widget()
            {
                Id = 1,
                Description = "Basic Small Widget",
                Unit = "Each",
                Price = 50
            };
            var basicmedium = new Widget()
            {
                Id = 2,
                Description = "Basic Medium Widget",
                Unit = "Each",
                Price = 100
            };
            var basiclarge = new Widget()
            {
                Id = 3,
                Description = "Basic Large Widet",
                Unit = "Each",
                Price = 150
            };
            var advancedsmall = new Widget()
            {
                Id = 4,
                Description = "Advanced Small Widget",
                Unit = "Each",
                Price = 125
            };
            var advancedmedium = new Widget()
            {
                Id = 5,
                Description = "Advanced Medium Widet",
                Unit = "Each",
                Price = 200
            };
            var advancedlarge = new Widget()
            {
                Id = 6,
                Description = "Advanced Large Widet",
                Unit = "Each",
                Price = 275
            };
            var enterprisesmall = new Widget()
            {
                Id = 7,
                Description = "Enterprise Small Widet",
                Unit = "Each",
                Price = 250
            };
            var enterprisemedium = new Widget()
            {
                Id = 8,
                Description = "Enterprise Medium Widet",
                Unit = "Each",
                Price = 400
            };
            var enterpriselarge = new Widget()
            {
                Id = 9,
                Description = "Enterprise Large Widet",
                Unit = "Each",
                Price = 550
            };


        }
    }
}
