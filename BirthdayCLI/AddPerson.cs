using Data;
using CLIHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCLI;

public class AddPerson
{
    PersonRepositoryInterface personRepository;
    InputString inputString = new InputString();

    public AddPerson(PersonRepositoryInterface personRepository)
    {
        this.personRepository = personRepository;
    }
    public void Add()
    {
        string firstName;
        string lastName;
        string birthday;

        try
        {
            firstName = inputString.InputStringFromUser("Digite o seu primeiro nome:");
            lastName = inputString.InputStringFromUser("Digite o seu sobrenome:");
            birthday = inputString.InputStringFromUser("Digite sua data de aniversário (formato: dd/mm/yyyy:)");

            Person p = new Person(firstName, lastName, birthday);

            personRepository.Adicionar(p);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.ReadKey();
        }
    }

    public void Remove()
    {
        string firstName;
        string lastName;

        try
        {
            firstName = inputString.InputStringFromUser("Digite o primeiro nome:");
            lastName = inputString.InputStringFromUser("Digite o sobrenome:");

            Person person = personRepository.Pesquisar(firstName, lastName); 
            if(person != null)
            {
                personRepository.Remover(person);
            } else {
                Console.WriteLine("Pessoa não encontrada");
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.ReadKey();
        }
    }
}
