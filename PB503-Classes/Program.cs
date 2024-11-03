namespace PB503_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.Age = 10;
            human.Surname = "Huseynov";
            human.Name = "Sanan";
            human.ShowFullData();
        }
    }

    public class Human
    {
        public string Name = "Nameless"; 
        public string Surname = "Surnameless"; 
        public byte Age = 18; 

        public Human() { 
        Console.WriteLine("Human Created");
         }

         public Human(string name) : this()
        {
        Name = name;
        }


         public Human(string name, string surname) : this(name)
        {
        Surname=surname;
        }

        public Human(string name, string surname, byte age) : this(name, surname)
        {
            Age = age;
        }

        public void ShowFullData()
        {
            Console.WriteLine($"Name: {Name} Surname: {Surname} Age: {Age}");
        }

        public string GetFullData()
        {
            return $"Name: {Name} Surname: {Surname} Age: {Age}";
        }
    }
}
