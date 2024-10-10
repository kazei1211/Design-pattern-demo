using Command;
using System;

class Program
{
    static void Main(string[] args)
    {
        bool runProgram = true;

        Light light = new Light();
        RemoteControl remoteControl = new RemoteControl();
        RemoteControlWithUndo remoteControlWithUndo = new RemoteControlWithUndo();

        // Macro Command Setup
        ICommand[] macroCommands = { new LightOnCommand(light), new LightOffCommand(light) };
        MacroCommand macroCommand = new MacroCommand(macroCommands);

        // Callback Setup
        LightWithCallback lightWithCallback = new LightWithCallback();
        ICommand callbackCommand = new CallbackCommand(lightWithCallback.TurnOn);

        while (runProgram)
        {
            Console.WriteLine("Choose a Command Pattern Implementation:");
            Console.WriteLine("1. Basic Command (Turn On)");
            Console.WriteLine("2. Basic Command (Turn Off)");
            Console.WriteLine("3. Undoable Command (Turn On)");
            Console.WriteLine("4. Undoable Command (Undo)");
            Console.WriteLine("5. Macro Command (Turn On and Off)");
            Console.WriteLine("6. Callback Command");
            Console.WriteLine("7. Exit");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    remoteControl.SetCommand(new LightOnCommand(light));
                    remoteControl.PressButton();
                    break;
                case "2":
                    remoteControl.SetCommand(new LightOffCommand(light));
                    remoteControl.PressButton();
                    break;
                case "3":
                    remoteControlWithUndo.SetCommand(new LightUndoableOnCommand(light));
                    remoteControlWithUndo.PressButton();
                    break;
                case "4":
                    remoteControlWithUndo.PressUndo();
                    break;
                case "5":
                    macroCommand.Execute();
                    break;
                case "6":
                    callbackCommand.Execute();
                    break;
                case "7":
                    runProgram = false;
                    continue;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
            }
        }
    }
}
