using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectNums
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num, i, j, start_num, end_num;
            Console.Write("Start Range : ");
            start_num = Convert.ToInt32(Console.ReadLine());
            Console.Write("End Range : ");
            end_num = Convert.ToInt32(Console.ReadLine());
            Console.Write("The prime numbers between {0} and {1} are : \n", start_num, end_num);

            for (num = start_num; num <= end_num; num++)
            {
                j = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        j++;
                        break;
                    }
                }

                if (j == 0 && num != 1)
                    Console.Write("{0} ", num);
            }
            Console.Write("\n");
        }
    }
}