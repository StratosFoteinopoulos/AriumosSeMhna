using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriumosSeMhna
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give Number Of Month");
            int a=int.Parse(Console.ReadLine());
            while(a<1&&a>12)
            {
                Console.WriteLine("give valid number");
                a = int.Parse(Console.ReadLine());
            }
            //switch (Console.ReadLine()) {
            //    case "1":
                
            //    string month="january";
            //        Console.WriteLine(month);
            //        return;

            //    case "2":
            //        month = "Feb";
            //        Console.WriteLine(month);
            //        return;
            //}
            
        }
    }
}