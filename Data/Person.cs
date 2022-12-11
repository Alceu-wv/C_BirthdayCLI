using System;

namespace Data;
public class Person:IComparable<Person>
    {
        private string? _firstName;
        private string? _lastName;
        private string? _birthday;

        public Person() { }
        public Person(string firstName, string lastName, string birthday)
        {
            _firstName = firstName;
            _lastName = lastName;
            _birthday = birthday;
        }

        public string asString()
        {
        return _firstName + "," + _lastName + "," + _birthday;
        }


        public string? FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string? LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public string? Birthday
        {
            get
            {
                return _birthday;
            }
            set
            {
                _birthday= value;
            }
        }

        public int CompareTo(Person person)
        {
            if (this.Birthday.Substring(3, 2) == person.Birthday.Substring(3, 2))
            {
                return person.Birthday.CompareTo(Int16.Parse(this.Birthday.Substring(0, 2)));
            }
                
            return person.Birthday.CompareTo(Int16.Parse(this.Birthday.Substring(3, 2)));
        }
    }