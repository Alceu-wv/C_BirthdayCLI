namespace Data;
public interface PersonRepositoryInterface
{
    public void Adicionar(Person pessoa);

    public List<Person> Listar();

    public void Remover(Person pessoa);


    public Person Pesquisar(string? firstName, string? lastName);
}
