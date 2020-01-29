
using System;
using System.Collections.Generic;

namespace CAdvanced
{
    class Program
    {
        delegate void MyDelegate();
        delegate int MyDelegateCount(int x, int y);

        internal delegate void SortingMethod<T>(T[] arr) where T : IComparable<T>;

        static void Abc()
        {
            Console.Write("Hi");
            Console.ReadLine();
        }
        static int Sum(int x, int y)
        {
            return x + y;
        }


        static void Main(string[] args)
        {
            var items = new List<string> { "Hi", "Welcome", "Exit" };
            var menu = new Menu(items, ConsoleColor.Red, ConsoleColor.White, 10, 10);
            menu.PressEnter += menu_PressEnter;
            menu.Show();
            Console.ReadLine();

            int[] x = { 3, 5, 8, 2, 9, 7 };
            SortMethod(x, BubbleSort);
            SelectionSort(x);
            BubbleSort(x);

            MyDelegate m = Abc;
            m();
            MyDelegateCount mc = Sum;
            int r = mc(4, 6);
            Console.WriteLine(r);

        }

        static void menu_PressEnter(object sender, MenuEventArgs e)
        {
            switch (e.Current)
            {
                case 0:
                    Console.Clear();
                    Console.WriteLine("Hi");
                    Console.ReadLine();
                    break;
                case 1:
                    Console.Clear();
                    Console.WriteLine("Welcome");
                    Console.ReadLine();
                    break;
                case 2:
                    e.IsExit = true;
                    break;
            }

        }

        public static void SortMethod<T>(T[] arr, SortingMethod<T> sortingMethod) where T : IComparable<T>
        {
            sortingMethod(arr);
        }
        static void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            Console.WriteLine("SelectionSort");
            for (var i = 0; i < arr.Length - 1; i++)
            {
                for (var j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i].CompareTo(arr[j]) > 0)
                    {
                        Swap(ref arr[i], ref arr[j]);
                    }

                }
            }
        }
        static void BubbleSort<T>(T[] arr) where T : IComparable<T>
        {
            Console.WriteLine("BubbleSort");
            var y = 1;
            do
            {
                for (int i = 0; i < arr.Length - y; i++)
                {
                    if (arr[i].CompareTo(arr[i + 1]) > 0)
                    {
                        Swap(ref arr[i], ref arr[1 + 1]);
                    }

                }
                y++;
            } while (false);

        }
        public static void Swap<T>(ref T obj1, ref T obj2)
        {
            T result = obj1;
            obj1 = obj2;
            obj2 = result;
        }

    }
}
