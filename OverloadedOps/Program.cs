using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedOps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with overloaded operators ****");
            Point ptOne = new Point(100, 100);
            Point ptTwo = new Point(40, 40);

            Console.WriteLine("ptOne: {0}", ptOne);
            Console.WriteLine("ptTwo: {0}", ptTwo);

            Console.WriteLine("ptOne - ptTwo = {0}", ptOne - ptTwo);
            Console.WriteLine("ptOne + ptTwo = {0}", ptOne + ptTwo);

            Point newPt = ptOne + 10;
            Console.WriteLine("ptOne + 10 = {0}", newPt);
            Console.WriteLine("20 - newPt = {0}", 20 - newPt);

            Console.WriteLine("newPt: {0}", newPt);
            Console.WriteLine("newPt -= ptOne = {0}", newPt -= ptOne);
            Console.WriteLine("newPt += ptTwo = {0}", newPt += ptTwo);

            Console.WriteLine("newPt: {0}", newPt);
            Console.WriteLine("++newPt = {0}", ++newPt);
            Console.WriteLine("--newPt = {0}", --newPt);

            Console.WriteLine("newPt: {0}", newPt);
            Console.WriteLine("newPt++ = {0}", newPt++);
            Console.WriteLine("newPt-- = {0}", newPt--);
            Console.WriteLine("newPt: {0}", newPt);

            Console.WriteLine("ptOne == ptTwo: {0}", ptOne == ptTwo);
            Console.WriteLine("ptOne != ptTwo: {0}", ptOne != ptTwo);

            Console.WriteLine("ptOne > ptTwo: {0}", ptOne > ptTwo);
            Console.WriteLine("ptOne < ptTwo: {0}", ptOne < ptTwo);
            //Console.WriteLine("ptOne >= ptOne: {0}", ptOne >= ptOne);

            Console.ReadLine();
        }
    }
}
