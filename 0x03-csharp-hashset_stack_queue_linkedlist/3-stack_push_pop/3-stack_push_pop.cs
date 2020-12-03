using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        bool doesItTho = aStack.Contains(search);

        Console.WriteLine($"Number of items: {aStack.Count}");
        if (aStack.TryPeek(out string result))
            Console.WriteLine($"Top item: {result}");
        else
            Console.WriteLine("Stack is empty");
        Console.WriteLine($"Stack contains \"{search}\": {doesItTho}");
        if (doesItTho)
        {
            string poppy = "";
            while (poppy != search)
                poppy = aStack.Pop();
        }
        aStack.Push(newItem);
        return aStack;
    }
}
