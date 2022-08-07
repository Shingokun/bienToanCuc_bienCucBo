using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bienToanCuc_bienCucBo
{
    internal class Program
    {
        static int Value = 5;
        static void Main(string[] args)
        { 
            Console.WriteLine(Value);
            Value = 10;
            PrintSomething();   
            if (Value == 10)
            {
                int i = 55;
                Console.WriteLine(i);
            }
            else
            {
                //i này ko nhận vì int i ở tên là biến cục bộ chỉ sử dụng trong tầm vực của nó  
            }


            Console.ReadKey();
        }
        static void PrintSomething()
        {
            int Value = 9;
            Console.WriteLine(Value);
        }
    }
}
