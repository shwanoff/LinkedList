using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем новый связный список.
            var list = new LinkedList<int>();

            // Добавляем элементы.
            list.Add(1);
            list.Add(5);
            list.Add(17);
            list.Add(42);
            list.Add(-69);

            // Выводим все элементы на консоль.
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Удаляем элемент.
            list.Delete(17);

            // Выводим все элементы еще раз.
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
