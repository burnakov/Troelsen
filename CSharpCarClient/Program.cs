using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarLibrary;

namespace CSharpCarClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** C# CarLibrary Client App ****");
            SportsCar viper = new SportsCar("Viper", 240, 40);
            viper.TurboBoost();

            MiniVan van = new MiniVan("Transporter", 150, 50);
            van.TurboBoost();

            Console.WriteLine("Done. To terminate press any key");
            Console.ReadLine();
        }
    }
}
