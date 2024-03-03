using EvolutionSimulation.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // HomoSapiens sınıfından bir nesne oluşturulur ve ilgili metotlar çağrılır.
            HomoSapiens homoSapiens = new HomoSapiens("Homo Sapiens", 120);
            homoSapiens.DisplayInfo(); // Polymorphism özelliği kullanıldı
            homoSapiens.UseTools(); // HomoSapiens sınıfına özgü davranış
            homoSapiens.GetSpecialProperty();

            Console.WriteLine();

            // Rattus sınıfından bir nesne oluşturulur ve ilgili metotlar çağrılır.
            Rattus rattus = new Rattus("Rattus", true);
            rattus.DisplayInfo(); // Polymorphism özelliği kullanıldı
            rattus.Climb(); // Mammal sınıfından gelen davranış
            rattus.GetSpecialProperty();

            Console.ReadLine();
        }
    }
}
