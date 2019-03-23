using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using Pex_Project.ExternalProcess;

namespace Pex_Project
{
    

    public class PexRunner
    {

        static void Main(string[] args)
        {
            Command temp = Command.createPexCommand();
            RunProcess.ExecuteCommand(temp);
        }


        



    }
}
