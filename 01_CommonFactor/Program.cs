using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CommonFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("請輸入一個大於90的整數:");
            int max = int.Parse(Console.ReadLine());
            List<string> NumToMax = new List<string>(max);


            for (int i = 1; i <= max; i++)
            {
                NumToMax.Add(i.ToString());
                if (i % 15 == 0)
                {
                    NumToMax[i - 1] = "Dann";
                }
                else if (i % 5 == 0)
                {
                    NumToMax[i - 1] = "School";
                }
                else if (i % 3 == 0)
                {
                    NumToMax[i - 1] = "Build";
                }
                else
                {
                    NumToMax[i - 1] = i.ToString();
                }
            }

            foreach (var item in NumToMax)
            {
                Console.WriteLine(item);
            }

            //StringBuilder stringBuilder = new StringBuilder();
            //for(int i=0;i<100;i++)
            //{
            //    stringBuilder.Append(i.ToString());
            //}
            //var s = stringBuilder.ToString();

            Console.ReadLine();
        }
    }
}

