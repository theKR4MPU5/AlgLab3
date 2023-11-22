using System;
using AlgLab3.Structures.LinkedList;
using AlgLab3.Tools;

namespace AlgLab3.Console.functions.list
{
    public class RemoveEverSecondElement : MenuItemList
    {
        public RemoveEverSecondElement(LinkedList<int> list, bool isSelected = false) : base(list,
            title: "4.4  Удаление всех вторых вхождений элемента", isSelected)
        {
        }

        public override void Execute()
        {
            ConsoleUtil.ClearScreen();

            System.Console.WriteLine($"[{Title.ToUpper()}]\n");

            System.Console.WriteLine("Изначальный список:");
            System.Console.WriteLine(List);

            List.RemovingSecondElement();
            System.Console.WriteLine("Результат удаления всех вторых вхождений элемента:");
            System.Console.WriteLine(List);

            ConsoleUtil.Pause();
        }
    }
}