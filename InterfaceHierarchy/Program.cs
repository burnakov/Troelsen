using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Interface hierarchy ****");
            BitmapImage myBitmap = new BitmapImage();
            myBitmap.Draw();
            myBitmap.DrawInBoundingBox(100, 58, 39, 78);
            myBitmap.DrawUpsideDown();

            IAdvancedDraw iAdvanced = myBitmap as IAdvancedDraw;
            if (iAdvanced != null)
                iAdvanced.DrawUpsideDown();

            Console.ReadLine();
        }
    }
}
