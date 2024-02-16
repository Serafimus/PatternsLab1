using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab1.Classes.ControlElements
{
    internal class Player
    {
        public void Grab()
        {
            Console.WriteLine("Игрок схватил предмет");
        }
        public void Move()
        {
            Console.WriteLine("Игрок сделал шаг");
        }
        public void Jump()
        {
            Console.WriteLine("Игрок прыгнул");
        }
        public void Throw()
        {
            Console.WriteLine("Игрок что-то бросил");
        }
    }
}
