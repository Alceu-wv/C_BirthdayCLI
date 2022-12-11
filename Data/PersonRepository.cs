namespace Data;
public class PersonRepository : PersonRepositoryInterface
{
    private PersonDAO personDAO;

    public PersonRepository(PersonDAO personDAO) {
        this.personDAO = personDAO;
        AdicionarDummyPersons(); 
    }

    private void AdicionarDummyPersons()
    {
        DummyPersons dummyPersons = new DummyPersons();
        personDAO.reWrite(dummyPersons.GetDummyPersons);
    }

    public void Adicionar(Person pessoa)
    {
        personDAO.write(pessoa);
        Console.WriteLine(">>> " + pessoa.FirstName + " adicionado com sucesso.");
    }

    public List<Person> Listar()
    {
        return personDAO.readAll();
    }

    public void Remover(Person pessoa)
    {
        var allPersons = personDAO.readAll();
        try
        {
            allPersons.Remove(pessoa);
            personDAO.reWrite(allPersons);
            Console.WriteLine(">>> " + pessoa.FirstName + " removido com sucesso.");
        }
        catch
        {
            Console.WriteLine(">>> Erro ao remover pessoa:" + pessoa.FirstName);
        }
        
    }


    public Person Pesquisar(string? firstName, string? lastName)
    {
        var allPersons = personDAO.readAll();
        return allPersons.Find(x => x.FirstName == firstName || x.LastName == lastName);
    }

}
