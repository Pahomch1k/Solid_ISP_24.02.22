using System;

namespace Solid_ISP
{
    class Program
    {
        public static void Client1(IStream f)
        {
            PersonList a = new PersonList(2);
            a.SetFileStream(f);
            a.StreamText();
            a.StreamBinary();
        }

        public static void Client2(ILog f)
        {

            PersonList b = new PersonList(2);
            b.SetFileLog(f);
            b.LogConsole();
            b.LogFile();
        }

        static void Main(string[] args)
        { 
            static void Main(string[] args)
            {
                IStream f1 = new Formatter();
                Client1(f1);

                ILog f2 = new Log();
                Client2(f2);
            }
        }
    }
}
