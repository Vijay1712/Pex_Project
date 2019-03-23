using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pex_Project.ExternalProcess
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

        public static Command createPexCommand()
        {
            Command command = new Command();
            command.executable = @"C:\Program Files\Microsoft Pex\bin\pex.x86.exe";
            return command;
        }
    }
}
