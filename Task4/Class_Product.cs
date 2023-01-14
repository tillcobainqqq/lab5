class Product
{
    //Приватні поля
    private string name; //Назва продукту
    private decimal price; //Ціна продукту

    //Властивості
    public string Name { get { return name; } set { name = value; } }
    public decimal Price { get { return price; } set { price = value; } }

    //Конструктор
    public Product(string n, decimal p) { this.name = n; this.price = p; }
}