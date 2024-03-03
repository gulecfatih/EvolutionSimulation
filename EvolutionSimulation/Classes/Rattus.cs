using EvolutionSimulation.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionSimulation.Classes
{
    class Rattus : Mammal, IRattus
    {
        private bool _canGnaw; // Rattus'un kemirme yeteneği

        // Yapılandırıcı metot
        public Rattus(string name, bool canGnaw) : base(name)
        {
            _name = name;
            _canGnaw = canGnaw;
        }

        public void Climb()
        {
            Console.WriteLine($"{_name} tırmanıyor.");
        }

        // IAnimal arabiriminden uygulanan metotlar
        public override void DisplayInfo()
        {
            Console.WriteLine($"{_name}'tur.");
        }

        // IEvolution arabiriminden uygulanan metot
        public override void GetSpecialProperty()
        {
            Console.WriteLine($"Kemirme Yeteneği: {_canGnaw}");
        }

    }
}
