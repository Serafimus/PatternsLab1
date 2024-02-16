using PatternsLab1.Classes.ControlElements;
using PatternsLab1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab1.Classes.Commands
{
    internal class JumpCommand : ICommand
    {
        Player player;
        public JumpCommand(Player player)
        {
            this.player = player;
        }

        public void Execute()
        {
            player.Jump();
        }
    }
}
