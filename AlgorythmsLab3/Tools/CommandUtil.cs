using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using AlgLab3.Structures.Stack;

namespace AlgLab3.Tools
{
    public class CommandUtil
    {
        public static Stack<object> GetCommandForStack(string text)
        {
            var commands = text.Split(" ");
            var stack = new Stack<object>();

            foreach (var item in commands)
            {
                try
                {
                    if (item.StartsWith("1"))
                    {
                        stack.Push(GetElement(item, '1'));
                        System.Console.WriteLine($"Push {GetElement(item, '1')}");
                    }
                    else if (item.StartsWith("2"))
                    {
                        System.Console.WriteLine($"Pop {stack.Pop() ?? "no. Stack is Empty"}");
                    }
                    else if (item.StartsWith("3"))
                    {
                        System.Console.WriteLine($"Top {stack.Top() ?? "is Empty"}");
                    }
                    else if (item.StartsWith("4"))
                    {
                        System.Console.WriteLine($"IsEmpty: {stack.IsEmpty()}");
                    }
                    else if (item.StartsWith("5"))
                    {
                        System.Console.WriteLine(stack.ToString());
                    }
                    else
                    {
                        throw new Exception("Неизвестная команда при работе со стэком");
                    }
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }
            }

            return stack;
        }

        public static System.Collections.Generic.Stack<object> GetCommandForSharpStack(string text)
        {
            var commands = text.Split(" ");
            var stack = new System.Collections.Generic.Stack<object>();

            foreach (var item in commands)
            {
                try
                {
                    if (item.StartsWith("1"))
                    {
                        stack.Push(GetElement(item, '1'));
                        System.Console.WriteLine($"Push {GetElement(item, '1')}");
                    }
                    else if (item.StartsWith("2"))
                    {
                        System.Console.WriteLine($"Pop {stack.Pop() ?? "no. Stack is Empty"}");
                    }
                    else if (item.StartsWith("3"))
                    {
                        System.Console.WriteLine($"Top {stack.Top() ?? "is Empty"}");
                    }
                    else if (item.StartsWith("4"))
                    {
                        System.Console.WriteLine($"IsEmpty: {stack.IsEmpty()}");
                    }
                    else if (item.StartsWith("5"))
                    {
                        System.Console.WriteLine(stack.ToString());
                    }
                    else
                    {
                        throw new Exception("Неизвестная команда при работе со стэком");
                    }
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }
            }

            return stack;
        }

        
        public static Queue<object> GetCommandForQueue(string command)
        {
            var commands = command.Split(" ");
            var queue = new Queue<object>();

            foreach (var item in commands)
            {
                try
                {
                    if (item.StartsWith("1"))
                    {
                        queue.Enqueue(GetElement(item, '1'));
                        System.Console.WriteLine($"Enqueue {GetElement(item, '1')}");
                    }


                    else if (item.StartsWith("2"))
                    {
                        System.Console.WriteLine($"Dequeue {queue.Dequeue() ?? "no. Queue is Empty"}");
                    }


                    else if (item.StartsWith("3"))
                    {
                        System.Console.WriteLine($"Peek {queue.Peek() ?? "is Empty"}");
                    }

                    else if (item.StartsWith("4"))
                    {
                        System.Console.WriteLine($"IsEmpty: {queue.IsEmpty}");
                    }

                    else if (item.StartsWith("5"))
                        queue.Print();
                    else
                        throw new Exception("Неизвестная команда при работе с очередью");
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
            }

            return queue;
        }
        
        public static System.Collections.Generic.Queue<object> GetCommandForSharpQueue(string command)
        {
            var commands = command.Split(' ').Where(x => x.IsNormalized()).Select(x => x.Trim());
            var queue = new System.Collections.Generic.Queue<object>();

            foreach (var item in commands)
            {
                try
                {
                    if (item.StartsWith("1"))
                    {
                        queue.Enqueue(GetElement(item, '1'));
                        System.Console.WriteLine($"Enqueue {GetElement(item, '1')}");
                    }


                    else if (item.StartsWith("2"))
                    {
                        System.Console.WriteLine($"Dequeue {queue.Dequeue() ?? "no. Queue is Empty"}");
                    }


                    else if (item.StartsWith("3"))
                    {
                        System.Console.WriteLine($"Peek {queue.Peek() ?? "is Empty"}");
                    }

                    else if (item.StartsWith("4"))
                    {
                        System.Console.WriteLine($"IsEmpty: {queue.Count < 1}");
                    }

                    else if (item.StartsWith("5"))
                        System.Console.WriteLine(queue.ToString());
                    else
                        throw new Exception("Неизвестная команда при работе с очередью");
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
            }

            return queue;
        }
        
        private static object GetElement(string command, char num)
        {
            var answer = command.Split(',');
            if (answer.Length == 2)
                return answer[1];
            else if (answer.Length == 3)
                return answer[1].Concat(answer[2]);
            else
                return null;
        }
    }
}