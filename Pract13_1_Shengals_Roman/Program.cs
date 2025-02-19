using System;
using System.Collections;

namespace pr13_1_Shengals_Roman
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // 1. Добавление новой коллекции
                ArrayList originalList = new ArrayList();
                Console.WriteLine("Введите элементы исходного списка, разделенные запятыми:");
                string input = Console.ReadLine();
                string[] elements = input.Split(',');

                foreach (string element in elements)
                {
                    originalList.Add(element.Trim());
                }

                // 2. Вставка новой коллекции
                int n1;
                while (true)
                {
                    Console.WriteLine("Введите неотрицательный индекс n1 для вставки новой коллекции:");
                    n1 = int.Parse(Console.ReadLine());
                    if (n1 >= 0) break;
                    Console.WriteLine("Ошибка: индекс не может быть отрицательным. Попробуйте снова.");
                }

                Console.WriteLine("Введите элементы новой коллекции, разделенные запятыми:");
                string newInput = Console.ReadLine();
                string[] newElements = newInput.Split(',');

                ArrayList newList = new ArrayList(originalList);
                newList.InsertRange(n1, newElements);

                // 3. Удаление k элементов, начиная с индекса n (n = n1 / 2)
                int n = n1 / 2;
                int k;
                while (true)
                {
                    Console.WriteLine("Введите количество k для удаления элементов:");
                    k = int.Parse(Console.ReadLine());
                    if (k >= 0) break;
                    Console.WriteLine("Ошибка: количество не может быть отрицательным. Попробуйте снова.");
                }

                // Убедимся, что не пытаемся удалить слишком много элементов
                for (int i = 0; i < k && n < newList.Count; i++)
                {
                    newList.RemoveAt(n);
                }

                // 4. Вывод нового списка
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
