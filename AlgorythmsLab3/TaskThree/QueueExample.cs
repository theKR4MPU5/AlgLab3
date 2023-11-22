using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

class TaskSchedulerExample
{
    static Queue<Func<Task>> taskQueue = new Queue<Func<Task>>();

    static async Task Main()
    {
        EnqueueTask(() => PrintMessage("Task 1"));
        EnqueueTask(() => PrintMessage("Task 2"));
        EnqueueTask(() => PrintMessage("Task 3"));

        await ExecuteTasksAsync();

        Console.WriteLine("All tasks completed.");
    }

    static void EnqueueTask(Func<Task> task)
    {
        taskQueue.Enqueue(task);
    }

    static async Task ExecuteTasksAsync()
    {
        while (taskQueue.Count > 0)
        {
            Func<Task> task = taskQueue.Dequeue();
            await task();
        }
    }

    static async Task PrintMessage(string message)
    {
        Console.WriteLine($"Start: {message} on Thread {Thread.CurrentThread.ManagedThreadId}");
        await Task.Delay(2000); 
        Console.WriteLine($"End: {message} on Thread {Thread.CurrentThread.ManagedThreadId}");
    }
}
