using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travelling_salesman_problem
{
    class Program
    {                                                     //1  2  3  4  5  6
        private static int[,] prices = new int[6, 6] {   { -2,+4,+4,+5,+4,+3},  //1
                                                         { +2,-2,+7,+1,+1,+6},  //2
                                                         { +2,+3,-2,+9,+4,+5},  //3
                                                         { +1,+3,+2,-2,+3,+1},  //4
                                                         { +7,+4,+1,+1,-2,+4},  //5
                                                         { +2,+3,+4,+7,+9,-2} };//6

        static void Main(string[] args)
        {
            Salesman salesman = new Salesman(prices);
            Console.WriteLine(salesman.GetWay());

            Console.ReadKey();
        }
    }
}
