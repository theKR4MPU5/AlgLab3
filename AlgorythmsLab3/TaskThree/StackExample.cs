using System;
using System.Collections.Generic;

class UndoExample
{
    static Stack<Action> undoStack = new Stack<Action>();
    static Stack<Action> redoStack = new Stack<Action>();
    static int currentValue = 0;
    
    static void Main()
    {
        PerformAction(() => { SetValue(5); });
        PerformAction(() => { SetValue(10); });
        PerformAction(() => { SetValue(20); });
        PrintCurrentValue();
        Undo();
        PrintCurrentValue();
        Redo();
        PrintCurrentValue();
    }

    
    static void SetValue(int newValue)
    {
        undoStack.Push(() => { currentValue = newValue; });
        redoStack.Clear(); // Clear redo stack after a new action
    }

    
    static void PerformAction(Action action)
    {
        action.Invoke();
        undoStack.Push(action);
    }

    
    static void Undo()
    {
        if (undoStack.Count > 0)
        {
            Action undoAction = undoStack.Pop();
            undoAction.Invoke();
            redoStack.Push(undoAction);
        }
        else
        {
            Console.WriteLine("Nothing to undo.");
        }
    }

    static void Redo()
    {
        if (redoStack.Count > 0)
        {
            Action redoAction = redoStack.Pop();
            redoAction.Invoke();
            undoStack.Push(redoAction);
        }
        else
        {
            Console.WriteLine("Nothing to redo.");
        }
    }

    static void PrintCurrentValue()
    {
        Console.WriteLine($"Current Value: {currentValue}");
    }
}
