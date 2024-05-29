using ConsoleApp2.Data;
using ConsoleApp2.Models;
using static ConsoleApp2.Models.People;

namespace ConsoleApp2
{
    public class Program
    {
        static void Kiir(IEnumerable<object> szemelyek)
        {
            foreach (var item in szemelyek)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Context db = new Context();

            if (!db.User.Any())
            {
                var sorok = File.ReadAllLines(@"\5.csv").Skip(1);
                foreach (var line in sorok)
                {
                    db.User.Add(new User(line));
                }
                db.SaveChanges();
            }
            Kiir(db.User);
        }
    }
}
