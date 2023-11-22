using System;
using System.Drawing;
using AlgLab3.Structures.LinkedList;
using AlgLab3.Tools;

namespace AlgLab3.Console.functions.list
{
    public class Insert : MenuItemList
    {
        public Insert(LinkedList<int> list, bool isSelected = false) : base(list, title: "4.8  Вставить элемент \'F\' перед первым вхождением элемента \'E\'", isSelected)
        {
        }

        public override void Execute()
        {
            ConsoleUtil.ClearScreen();

            System.Console.WriteLine($"[{Title.ToUpper()}]\n");

            System.Console.WriteLine("Изначальный список:");
            System.Console.WriteLine(List);

            System.Console.WriteLine("Введите целое число \'F\': ");
            System.Console.CursorVisible = true;

            string input1 = System.Console.ReadLine();

            System.Console.WriteLine("Введите целое число \'E\': ");
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

                List.Insert(value2, value1);
                System.Console.WriteLine("Результат вставки элемента \'F\':");
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