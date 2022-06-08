using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Solid_ISP
{
    class Formatter: IStream
    {
        public void Text(List<Person> a)
        {
            WriteLine("Text");
        }

        public void Binary(List<Person> a)
        {
            WriteLine("Binary");
        }
    } 
}
