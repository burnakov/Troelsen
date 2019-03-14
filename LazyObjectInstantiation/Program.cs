using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyObjectInstantiation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with lazy inastantiation ****");
            MediaPlayer mp = new MediaPlayer();
            mp.Play();

            MediaPlayer mp2 = new MediaPlayer();
            AllTracks tracks = mp2.GetAllTracks();

            Console.ReadLine();
        }
    }
}
