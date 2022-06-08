using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_ISP
{
    class PersonList
    {
        IStream stream;
        ILog log;

        List<Person> group;

        public List<Person> Group
        {
            get { return group; } 
        }

        public PersonList()
        { }

        public PersonList(int a)
        {
            group = new List<Person>(a);
        }

        public void SetFileStream(IStream b)
        {
            stream = b;
        }

        public void StreamText()
        {
            stream.Text(Group);
        }

        public void StreamBinary()
        {
            stream.Binary(Group);
        }

        public void SetFileLog(ILog a)
        {
            log = a;
        }

        public void LogConsole()
        {
            log.Console(Group);
        }

        public void LogFile()
        {
            log.File(Group);
        }
    }
}
