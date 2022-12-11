using Data;
using CLIHelpers;
using BirthdayCLI;

public class Programa
{

    static void Main(string[] args)
    //{
    //    Console.WriteLine("Selecione uma das opções abaixo:");
    //    DummyPersons dm = new DummyPersons();
    //    dm.InsertDummyPersons();

    //    PersonDAO personDAO = new PersonDAO();
    //    var ps = personDAO.readAll();
    //    foreach (Person person in ps) 
    //    {
    //        Console.WriteLine(person.asString());
    //    }





    //}
    {

        PersonDAO personDAO = new();
        PersonRepository personRepository = new(personDAO);
        SearchPerson searchPerson = new(personRepository);
        AddPerson addPerson = new(personRepository);
        InputNumber inputNumber = new();
        int userOperationChoice = 0;

            while (userOperationChoice != 4)
            {
                Console.WriteLine("Selecione uma das opções abaixo:");
                Console.WriteLine("1 - Pesquisar pessoas");
                Console.WriteLine("2 - Listar todas as pessoas");
                Console.WriteLine("3 - Adicionar pessoa");
                Console.WriteLine("4 - Remover pessoa");
                Console.WriteLine("5 - Sair");
                userOperationChoice = (int) inputNumber.InputNumberFromUser("______________");

                switch (userOperationChoice)
                {
                    case 1:
                        searchPerson.Search();
                        Console.WriteLine("__________");
                        break;
                    case 2:
                        searchPerson.ListAll();
                        Console.WriteLine("__________");
                        break;
                    case 3:
                        addPerson.Add();
                        Console.WriteLine("__________");
                        break;
                    case 4:
                        addPerson.Remove();
                        Console.WriteLine("__________");
                        break;
                    case 5:
                        Console.WriteLine(">>> Tchau. Volte sempre.");
                        break;
            }
        }

    }
}