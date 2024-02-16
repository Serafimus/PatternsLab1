using PatternsLab1.Classes.ControlElements;
using PatternsLab1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab1.Classes.Commands
{
    internal class GrabCommand : ICommand
    {
        private Player player;
        public GrabCommand(Player player)
        {
            this.player = player;
        }
        public void Execute()
        {
            player.Grab();
        }
    }
}
