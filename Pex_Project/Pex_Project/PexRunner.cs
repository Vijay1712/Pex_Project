using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Pex_Project
{
    public class Command
    {
        public string executable;
        public string arguments;
        public Command()
        {
        }
        public Command(string executable, string arguments)
        {
            this.executable = executable;
            this.arguments = arguments;
        }
    }

    public class PexRunner
    {

        static void Main(string[] args)
        {
            Command temp = Run_Pex_Command();
            ExecuteCommand(temp);
        }


        public static Command Run_Pex_Command()
        {
            Command command = new Command();
            command.executable = @"C:\Program Files\Microsoft Pex\bin\pex.x86.exe";
            return command;
        }

        public static void ExecuteCommand(Command command)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;

            startInfo.FileName = command.executable;
            startInfo.Arguments = command.arguments;

            Console.WriteLine(command.executable);
            Console.WriteLine(command.arguments);

            try
            {
                // Start the process with the info we specified.
                // Call WaitForExit and then the using statement will close.
                using (Process exeProcess = Process.Start(startInfo))
                {

                    exeProcess.WaitForExit();
                }
                //Console.WriteLine("finished");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


    }
}
