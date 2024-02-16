using PatternsLab1.Classes.Commands;
using PatternsLab1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab1.Classes.Invoker
{
    internal class InputManager
    {
        private ICommand[] _commands;
        private const int COUNT = 8;
        public InputManager()
        {
            _commands = new ICommand[COUNT];
            for (int i = 0; i < COUNT; i++)
            {
                _commands[i] = new NoCommand();
            }
        }
        public void SetCommand(int index, ICommand command)
        {
            _commands[index] = command;
        }
        public void OnButtonPressed(int index)
        {
            _commands[index].Execute();
        }
        public override string ToString()
        {
            string res = "\t\t\t********Input_Manager********\n\t\t\t*****************************\nButtonIndex, Command\n__________________________\n";
            for (int i = 0; i < COUNT; i++)
            {
                res += $"{i}, {_commands[i].GetType().Name}\n";
            }
            res += '\n';
            return res;
        }
    }
}
