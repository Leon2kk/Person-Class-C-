namespace GB
{

    public class Person
    {
        private string last;
        private string first;
        private string path;

        static private int countID = 0;

        private int id;

        public Person(string lastName, string firstName, string pathName = "")
        {
            countID++;
            id = countID;

            last = lastName;
            first = firstName;
            path = pathName;
        }

        public string GetAllName()
        {
            return  last  + " " + first + " " +  path;
        }

        public int GetID()
        {
            return  id;
        }


        // Remaining implementation of Person class.
    }
}