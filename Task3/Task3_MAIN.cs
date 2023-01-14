using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Chicken name: ");

        string chicken_name = Console.ReadLine();

        if (chicken_name == null || chicken_name == "" || chicken_name == " ")
        {
            if (chicken_name == null)
            {
                throw new ArgumentException("Name cannot be null");
            }
            if (chicken_name == "")
            {
                throw new ArgumentException("Name cannot be empty");
            }
            if (chicken_name == " ")
            {
                throw new ArgumentException("Name cannot be \"SPACE\" symbol");
            }
        }
        else
        {
            Console.Write("Chicken age: ");

            int age = int.Parse(Console.ReadLine());

            if (age > 0 && age <= 15)
            {
                Console.Write("How many eggs can produce " + chicken_name + "?: ");

                int epd = int.Parse(Console.ReadLine());

                if (epd <= 0) { epd = 0; } //Якщо введемо кількість яєць меншу рівну за нуль

                Chicken chicken = new Chicken(chicken_name, age, epd);

                Console.WriteLine(chicken.GetInfo());
            }
            else
            {
                throw new ArgumentException("\nAge should be between 0 and 15.");
            }
        }
    }
}