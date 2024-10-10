using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public interface IUndoableCommand : ICommand
    {
        void Undo();
    }

    public class LightUndoableOnCommand : IUndoableCommand
    {
        private readonly Light _light;

        public LightUndoableOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOn();
        }

        public void Undo()
        {
            _light.TurnOff();
        }
    }

    public class LightUndoableOffCommand : IUndoableCommand
    {
        private readonly Light _light;

        public LightUndoableOffCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOff();
        }

        public void Undo()
        {
            _light.TurnOn();
        }
    }

    public class RemoteControlWithUndo
    {
        private IUndoableCommand _command;

        public void SetCommand(IUndoableCommand command)
        {
            _command = command;
        }

        public void PressButton()
        {
            _command.Execute();
        }

        public void PressUndo()
        {
            _command.Undo();
        }
    }

}
