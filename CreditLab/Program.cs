using System.Collections.Concurrent;

namespace CreditLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //выбрал данную коллекцию, т.к. поток всего один и его нет одновременног добавления и удаления элементов разными потоками, а также время обработки каждого элемента небольшое
            var universitet = new ConcurrentQueue<Person>();

            var admin = new Administrator("Vasiliy", "Vasiliev", new DateTime (1998, 04, 16), new DateTime(2021, 11, 16), 50000, 12);
            var student = new Student("Petr", "Petrov", new DateTime (2005, 11, 16), "Math", "ME-23");
            var teacher = new Teacher("Evgeniy", "Monitov", new DateTime(1978, 08, 22), new DateTime(2003, 12, 05), 180000, "Physics", "Propfessor");
            var manger = new Manager("Natalia", "Frolova", new DateTime(1988, 02, 29), new DateTime(2020, 11, 15), 150000, "Physics", "Press Secretary");

            universitet.Enqueue(admin);
            universitet.Enqueue(student);
            universitet.Enqueue(teacher);
            universitet.Enqueue(manger);

            foreach (var person in universitet) 
            {
                Console.WriteLine(person);
            }

        }
    }
}
