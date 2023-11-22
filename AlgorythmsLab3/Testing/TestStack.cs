using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AlgLab3.Structures.Stack;
using AlgLab3.Tools;

namespace AlgLab3.Testing
{
    public class TestStack
    {
        //1 часть 2 задание
        public static Stack<object> TestingStackFile(string fileName)
        {
            var path = Path.GetFullPath(Directory.GetCurrentDirectory() + $"\\..\\..\\..\\Testing\\{fileName}");
            using StreamReader stream = new StreamReader(path);
            var text = stream.ReadToEnd();
            var stack = CommandUtil.GetCommandForStack(text);
            return stack;
        }

        public static void TestingStackRPN()
        {
            var path = Path.GetFullPath(Directory.GetCurrentDirectory() + "\\..\\..\\..\\Test\\input2.txt");
            if (File.Exists(path))
            {
                using StreamReader stream = new StreamReader(path);
                var text = stream.ReadToEnd();
                
                double result = CalcPostfix.CalculatePostfix(text);
                System.Console.WriteLine(result);
            }
            else
            {
                System.Console.WriteLine("Отсуствует файл input2.txt в директории с тестами");
            }
        }

        public static void TestingStackParseInRPN()
        {
            string text;
            System.Console.Write("Напишите выражение: ");
            text = System.Console.ReadLine();
            string result = ToPostfix.ParseInPostfix(text);
            System.Console.WriteLine(result);
        }

        public static Stack<object> TestingStack(string command)
        {
            var stack = CommandUtil.GetCommandForStack(command);
            return stack;
        }

        public static System.Collections.Generic.Stack<object> TestSharpStackRandom(string command)
        {
            var stack = CommandUtil.GetCommandForSharpStack(command);
            return stack;
        }







    }
}