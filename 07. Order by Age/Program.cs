namespace _07._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            
            List<Person> dataBase = new List<Person>();
            
            while ((input = Console.ReadLine()) != "End")
            {
                string[] personInformation = input
                    .Split()
                    .ToArray();
                string name = personInformation[0];
                string ID = personInformation[1];
                int age = int.Parse(personInformation[2]);
                if (!dataBase.Any(x => x.ID.Contains(ID)))
                { 
                    Person personality = new Person(name, ID, age);
                    dataBase.Add(personality);
                }
                else
                {
                     foreach (Person person in dataBase)
                     {
                         if (person.ID == ID)
                         {
                             person.Name = name;
                             person.Age = age;
                         }
                     }

                }
            }
            foreach (Person person in dataBase.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }
    class Person
    {
        public Person(string name, string id, int age) 
        {
            Name = name;
            ID = id;
            Age = age;

        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
}