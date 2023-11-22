using System;
using System.Linq;
using AlgLab3.Structures.Stack;
using AlgLab3.Tools;

namespace AlgLab3.Console.functions.stack
{
    public class ConvertToPostfix : MenuItem
    {
        public ConvertToPostfix(bool isSelected = false) : base("1.4.2 Перевод в постфиксную запись", isSelected)
        {
        }

        public override void Execute()
        {
            System.Console.CursorVisible = true;
            do
            {
                ConsoleUtil.ClearScreen();
                System.Console.WriteLine($"[{Title.ToUpper()}]\n");
                System.Console.WriteLine("Введите выражение для перевода в постфиксную запись (напрмер 2 + 9 * 8)");
                string input = System.Console.ReadLine();
                string resultLine = ToPostfix.ParseInPostfix(input);
                if (resultLine == String.Empty)
                {
                    System.Console.Write("Возникла ошибка при переводе выражения, возможно присутствуют недопустимые символы\n" +
                                  "Строка должна содержать только числа и математические операции (например \"+\", \"/\", \"cos\")\n" +
                                  "Выражение должно быть вида: (2+2) * 2\n");
                }
                else
                {
                    //var rpnLine = resultLine.Replace(" ", "");
                    double result = CalcPostfix.CalculatePostfix(resultLine);
                    System.Console.WriteLine($"Результат перевода: ( {resultLine} ) = {result}");
                }
            } while (ConsoleUtil.Continue());

            System.Console.CursorVisible = false;
        }
    }
}