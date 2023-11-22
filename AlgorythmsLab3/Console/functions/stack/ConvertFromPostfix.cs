using System;
using System.Linq;
using AlgLab3.Structures.Stack;
using AlgLab3.Tools;

namespace AlgLab3.Console.functions.stack
{
    public class ConvertFromPostfix : MenuItem
    {
        public ConvertFromPostfix(bool isSelected = false) : base("1.4.1 Вычисление выражения, записанного в постфиксной записи",
            isSelected)
        {
        }

        public override void Execute()
        {
            System.Console.CursorVisible = true;
            do
            {
                ConsoleUtil.ClearScreen();
                System.Console.WriteLine($"[{Title.ToUpper()}]\n");
                System.Console.WriteLine("Введите выражение для подсчета (напрмер 2 9 8 * +)");
                string input = System.Console.ReadLine();
                try
                {
                    //var rpnLine = input.Replace(" ", "");
                    double result = CalcPostfix.CalculatePostfix(input);
                    System.Console.WriteLine($"Результат перевода: ( {input} ) = {result}");
                }
                catch (Exception e)
                {
                    System.Console.Write(
                        "Возникла ошибка при переводе выражения, возможно присутствуют недопустимые символы\n" +
                        "Строка должна содержать только числа и математические операции (например \"+\", \"/\", \"cos\")\n" +
                        "Выражение должно быть вида: 7 8 + 3 2 + /\n");
                }
            } while (ConsoleUtil.Continue());
        }
    }
}