using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CountChar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> splitstr = new List<string>();
            
            Console.WriteLine("Please write in a meaningful sentence:");
            string input = Console.ReadLine();
            //拆開空格 變成字串的List
            var str = string.Join(Environment.NewLine,
                        input.Split(' ').ToList());
  
            //var countwords = input.Select(x => str).GroupBy(x => str).Count().ToString();

            //Console.WriteLine($"{str}:{countwords}");
            //{ str = p.countchar, CharChount = p.Count() } );
            /*參考
             * var q = from p in db.Products
                group p by p.CategoryID into g
                select new { CategoryID = g.Key, g };
            */
            

            Console.ReadLine();


        }
    }
}
