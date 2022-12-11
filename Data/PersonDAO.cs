using Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data;

public class PersonDAO : PersonDAOInterface
{
    private string directory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
    private string fileName = "BirthdayCLI.txt";

    public PersonDAO() { }
    public PersonDAO(string directory, string fileName)
    {
        this.directory = directory;
        this.fileName = fileName;
    }
    public void write(Person person)
    {
        string path = Path.Combine(directory, fileName);
        try
        {
            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine(person.FirstName + "," + person.LastName + "," + person.Birthday);
            sw.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
    }

    public void reWrite(List<Person> persons)
    {
        string path = Path.Combine(directory, fileName);
        try
        {
            clearTextContent();

            StreamWriter sw = new StreamWriter(path, true);
            
            foreach (Person person in persons)
            {
                sw.WriteLine(person.FirstName + "," + person.LastName + "," + person.Birthday);
            }
            sw.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
    }

    public void clearTextContent()
    {
        string path = Path.Combine(directory, fileName);
        StreamWriter sw = new StreamWriter(path);
        sw.WriteLine("");
        sw.Close();
    }

    public List<Person> readAll()
    {
        string path = Path.Combine(directory, fileName);
        var lines = File.ReadAllLines(path);
        var result = new List<Person>();

        if (lines.Length == 0)
        {
            Console.WriteLine("Você não tem amigos....");
        }
        else
        {
            foreach (var line in lines)
            {
                string[] personAsString = line.Split(',');
                if (personAsString.Length == 3)
                {
                    Person outPerson = new Person(
                            personAsString[0],
                            personAsString[1],
                            personAsString[2]
                        );
                    result.Add(outPerson);
                }
            }
        }
        return result;
    }
}
