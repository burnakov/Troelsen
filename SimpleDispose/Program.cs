using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDispose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with dispose ****");
            MyResourceWrapper rw = new MyResourceWrapper();
            if (rw is IDisposable)
                rw.Dispose();
            //OR
            //using (MyResourceWrapper rw1 = new MyResourceWrapper(), rw2 = new MyResourceWrapper())
            //{
            //    // use rw1 and rw2 
            //}

                DisposeFileStream();

            Console.ReadLine();
        }

        private static void DisposeFileStream()
        {
            FileStream f = new FileStream("myFile.txt", FileMode.OpenOrCreate);
            f.Close();
            f.Dispose(); // Do the same thing as Close()
        }
    }
}
