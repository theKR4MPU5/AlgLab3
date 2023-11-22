using System;
using AlgLab3.Structures.LinkedList;
using AlgLab3.Tools;

namespace AlgLab3.Console.functions.list
{
    public class ReverseList : MenuItemList
    {
        public ReverseList(LinkedList<int> list, bool isSelected = false) : base(list, 
            title: "4.1  Перевернуть лист", isSelected)
        {
        }

        public override void Execute()
        {
            ConsoleUtil.ClearScreen();

            System.Console.WriteLine($"[{Title.ToUpper()}]\n");

            System.Console.WriteLine("Изначальный список:");
            System.Console.WriteLine(List);

            var list = List.Reverse();
            System.Console.WriteLine("Результат переворота:");
            System.Console.WriteLine(list);

            ConsoleUtil.Pause();
        }
    }
}