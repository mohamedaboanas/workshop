using System;

namespace HelloWorld
{
    interface IStackAdt
    {
        Boolean isEmpty();
        void Push(Object element);
        Object Pop();
        Object Peek();
        void Display();
    }
}