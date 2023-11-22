using System;
using AlgLab3.Structures.LinkedList;
using AlgLab3.Tools;

namespace AlgLab3.Console.functions.list
{
    public class Split : MenuItemList
    {
        public Split(LinkedList<int> list, bool isSelected = false) : base(list, title: "4.10 Разделение списка на два по заданному числу", isSelected)
        {
        }

        public override void Execute()
        {
            ConsoleUtil.ClearScreen();

            System.Console.WriteLine($"[{Title.ToUpper()}]\n");

            System.Console.WriteLine("Изначальный список:");
            System.Console.WriteLine(List);

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
                value = -1;
            }

            if (value != -1)
            {
                System.Console.CursorVisible = false;

                var (list1, list2) = List.Split(value);
                System.Console.WriteLine("Результат разделения списка:");
                System.Console.WriteLine(list1);
                System.Console.WriteLine(list2);
            }
            else
            {
                System.Console.WriteLine("Введенное значение не является целым числом");
            }

            ConsoleUtil.Pause();
        }
    }
}