using PatternsLab1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab1.Classes.Commands
{
    internal class NoCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Команда не назначена");
        }
    }
}
