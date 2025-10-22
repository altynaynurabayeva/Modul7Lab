using System;
using M7Lab.Commands;
using M7Lab.Devices;
using M7Lab.TemplateMethod;
using M7Lab.Mediator;

namespace M7Lab
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Command (Умный дом) ===\n");
            CommandDemo.Run();

            Console.WriteLine("\n=== Template Method (Напитки) ===\n");
            TemplateDemo.Run();

            Console.WriteLine("\n=== Mediator (Чат) ===\n");
            MediatorDemo.Run();
        }
    }
}
