using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class ThreeDCircle : Circle, IDraw3D
    {
        public new string PetName { get; set; }
        public new void Draw()
        {
            Console.WriteLine("Drawing 3D circle");
        }
        public override void Test()
        {
            Console.WriteLine("3d circle class");
        }
        public void Draw3D()
        {
            Console.WriteLine("Drawing circle in 3D");
        }
    }
}
