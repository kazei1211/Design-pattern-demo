using Memento;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        bool runProgram = true;
        Originator originator = new Originator();
        Caretaker caretaker = new Caretaker();
        ComplexOriginator complexOriginator = new ComplexOriginator();
        ComplexCaretaker complexCaretaker = new ComplexCaretaker();
        UndoRedoCaretaker undoRedoCaretaker = new UndoRedoCaretaker();
        DeepCopyOriginator deepCopyOriginator = new DeepCopyOriginator();

        while (runProgram)
        {
            Console.WriteLine("Choose a Memento Implementation:");
            Console.WriteLine("1. Basic Memento");
            Console.WriteLine("2. Complex Memento");
            Console.WriteLine("3. Undo/Redo Memento");
            Console.WriteLine("4. Deep Copy Memento");
            Console.WriteLine("5. Exit");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    originator.State = "State 1";
                    caretaker.SaveState(originator);
                    originator.State = "State 2";
                    caretaker.SaveState(originator);
                    caretaker.RestoreState(originator, 0);
                    Console.WriteLine($"Restored to: {originator.State}");
                    break;
                case "2":
                    complexOriginator.State = "Complex State";
                    complexOriginator.Value = 42;
                    complexCaretaker.SaveState(complexOriginator);
                    complexOriginator.State = "Another Complex State";
                    complexOriginator.Value = 100;
                    complexCaretaker.RestoreState(complexOriginator, 0);
                    Console.WriteLine($"Restored to: {complexOriginator.State}, Value: {complexOriginator.Value}");
                    break;
                case "3":
                    originator.State = "Undo State 1";
                    undoRedoCaretaker.SaveState(originator);
                    originator.State = "Undo State 2";
                    undoRedoCaretaker.SaveState(originator);
                    undoRedoCaretaker.Undo(originator);
                    Console.WriteLine($"Undo: {originator.State}");
                    undoRedoCaretaker.Redo(originator);
                    Console.WriteLine($"Redo: {originator.State}");
                    break;
                case "4":
                    deepCopyOriginator.State = "Deep State 1";
                    deepCopyOriginator.Data.Add("Key", "Value");
                    var deepMemento = deepCopyOriginator.Save();
                    deepCopyOriginator.State = "Deep State 2";
                    deepCopyOriginator.Data["Key"] = "New Value";
                    deepCopyOriginator.Restore(deepMemento);
                    Console.WriteLine($"Restored to: {deepCopyOriginator.State}, Data: {deepCopyOriginator.Data["Key"]}");
                    break;
                case "5":
                    runProgram = false;
                    continue;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
            }
        }
    }
}
