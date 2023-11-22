using System;
using AlgLab3.Structures.LinkedList;
using AlgLab3.Tools;

namespace AlgLab3.Console.functions.list
{
    public class InsertYourself : MenuItemList
    {
        public InsertYourself(LinkedList<int> list, bool isSelected = false) : base(list,
            title: "4.5  Вставка списка самого в себя", isSelected)
        {
        }

        public override void Execute()
        {
            ConsoleUtil.ClearScreen();

            System.Console.WriteLine($"[{Title.ToUpper()}]\n");

            System.Console.WriteLine("Изначальный список:");
            System.Console.WriteLine(List);

            System.Console.WriteLine("Введите число, после которого будет вставлен список: ");
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

                List.PasteYourself(value);
                System.Console.WriteLine("Результат вставки списка самого в себя:");
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