using System;
using AlgLab3.Structures.LinkedList;
using AlgLab3.Tools;

namespace AlgLab3.Console.functions.list
{
    public class SwapFirstAndLast : MenuItemList
    {
        public SwapFirstAndLast(LinkedList<int> list, bool isSelected = false) : base(list,
            "4.2  Поменять местами первый и последний элемент", isSelected)
        {
        }

        public override void Execute()
        {
            ConsoleUtil.ClearScreen();

            System.Console.WriteLine($"[{Title.ToUpper()}]\n");

            System.Console.WriteLine("Изначальный список:");
            System.Console.WriteLine(List);

            List.SwapFirstAndLast();
            System.Console.WriteLine("Результат смены первого и последнего элемента:");
            System.Console.WriteLine(List);

            ConsoleUtil.Pause();
        }
    }
}