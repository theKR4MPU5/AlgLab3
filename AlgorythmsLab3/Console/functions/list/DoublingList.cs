using System;
using AlgLab3.Structures.LinkedList;
using AlgLab3.Tools;

namespace AlgLab3.Console.functions.list
{
    public class DoublingList : MenuItemList
    {
        public DoublingList(LinkedList<int> list, bool isSelected = false) : base(list, title: "4.11 Удвоение списка", isSelected)
        {
        }

        public override void Execute()
        {
            ConsoleUtil.ClearScreen();

            System.Console.WriteLine($"[{Title.ToUpper()}]\n");

            System.Console.WriteLine("Изначальный список:");
            System.Console.WriteLine(List);

            List.DoublingList();
            System.Console.WriteLine("Результат удвоения списка:");
            System.Console.WriteLine(List);

            ConsoleUtil.Pause();
        }
    }
}