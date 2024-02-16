using PatternsLab1.Classes.ControlElements;
using PatternsLab1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab1.Classes.Commands
{
    internal class SaveCommand : ICommand
    {
        GameManager gameManager;
        public SaveCommand(GameManager gameManager)
        {
            this.gameManager = gameManager;
        }

        public void Execute()
        {
            gameManager.Save();
        }
    }
}
