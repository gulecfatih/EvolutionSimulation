using EvolutionSimulation.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionSimulation.Classes
{
    // Memelilerin temel sınıfı olan Mammal
    abstract class Mammal : IAnimal, IEvolution
    {
        protected string _name; // Hayvanın adı

        protected Mammal(string name)
        {
            _name = name;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"{_name} bir memeli hayvandır.");
        }
        public virtual void GetSpecialProperty()
        {
            Console.WriteLine($"Özelliği Yok");
        }

    }
}
