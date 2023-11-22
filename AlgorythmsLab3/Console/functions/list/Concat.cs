using System;
using System.Collections.Generic;
using AlgLab3.Tools;

namespace AlgLab3.Console.functions.list
{
    public class Concat : MenuItemList
    {
        public Concat(Structures.LinkedList.LinkedList<int> list, bool isSelected = false) : base(list,
            title: "4.9  Дописать новый список в конец существующего", isSelected)
        {
        }

        public override void Execute()
        {
            ConsoleUtil.ClearScreen();

            System.Console.WriteLine($"[{Title.ToUpper()}]\n");

            System.Console.WriteLine("Введите список целых чисел через пробел: ");
            System.Console.CursorVisible = true;

            string input = System.Console.ReadLine();
            List<int> list = new List<int>();
            try
            {
                var symbols = input.Split(" ");
                foreach (var s in symbols)
                {
                    int value = int.Parse(s);
                    list.Add(value);
                }
            }
            catch (Exception e)
            {
                
            }

            System.Console.CursorVisible = false;

            System.Console.WriteLine("\nИзначальный список:");
            System.Console.WriteLine(List);

            List.Concat(list);
            System.Console.WriteLine("Результат вставки нового списка:");
            System.Console.WriteLine(List);

            ConsoleUtil.Pause();
        }
    }
}