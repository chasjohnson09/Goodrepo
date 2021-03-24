using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remedial_project.models
{
    class Service
    { 
        public string Description { get; set; }
        public string Unit { get; set; }
        public double Price { get; set; }
        public int MyProperty { get; set; }
        virtual public int WidgetId { get; set; }
        public string ServiceYears { get; set; }
    }
}
