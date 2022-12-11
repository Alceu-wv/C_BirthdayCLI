using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface PersonDAOInterface
    {
        void write(Person person);

        void reWrite(List<Person> persons);

        void clearTextContent();

        List<Person> readAll();
    }
}
