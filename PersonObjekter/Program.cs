namespace PersonObjekter
{
    public class Program
    {
         static void Main(string[] args)
        {
            Person myPerson = new Person();

            Navn(myPerson);
            Password(myPerson);
            Email(myPerson);
            DoBAge(myPerson);
        }


        static void Navn(Person myPerson)
        {
            do
            {
                Console.WriteLine("Skriv dit navn her");
                string? nameInput = Console.ReadLine();
                myPerson.Name = nameInput;
            }
            while (myPerson.Name == null);
        }

         static void Email(Person myPerson)
        {
            do
            {
              Console.WriteLine("Skriv din Email her");
              string? EmailInput = Console.ReadLine();
              myPerson.Email = EmailInput;
            }
            while (myPerson.Email == null);

            Console.Clear();
            Console.WriteLine($"Hej, Dit Navn er {myPerson.Name}");
            Console.WriteLine($"Din Mail er {myPerson.Email}");
            Console.WriteLine($"Dit password er {myPerson.Password}");
        }

        static void DoBAge(Person myPerson)
        { 
            myPerson.DoB = new DateTime(2000, 1, 1);
            Console.WriteLine($"Din alder er {myPerson.GetAge()} ");
        }

        static void Password(Person myPerson)
        {
            do
            {
                Console.WriteLine("Skriv dit password her ");
                string? passwordInput = Console.ReadLine();
                myPerson.Password = passwordInput;
            }
            while (myPerson.Password == null);

      
        } 

    }
}
