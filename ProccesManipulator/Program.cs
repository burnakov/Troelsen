using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProccesManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with processes ****");
            //ListAllRunningProcess();
            //GetSpecificProcess();
            //Console.WriteLine();

            //Console.WriteLine("**** Enter PID of process to exam ****");
            //Console.Write("PID: ");
            //string userInput = Console.ReadLine();
            //int pid = int.Parse(userInput);
            //EnumThreadsForPid(pid);
            //EnumModulesForPid(pid);
            StartAndKillProcess();

            Console.ReadLine();
        }

        static void StartAndKillProcess()
        {
            Process ieProc = null;
            try
            {
                ProcessStartInfo sInfo = new ProcessStartInfo("iexplore.exe", "www.ya.ru");
                sInfo.WindowStyle = ProcessWindowStyle.Minimized;
                ieProc = Process.Start(sInfo);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Hit enter to kill the {0}", ieProc.ProcessName);
            Console.ReadLine();
            try
            {
                ieProc.Kill();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void EnumModulesForPid(int pid)
        {
            Process proc = null;
            try
            {
                proc = Process.GetProcessById(pid);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            Console.WriteLine("Here is modules used by {0}:", proc.ProcessName);
            ProcessModuleCollection modColl = proc.Modules;
            foreach (ProcessModule mod in modColl)
            {
                string info = string.Format("-> Mod name: {0}", mod.ModuleName);
                Console.WriteLine(info);
            }
            Console.WriteLine("*******************************");
        }
        static void EnumThreadsForPid(int pid)
        {
            Process proc = null;
            try
            {
                proc = Process.GetProcessById(pid);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            Console.WriteLine("Here is threads used by {0}:", proc.ProcessName);
            ProcessThreadCollection thColl = proc.Threads;
            foreach (ProcessThread thread in thColl)
            {
                string info = string.Format("-> Thread ID: {0}\tStartTime: {1}\tPriority: {2}", thread.Id, thread.StartTime.ToShortTimeString(), thread.PriorityLevel);
                Console.WriteLine(info);
            }
            Console.WriteLine("***************************************");
        }
        private static void GetSpecificProcess()
        {
            Process proc = null;
            try
            {
                proc = Process.GetProcessById(987);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void ListAllRunningProcess()
        {
            var runningProc = from proc in Process.GetProcesses(".") orderby proc.ProcessName select proc;
            foreach (Process proc in runningProc)
            {
                string info = string.Format("PID: {0}\tName: {1}", proc.Id, proc.ProcessName);
                Console.WriteLine(info);
            }
                Console.WriteLine("*************************************");
        }
    }
}
