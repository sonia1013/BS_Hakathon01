using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ProgressiveTaxRate
{
    class Program
    {
        List<IncomeType> GetIncomeTypes()
        {
            return new List<IncomeType>
            {
                new IncomeType(){type="1",taxrate=0.05},
                new IncomeType(){type="2",taxrate=0.12},
                new IncomeType(){type="3",taxrate=0.20},
                new IncomeType(){type="4",taxrate=0.30},
                new IncomeType(){type="5",taxrate=0.40},
                new IncomeType(){type="6",taxrate=0.50}
            }; 
        }
        //private void GetTaxType(int money)
        //{
        //    List<IncomeType> incomeTypes = GetIncomeTypes();
        //    //IEnumerable<IncomeType> taxtype =
        //}

        List<long> AmountRange = new List<long> { 540000, 1210000, 2420000, 4530000, 10310000 };

        private void CalculateTax(long NetIncome, IEnumerable<IncomeType> types, decimal Expected)
        {
            //for (int i=0;i<AmountRange.Count;i+)
            //{
            //    NetIncome > AmountRange[]
            //}
        }

        static void Main(string[] args)
        {
            

        }
    }
}
