using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int last=0;
            for (int i = 0; i < 10; i++) {
                Console.Write(i+" ");
                last=last+i;
            }
            Console.WriteLine("Sonuç: "+last);
            Console.ReadKey();
        }
    }
}
