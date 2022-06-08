using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_ISP
{
    interface ILog
    {
        void Console(List<Person> a);
        void File(List<Person> a);
    }
}
