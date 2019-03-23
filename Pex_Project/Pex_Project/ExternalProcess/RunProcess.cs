using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Pex_Project.ExternalProcess
{
    public class RunProcess
    {
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
