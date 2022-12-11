using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface PersonDAOInterface
    {
        void write(Object person);

        void reWrite(List<Object> persons);

        void clearTextContent();

        List<Object> readAll();
    }
}
