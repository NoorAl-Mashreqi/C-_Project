using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Visit v1 = new Visit("Noor");
            string result= v1.toString();
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
