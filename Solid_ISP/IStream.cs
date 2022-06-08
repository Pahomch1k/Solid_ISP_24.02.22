using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_ISP
{
    interface IStream
    { 
        void Text(List<Person> a);
        void Binary(List<Person> a); 
    }
}
