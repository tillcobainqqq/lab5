class Topping //Клас для начинки
{
    //Приватні поля
    private string topping_type; //Вид начинки
    private int weight; //Вага в грамах

    //Властивості
    public string ToppingType //Властивість для типу начинки
    {
        get { return topping_type; }
        set
        {
            if (value != "Meat" && value != "Veggies" && value != "Cheese" && value != "Sauce")
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }

            topping_type = value;
        }
    }
    public int Weight
    {
        get { return weight; }
        set
        {
            if (value > 50 || value < 1)
            {
                throw new ArgumentException($"{value} should be in the range [1..50].");

            }
            weight = value;
        }
    } //Властивість для ваги начинки(в грамах)

    //Конструктор
    public Topping(string name, int w) { this.topping_type = name; this.weight = w; }

    //Методи
    private double GetToppingCalories() //Приватний метод, який шукає тип начинки і при його знайденні повертає його калорії
    {
        if (topping_type == "Meat") { return 1.2; } //Якщо тип начинки  - м'ясо
        if (topping_type == "Veggies") { return 0.8; } //Якщо тип начинки - овочевий
        if (topping_type == "Cheese") { return 1.1; } //Якщо тип начинки - сирний

        return 0.9; //Якщо тип начинки - соус
    }

    public double GetCalories()
    { return (weight * 2 * GetToppingCalories()); } //Пулічний метод, який виводить нам кількість калорій з начинок 

    //Деструктор
    ~Topping() { }
}