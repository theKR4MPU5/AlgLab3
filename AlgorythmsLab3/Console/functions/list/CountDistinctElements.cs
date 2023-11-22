using System;
using AlgLab3.Structures.LinkedList;
using AlgLab3.Tools;

namespace AlgLab3.Console.functions.list
{
    public class CountDistinctElements : MenuItemList
    {
        public CountDistinctElements(LinkedList<int> list, bool isSelected = false) : base(list,
            title: "4.3  Определение количества различных элементов списка", isSelected)
        {
        }

        public override void Execute()
        {
            ConsoleUtil.ClearScreen();

            System.Console.WriteLine($"[{Title.ToUpper()}]\n");

            System.Console.WriteLine("Изначальный список:");
            System.Console.WriteLine(List);

            var list = List.CountWhole();
            System.Console.WriteLine("Количество различных элементов списка:");
            System.Console.WriteLine(list);

            ConsoleUtil.Pause();
        }
    }
}