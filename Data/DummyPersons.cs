using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DummyPersons
    {
        List<Person> _dummyPersons = new List<Person>()
        {
            new Person("Alceu", "Lima", "12/07/1990"),
            new Person("Diego", "Martins", "15/02/1988")
        };

        public List<Person> GetDummyPersons { get { return _dummyPersons; } }

        public void InsertDummyPersons()
        {
            PersonDAO personDAO = new PersonDAO();
            personDAO.write(_dummyPersons[0]);
            personDAO.write(_dummyPersons[1]);
        }
    }
}
