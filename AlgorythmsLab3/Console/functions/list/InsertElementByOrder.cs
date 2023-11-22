using System;
using System.Linq;
using AlgLab3.Structures.LinkedList;
using AlgLab3.Tools;

namespace AlgLab3.Console.functions.list
{
    public class InsertElementByOrder : MenuItemList
    {
        public InsertElementByOrder(LinkedList<int> list, bool isSelected = false) : base(list,
            title: "4.6  Вставить элемент с сохранением порядка", isSelected)
        {
        }

        public override void Execute()
        {
            ConsoleUtil.ClearScreen();

            System.Console.WriteLine($"[{Title.ToUpper()}]\n");
            
            var orderedList = List.OrderBy(x => x).ToList();
            var list = new LinkedList<int>(orderedList);
            System.Console.WriteLine("Изначальный список:");
            System.Console.WriteLine(list);

            System.Console.WriteLine("Введите целое число: ");
            System.Console.CursorVisible = true;

            string input = System.Console.ReadLine();
            int value;
            try
            {
                value = int.Parse(input);
            }
            catch (Exception e)
            {
                value = int.MinValue;
            }

            if (value != int.MinValue)
            {
                System.Console.CursorVisible = false;

                list.InsertElementByOrder(value);
                System.Console.WriteLine("Результат вставки элемента с сохранением порядка:");
                System.Console.WriteLine(list);
            }
            else
            {
                System.Console.WriteLine("Введенное значение не является целым числом");
            }

            ConsoleUtil.Pause();
        }
    }
}