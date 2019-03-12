using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //BasicStringFunctionality();
            //StringConcatenation();
            //EscapeChars();
            //StringEquality();
            StringsAreImmutable();
            StringsAreImmutableYet();
            FunWithStringBuilder();
            Console.ReadLine();
        }

        private static void FunWithStringBuilder()
        {
            Console.WriteLine("=> Using StringBuilder:");
            StringBuilder sb = new StringBuilder("*** My afvorite games ***", 256);
            sb.AppendLine("\n");
            sb.AppendLine("Fallout" + "2");
            sb.AppendLine("The Long Dark");
            sb.AppendLine("The Witcher 3");
            Console.WriteLine(sb.ToString());
            sb.Replace("2", "All");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("sb has {0} characters", sb.Length);
            Console.WriteLine();
        }

        private static void StringsAreImmutableYet()
        {
            string s1 = "Another string"; // Chek CIL-code
            s1 = "Again?";
            Console.WriteLine(s1);
        }

        private static void StringsAreImmutable()
        {
            string s1 = "My new string";
            Console.WriteLine("s1 = {0}", s1);
            string upperString = s1.ToUpper();
            Console.WriteLine("upperString = {0}", upperString);
            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine();
        }

        private static void StringEquality()
        {
            Console.WriteLine("=> String equality:");
            string s1 = "Hello ";
            string s2 = "world.";
            Console.WriteLine("s1 = {0}\ns2 = {1}", s1, s2);
            Console.WriteLine();
            Console.WriteLine("s1 == s2: {0}", s1 == s2);
            Console.WriteLine("s1 == \"Hello \": {0}", s1 == "Hello ");
            Console.WriteLine("s1 == \"HELLO \": {0}", s1 == "HELLO ");
            Console.WriteLine("s1 == \"hello \": {0}", s1 == "hello ");
            Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
            Console.WriteLine("\"world\".Equals(s2): {0}", "world.".Equals(s2));
            Console.WriteLine("s2.CompareTo(\"world.\"): {0}", s2.CompareTo("world."));
            string s3 = s2;
            Console.WriteLine("s2.CompareTo(s3): {0}", s2.CompareTo(s3));
            Console.WriteLine();
        }

        private static void EscapeChars()
        {
            Console.WriteLine("=> Escape characters:");
            Console.WriteLine("A\t lot\t of\t tabs\a");
            Console.WriteLine("C:\\Users\\Peter\\Documents\a");
            Console.WriteLine("That's all.\n\n\n");
            Console.WriteLine(@"C:\Programm files\Visual Studio");
            Console.WriteLine(@"What's
                                        gonna
                                                happen?");
            Console.WriteLine(@"Another way to place quotes ""he says"".");
            Console.WriteLine();
        }

        private static void StringConcatenation()
        {
            Console.WriteLine("=> String concatenation:");
            string s1 = "Beautiful";
            string s2 = " world.";
            string s3 = s1 + s2;
            Console.WriteLine(s3);
            string s4 = string.Concat(s3, "I insist.");
            Console.WriteLine(s4);
            Console.WriteLine();
        }

        private static void BasicStringFunctionality()
        {
            Console.WriteLine("=> Basic string functionality:");
            string name = "Freddy";
            Console.WriteLine("name has {0} characters", name.Length);
            Console.WriteLine("name to uppercase: {0}", name.ToUpper());
            Console.WriteLine("name to lowercase: {0}", name.ToLower());
            Console.WriteLine("Is name contains a letter \"y\": {0}", name.Contains("y"));
            Console.WriteLine("name after replace: {0}", name.Replace("dy", ""));
            Console.WriteLine();
        }
    }
}
