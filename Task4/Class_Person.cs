class Person
{
    //Приватні поля
    private string name; //Ім'я людини
    private decimal money; //Гроші, які є у людини
    private List<Product> bag; //Сумка з продуктами

    //Властивості
    public string Name { get { return name; } set { name = value; } }
    public decimal Money { get { return money; } set { money = value; } }

    //Конструктор
    public Person(string n, decimal m) { this.name = n; this.money = m; this.bag = new List<Product>(); }

    //Методи
    public void BuyProduct(Product product) //Метод для покупки продуктів
    {
        if ((money - product.Price) < 0) //Якщо готівку покупця відняти ціну продукта, і вона < 0
        {
            Console.WriteLine($"{name} can't afford {product.Name}");
        }
        else //Інакше
        {
            Console.WriteLine($"{name} bought {product.Name}");
            this.bag.Add(product);

            money -= product.Price;
        }
    }

    public void GetInfo()
    {
        if (bag.Count == 0)
        {
            Console.WriteLine($"{name} - Nothing bought");
        }
        else
        {
            int size = 0;

            Console.Write(Name + " - ");

            foreach (Product prod in bag)
            {
                Console.Write(prod.Name);

                if (size < bag.Count - 1)
                {
                    ++size;
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
        }
    }
}