using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace LateBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with late binding ****");
            Assembly a = null;
            try
            {
                a = Assembly.Load("CarLibrary");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (a != null)
            {
                CreateUsingLateBinding(a);
                InvokeMethodWithArgsUsingLateBinding(a);
            }

            Console.ReadLine();
        }

        private static void CreateUsingLateBinding(Assembly a)
        {
            try
            {
                Type t = a.GetType("CarLibrary.MiniVan");
                object obj = Activator.CreateInstance(t);
                Console.WriteLine("Object {0} created using late binding", obj);

                MethodInfo mi = t.GetMethod("TurboBoost");
                mi.Invoke(obj, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void InvokeMethodWithArgsUsingLateBinding(Assembly a)
        {
            try
            {
                Type sport = a.GetType("CarLibrary.SportsCar");
                object car = Activator.CreateInstance(sport);
                MethodInfo radio = sport.GetMethod("TurnOnMusic");
                radio.Invoke(car, new object[] { true, 2 });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
