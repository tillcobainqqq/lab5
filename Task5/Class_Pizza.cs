class Pizza //Клас для піци
{
    //Приватні поля
    private string name; //Назва піци
    private Dough dough; //Тісто для піци
    private List<Topping> toppings; //Список начинок

    //Властивості
    public string Name //Властивість для назви піци
    {
        get { return name; }
        private set
        {
            if (value.Length < 1 || value.Length > 15)
            {
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");

            }
            this.name = value;
        }
    }

    //Конструктор
    public Pizza(string name, Dough dough) { this.Name = name; this.dough = dough; toppings = new List<Topping>(); }

    //Методи
    public void AddTopping(Topping topping) //Метод, який буде додавати нам начинки у список
    {
        if (this.toppings.Count == 10) //Вийняток, якщо кількість начинок == 10
        {
            throw new InvalidOperationException("Number of toppings should be in range [0..10].");
        }

        this.toppings.Add(topping);
    }

    public double GetCalories() //Публічний метод, призначений для отримання загальної кількості калорій
    {
        double sum_ = 0;

        foreach (Topping t in toppings) { sum_ += t.GetCalories(); }
        sum_ += dough.GetCalories();

        return sum_;
    }
}