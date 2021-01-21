using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_tablouri
{
    class Program
    {
        private static int i;
        private static int n;

        static void Main(string[] args)
        {
            //Problema1();
            //Problema2();
            //Problema3();
            Problema4();
        }

        //Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea. 

        private static void Problema4()
        {
            int[] Problema4(int[] A, int start, int end)

            {

                n = int.Parse(Console.ReadLine());
                int max = int.Parse(Console.ReadLine());
                int min = int.Parse(Console.ReadLine());
                start = int.Parse(Console.ReadLine());
                end = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                    A[i] = int.Parse(Console.ReadLine());

                if (start == end)

                {
                    max = A[start];
                    min = A[start];
                }
                else if (start + 1 == end)
                {
                    if (A[start] < A[end])
                    {
                        max = A[end];
                        min = A[start];
                    }
                    else
                    {
                        max = A[start];
                        min = A[end];
                    }
                }
                else
                {
                    int mid = start + (end - start) / 2;
                    int[] left = Problema4(A, start, mid);
                    int[] right = Problema4(A, mid + 1, end);
                    if (left[0] > right[0])
                        max = left[0];
                    else
                        max = right[0];
                    if (left[1] < right[1])
                        min = left[1];
                    else
                        min = right[1];

                }
                // By convention, we assume ans[0] as max and ans[1] as min
                int[] ans = { max, min };
                Console.WriteLine(ans);
                Console.WriteLine($"{ min}");
                Console.WriteLine($"{max}");
            }
        }

         //Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului.
            private static void Problema3()
        {
            int n;
            Console.WriteLine("Introduceti n= ");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int max;
            int min;
            for (int i = 0; i < n; i++)

                v[i] = int.Parse(Console.ReadLine());

            min = v[0];
            max = v[0];
            for (int i = 1; i < n; i++)
            {
                if (v[i] < min)

                    min = v[i];

                else if (v[i] > max)

                    max = v[i];

            }
            Console.WriteLine($"Cel mai mare element al vectorului este{max}, iar cel mai mic element este {min} ");
            Console.ReadKey();
        }

            //Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k. 
            //Daca k nu apare in vector rezultatul va fi -1. 
            private static void Problema2()
            {

                Console.WriteLine("Introduceti n= ");
                int n = int.Parse(Console.ReadLine());
                int[] v = new int[n];
                Console.WriteLine("Introduceti k= ");
                int k = int.Parse(Console.ReadLine());
                int ok = 0;
                for (int i = 0; i < n; i++)
                {
                    v[i] = int.Parse(Console.ReadLine());

                }
                for (int i = 0; i < n && ok == 0; i++)
                {
                    if (v[i] == k)
                    {
                        ok = 1;
                        Console.WriteLine(i);

                    }
                    else if (ok == 0) ;
                }

                Console.WriteLine("Rezultatul este -1");
                Console.ReadKey();

            }

        //Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.
        private static void Problema1()
        {
            int n;
            Console.WriteLine("Introduceti n= ");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                sum += v[i];
            }
            Console.WriteLine(sum);
            Console.ReadKey();

        }
    }
}
