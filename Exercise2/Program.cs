using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        int[]Lemon = new int[20];
        int n;
        int i;
        private object int32;

        public void input()
        {
            while(true)
            {
                Console.Write("enter the number of element in the array :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine("\nArray should have minimum 1 and maximum 20 elements.\n");

            }
            Console.WriteLine("");
            Console.WriteLine("-------------");
            Console.WriteLine("Enter Array");
            Console.WriteLine("-------------");
            for(i = 0; i < n; i++)
            {
                Console.WriteLine("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                Lemon[i] = Int32.Parse(s1);
            }
        }
        public void BubbleSortArray()
        {
           for (int i = 0; i < n; i++)
            {
                for(int RP = 0; RP < n; RP++)
                {
                    if(Lemon[RP] > Lemon[RP + 1])
                    {
                        int temp;
                        temp = Lemon[RP];
                        Lemon[RP] = Lemon[RP + 1];
                        Lemon[RP + 1] = temp
                    }
                }
            }
        }

    }
}


