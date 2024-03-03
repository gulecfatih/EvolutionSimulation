using EvolutionSimulation.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionSimulation.Classes
{
    class HomoSapiens : Mammal, IHomoSapiens
    {
        private int _iq; // Homo Sapiens'in IQ değeri

        // Yapılandırıcı metot
        public HomoSapiens(string name, int iq) : base(name)
        {
            _name = name;
            _iq = iq;
        }

        // IAnimal arabiriminden uygulanan metotlar
        public override void DisplayInfo()
        {
            Console.WriteLine($"{_name} türünden bir canlıdır.");
        }

        // IEvolution arabiriminden uygulanan metot
        public override void GetSpecialProperty()
        {
            Console.WriteLine($"Yüksek IQ: {_iq}");
        }

        public void UseTools()
        {
            Console.WriteLine($"{_name} araç kullanıyor.");
        }
    }
}
