using System;
using System.Collections.Generic;
using M7Lab.Devices;

namespace M7Lab.Commands
{
    public static class CommandDemo
    {
        public static void Run()
        {
            Light livingRoomLight = new Light();
            Television tv = new Television();
            AirConditioner ac = new AirConditioner();

            ICommand lightOn = new LightOnCommand(livingRoomLight);
            ICommand lightOff = new LightOffCommand(livingRoomLight);
            ICommand tvOn = new TVOnCommand(tv);
            ICommand tvOff = new TVOffCommand(tv);
            ICommand acOn = new ACOnCommand(ac);
            ICommand acOff = new ACOffCommand(ac);

            RemoteControl remote = new RemoteControl();

            remote.SetCommands(lightOn, lightOff);
            Console.WriteLine("Управление светом:");
            remote.PressOnButton();
            remote.PressOffButton();
            remote.PressUndoButton();

            remote.SetCommands(tvOn, tvOff);
            Console.WriteLine("\nУправление телевизором:");
            remote.PressOnButton();
            remote.PressOffButton();

            remote.SetCommands(acOn, acOff);
            Console.WriteLine("\nУправление кондиционером:");
            remote.PressOnButton();
            remote.PressOffButton();

            // Макрокоманда
            List<ICommand> allOn = new List<ICommand> { lightOn, tvOn, acOn };
            MacroCommand macroOn = new MacroCommand(allOn);
            Console.WriteLine("\nВключаем всё с помощью макрокоманды:");
            macroOn.Execute();
            Console.WriteLine("Отменяем макрокоманду:");
            macroOn.Undo();
        }
    }
}
