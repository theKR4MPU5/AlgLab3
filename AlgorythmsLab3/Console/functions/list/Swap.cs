using System;
using AlgLab3.Structures.LinkedList;
using AlgLab3.Tools;

namespace AlgLab3.Console.functions.list
{
    public class Swap : MenuItemList
    {
        public Swap(LinkedList<int> list, bool isSelected = false) : base(list, title: "4.12 Поменять местами два элемента списка", isSelected)
        {
        }

        public override void Execute()
        {
            ConsoleUtil.ClearScreen();

            System.Console.WriteLine($"[{Title.ToUpper()}]\n");

            System.Console.WriteLine("Изначальный список:");
            System.Console.WriteLine(List);

            System.Console.WriteLine("Введите первое целое число: ");
            System.Console.CursorVisible = true;

            string input1 = System.Console.ReadLine();

            System.Console.WriteLine("Введите второе целое число: ");
            string input2 = System.Console.ReadLine();
            int value1;
            int value2;
            try
            {
                value1 = int.Parse(input1);
                value2 = int.Parse(input2);
            }
            catch (Exception e)
            {
                value1 = -1;
                value2 = -1;
            }

            if (value1 != -1 && value2 != -1)
            {
                System.Console.CursorVisible = false;

                try
                {
                    List.Swap(value2, value1);
                    System.Console.WriteLine("Результат смены местами двух элементов:");
                    System.Console.WriteLine(List);
                }
                catch (ArgumentException e)
                {
                    System.Console.WriteLine("Введеное значение отсутствует в списке");
                }
            }
            else
            {
                System.Console.WriteLine("Введенное значение не является целым числом");
            }

            ConsoleUtil.Pause();
        }
    }
}