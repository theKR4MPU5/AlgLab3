using System;
using AlgLab3.Structures.LinkedList;
using AlgLab3.Tools;

namespace AlgLab3.Console.functions.list
{
    public class RemoveElements : MenuItemList
    {
        public RemoveElements(LinkedList<int> list, bool isSelected = false) : base(list,
            title: "4.7  Удаление всех вхождений элемента", isSelected)
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

                List.RemoveElements(value);
                System.Console.WriteLine("Результат удаления всех вхождений элемента:");
                System.Console.WriteLine(List);
            }
            else
            {
                System.Console.WriteLine("Введенное значение не является целым числом");
            }

            ConsoleUtil.Pause();
        }
    }
}