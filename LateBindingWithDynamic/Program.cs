using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace LateBindingWithDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            AddWithReflection();
            AddWithDynamic();

            Console.ReadLine();
        }

        private static void AddWithDynamic()
        {
            Assembly asm = Assembly.Load("MathLibarary");
            try
            {
                Type t = asm.GetType("MathLibarary.SimpleMath");
                dynamic inst = Activator.CreateInstance(t);
                Console.WriteLine("Result: {0}", inst.Add(3, 2));
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void AddWithReflection()
        {
            Assembly asm = Assembly.Load("MathLibarary");
            try
            {
                Type t = asm.GetType("MathLibarary.SimpleMath");
                object inst = Activator.CreateInstance(t);
                MethodInfo add = t.GetMethod("Add");
                Console.WriteLine("Result: {0}", add.Invoke(inst, new Object[] { 3, 2 }));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
