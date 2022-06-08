using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Solid_ISP
{
    class Log: ILog
    {
        public void Console(List<Person> a)
        {
            WriteLine("Console");
        }

        public void File(List<Person> a)
        {
            WriteLine("File");
        }
    }
} 