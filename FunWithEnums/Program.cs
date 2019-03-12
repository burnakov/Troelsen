using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with enums ****");
            EmpType emp = EmpType.Contractor;
            AskForBonus(emp);

            Console.WriteLine("EmpType uses a {0} as storage", Enum.GetUnderlyingType(emp.GetType()));
            Console.WriteLine("emp name is {0}, and value: {1}", emp.ToString(), Enum.Format(emp.GetType(), emp, "D"));
            DayOfWeek dw = DayOfWeek.Monday;
            ConsoleColor cc = ConsoleColor.Red;
            EvaluateEnum(emp);
            EvaluateEnum(dw);
            EvaluateEnum(cc);
            Console.ReadLine();
        }

        private static void EvaluateEnum(Enum e)
        {
            Console.WriteLine("information about {0} type", e.GetType().Name);
            Console.WriteLine("Underlying storage type: {0}", Enum.GetUnderlyingType(e.GetType()));
            Array enumData = Enum.GetValues(e.GetType());
            Console.WriteLine("This enum has {0} members", enumData.Length);
            for (int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine("Name {0}, value {0:D}", enumData.GetValue(i));
            }
            Console.WriteLine();
        }

        private static void AskForBonus(EmpType e)
        {
            switch (e)
            {
                case EmpType.Grunt:
                    Console.WriteLine("What ever you want, sir");
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("More mony?");
                    break;
                case EmpType.Manager:
                    Console.WriteLine("Here you go!");
                    break;
                case EmpType.VicePresident:
                    Console.WriteLine("Next week, maybe");
                    break;
            }
        }

        enum EmpType : byte
        {
            Manager,
            Contractor,
            Grunt,
            VicePresident
        }
    }
}
