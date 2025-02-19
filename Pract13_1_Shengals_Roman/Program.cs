using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace pr13_1_Shengals_Roman
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ArrayList originalList = new ArrayList();
                Console.WriteLine("Введите элементы исходного списка, разделенные запятыми:");
                string input = Console.ReadLine();
                string[] elements = input.Split(',');

                foreach (string element in elements)
                {
                    originalList.Add(element.Trim());
                }

                Console.WriteLine("Введите индекс n1 для вставки новой коллекции:");
                int n1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите элементы новой коллекции, разделенные запятыми:");
                string newInput = Console.ReadLine();
                string[] newElements = newInput.Split(',');

                ArrayList newList = new ArrayList(originalList);
                newList.InsertRange(n1, newElements);

                int n = n1 / 2;
                Console.WriteLine("Введите количество k для удаления элементов:");
                int k = int.Parse(Console.ReadLine());

                for (int i = 0; i < k; i++)
                {
                    if (n < newList.Count)
                    {
                        newList.RemoveAt(n);
                    }
                }
                Console.WriteLine("Новый список:");
                foreach (var item in newList)
                {
                    Console.WriteLine(item);
                }
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Невернный ввод.");
            }
        }
    }
}
