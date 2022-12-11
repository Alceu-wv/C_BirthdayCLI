
using CLIHelpers;
using Data;

namespace BirthdayCLI
{
    internal class SearchPerson
    {
        PersonRepositoryInterface personRepository;
        InputString inputString = new InputString();

        public SearchPerson(PersonRepositoryInterface personRepository)
        {
            this.personRepository = personRepository;
        }
        public void Search()
        {
            string firstName;
            string lastName;

            try
            {
                firstName = inputString.InputStringFromUser("Digite o seu primeiro nome:");
                lastName = inputString.InputStringFromUser("Digite o seu sobrenome:");

                Person? person = personRepository.Pesquisar(firstName, lastName);
            
                if (person != null)
                {
                    Console.WriteLine("__________");
                    Console.WriteLine("Pessoa encontrada:");
                    Console.WriteLine(person.FirstName);
                    Console.WriteLine(person.LastName);
                    Console.WriteLine(person.Birthday);
                } else
                {
                    Console.WriteLine("Pessoa não encontrada");
                }
            
            
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
        public void ListAll()
        {
            var allPersons = personRepository.Listar();
            foreach (var person in allPersons)
            {
                Console.WriteLine(person.asString());
            }
        }
    }
}
