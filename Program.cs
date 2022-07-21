namespace GB
{
    class Program
    {
        public static void Main()
        {
           Console.Clear();
           
           Person[] person = new Person[3];

           person[0] = new Person("Иванов", "Иван", "Иванович");
           person[1] = new Person("Петров", "Петр", "Петрович");
           Person man = new Person("Петров1", "Петр1", "Петрович1");
           person[2] = new Person("Smith", "Alex");
           

           arrayPrint(person);
        }

        public static void arrayPrint(Person[] person)
        {
            for (int i = 0; i < person.GetLength(0); i++)
            {
                Console.WriteLine(person[i].GetID() + " " + person[i].GetAllName());
            }
        }

    }
}
