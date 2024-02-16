using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab1.Classes.ControlElements
{
    internal class GameManager
    {
        public void Save()
        {
            Console.WriteLine("Данные успешно сохранены.");
        }
        public void Load()
        {
            Console.WriteLine("Загрузка сохранения прошла успешно.");
        }
        public void Quit()
        {
            Environment.Exit(0);
        }
    }
}
