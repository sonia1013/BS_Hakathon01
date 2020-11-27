using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ProgressiveTaxRate
{
    class IncomeType
    {
        public decimal income { get; set; }

        public string type { get; set; }

        public double taxrate { get; set; }

        public double GetTax()
        {
            return Convert.ToDouble(income) * taxrate;
        }
    }
}
