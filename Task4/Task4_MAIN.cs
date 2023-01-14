using System;

class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>(); //Записуємо людей
        List<Product> products = new List<Product>(); //Записуємо продукти

        string[] allPeople = Console.ReadLine().Split(';');
        string[] allProducts = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string p in allPeople) //Додаю покупців у список
        {
            string[] pers = p.Split('='); //Записую дані у масив string упускаючи симво "="


            if (decimal.Parse(pers[1]) < 0 || pers[0] == "" || pers[0] == " ")
            {
                if (pers[0] == "" || pers[0] == " ")
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                if (decimal.Parse(pers[1]) < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
            }
            else
            {
                Person person = new Person(pers[0], decimal.Parse(pers[1]));
                people.Add(person);
            }
        }

        foreach (string pair in allProducts) //Додаю продукти у список
        {
            string[] prod = pair.Split('=');

            if (decimal.Parse(prod[1]) < 0 || prod[0] == "" || prod[0] == " ")
            {
                if (prod[0] == "" || prod[0] == " ")
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                if (decimal.Parse(prod[1]) < 0)
                {
                    throw new ArgumentException("Price cannot be negative");
                }
            }
            else
            {
                var product = new Product(prod[0], decimal.Parse(prod[1]));
                products.Add(product);
            }

        }

        string str;

        while ((str = Console.ReadLine()) != "END")
        {
            string[] purchaseInfo = str.Split(' ');
            string buyerName = purchaseInfo[0], productName = purchaseInfo[1];
            int k = 0;

            Console.WriteLine();

            foreach (Person buyer in people)
            {
                if (buyerName == buyer.Name)
                {
                    foreach (Product ProductToBuy in products)
                    {
                        if (ProductToBuy.Name == productName)
                        {
                            ++k;

                            if (k > 0)
                            {
                                buyer.BuyProduct(ProductToBuy);
                                k = 0;
                            }
                            break;
                        }
                    }
                }
            }


        }

        Console.WriteLine();

        foreach (Person p in people) { p.GetInfo(); }
    }
}