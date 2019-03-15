using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class SportsCar : Car
    {
        public SportsCar() { }
        public SportsCar(string name, int max, int curr) : base(name, max, curr) { }

        public override void TurboBoost()
        {
            MessageBox.Show("Ramming speed!", "Faster is better...");
        }
    }
    public class MiniVan:Car
    {
        public MiniVan() { }
        public MiniVan(string name, int max, int curr) : base(name, max, curr) { }

        public override void TurboBoost()
        {
            engineStatus = EngineState.engineDead;
            MessageBox.Show("Eik!", "Your engine block is dead");
        }
    }
}
