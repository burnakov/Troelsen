using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MlInterfaceHierarchy
{
    class Square : IShape
    {
        public int GetNumberOfSides()
        {
            return 4;
        }

        void IPrintable.Draw()
        {
            Console.WriteLine("IPrintable...");
        }
        void IDrawable.Draw()
        {
            Console.WriteLine("IDrawable...");
        }
        public void Print()
        {
            Console.WriteLine("Print from printable");
        }
    }
}
