using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AppConfigReaderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Reading <appSettings> Data ****");
            AppSettingsReader sr = new AppSettingsReader();
            int count = (int)sr.GetValue("Count", typeof(int));
            string color = (string)sr.GetValue("TextColor", typeof(string));

            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color);
            for (int i = 0; i < count; i++)
                Console.WriteLine("Settings succesfully read");

            Console.ReadLine();
        }
    }
}
