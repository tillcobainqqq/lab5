class Chicken
{
    private string name; // Ім'я курки
    private int age; //Вік 
    private int EggsPerDay; //Скільки яєць може зносити курка за один день

    //Властивості
    public string Name { get; set; }
    public int Age { get; set; }
    public int EPD { get { return EggsPerDay; } set { EggsPerDay = value; } }

    //Конструктор
    public Chicken(string n, int a, int epd) { this.name = n; this.age = a; this.EggsPerDay = epd; }

    //Методи

    private string CalculateProductPerDay() { return "\nChicken " + name + "(age " + age + ") can produce " + EggsPerDay + " eggs per day."; } //Приватний метод
    public string GetInfo() { return CalculateProductPerDay(); } //Отримав інфу з приватного методу
}