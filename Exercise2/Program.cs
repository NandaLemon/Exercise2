using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        int[] Lemon = new int[22];
        int n;
        int i;
        private object int32;

        public void input()
        {
            while (true)
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
            for (i = 0; i < n; i++)
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
                for (int RP = 0; RP < n; RP++)
                {
                    if (Lemon[RP] > Lemon[RP + 1])
                    {
                        int temp;
                        temp = Lemon[RP];
                        Lemon[RP] = Lemon[RP + 1];
                        Lemon[RP + 1] = temp;
                    }
                }
            }
        }
        void swap(int x, int y)

        {
            int temp;

            temp = Lemon[x];
            Lemon[x] = Lemon[y];
            Lemon[y] = temp;
        }
        public void QuicksortArray(int low, int high)
        {
            int pivot, i, RP;
            if (low > high)
                return;
            i = low + 1;
            RP = high;

            pivot = Lemon[low];
            while (i <= RP)
            {
                while ((Lemon[i] <= pivot) && (i <= high))
                {
                    i++;
                }
                if (i < RP)
                {
                    swap(i, RP);
                }
            }
            if (low < RP)
            {
                swap(low, RP);
            }
            QuicksortArray(low, RP - 1);
            QuicksortArray(RP + 1, high);

        }
        static void Main(string[] args)
        {
            Program myList = new Program();
            int pilianmenu;
            do
            {
                Console.WriteLine("Menu Option");
                Console.WriteLine("========================");
                Console.WriteLine("1.Bubblesorth");
                Console.WriteLine("2.Quicksort");
                Console.WriteLine("3.Exit");
                Console.Write("Enter your choice (1,2,3) :");
                pilianmenu = Convert.ToInt32(Console.ReadLine());

                switch (pilianmenu)
                {
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("Bubblesort");
                        Console.WriteLine("-------------------------");
                        myList.input();
                        myList.BubbleSortArray();
                        break;

                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("Quicksort");
                        Console.WriteLine("-------------------------");
                        myList.input();
                        myList.QuicksortArray();
                        break;

                    case 3:
                        Console.WriteLine("exit.");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
                Console.WriteLine("\n\nPress Return to Exit.");
                Console.ReadLine();
            } while (pilianmenu != 3);

        }

        private void QuicksortArray()
        {
            throw new NotImplementedException();
        }
    }
}


