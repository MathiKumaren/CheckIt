using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            NugetClass.nugetCls cls = new NugetClass.nugetCls();
            string f = string.Empty;
            cls.log(f);
        }
    }
}