using System;
using System.IO;
using System.Collections.Generic;

namespace VAR12_ZD2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            if (File.Exists("t.txt"))
            {
                int n1 = 0, n2 = 0, n3 = 0;
                Console.WriteLine("Введите начало интервала(а):");
              if (Int32.TryParse(Console.ReadLine(), out int a))
              {
                Console.WriteLine("Введите начало интервала(b):");
                if (Int32.TryParse(Console.ReadLine(), out int b))
                {
                    if (a < b)
                    {
                        Queue<int> fromAToB = new Queue<int>();
                        Queue<int> lessThenA = new Queue<int>();
                        Queue<int> moreThenB = new Queue<int>();
                        StreamReader sr = new StreamReader("t.txt");
                        List<string> num1 = new List<string>();

                        while (!sr.EndOfStream)
                        {
                            num1.AddRange(sr.ReadLine().Split(" "));
                        }
                        sr.Close();

                        for (int i = 0; i < num1.Count; i++)
                        {
                            int number = int.Parse(num1[i]);
                            if ((number >= a) && (number <= b))
                            {
                                fromAToB.Enqueue(number);
                                n1++;
                            }

                            else if (number < a)
                            {
                                lessThenA.Enqueue(number);
                                n2++;
                            }

                            else
                            {
                                moreThenB.Enqueue(number);
                                n3++;
                            }

                        }

                        for (int i = 0; i < n1; i++)
                        {
                            Console.Write(fromAToB.Dequeue() + " ");
                        }
                        Console.WriteLine();
                        for (int j = 0; j < n2; j++)
                        {
                            Console.Write(lessThenA.Dequeue() + " ");
                        }
                        Console.WriteLine();
                        for (int k = 0; k < n3; k++)
                        {
                            Console.Write(moreThenB.Dequeue() + " ");
                        }

                    }else { Console.WriteLine("а не должно быть больше b!"); }

                }else
                 { Console.WriteLine("Файл не найден!"); }
               }
            }
        }
    }
}
