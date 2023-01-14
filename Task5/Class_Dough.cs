class Dough //Клас для тіста
{
    //Приватні поля
    private string flourType; //Тип борошна
    private string bakingTechnique; //Тип випічки
    private int weight; //Вага тіста

    //Властивості
    public string FlourType //Властивість для типу борошна
    {
        get { return flourType; }
        set
        {
            if (value != "White" && value != "Wholegrain")
            {
                throw new ArgumentException("Invalid type of dough.");
            }

            flourType = value;
        }
    }
    public string BakingTechnique //Властивість для техніки випічки
    {
        get { return bakingTechnique; }
        set
        {
            if (value != "crispy" && value != "chewy" && value != "homemade")
            {
                throw new ArgumentException("Invalid type of dough.");
            }

            bakingTechnique = value;
        }
    }
    public int Weight //Властивість для ваги тіста
    {
        get { return weight; }
        set
        {
            if (value > 200 || value < 1)
            {
                throw new ArgumentException("\"Dough weight should be in the range [1..200].");
            }

            weight = value;
        }
    }

    //Конструктори
    public Dough(string flourType, string bakingTechnique, int weight)
    { this.flourType = flourType; this.bakingTechnique = bakingTechnique; this.weight = weight; }

    //Методи
    private double GetFlourType() //Приватний метод, який дозволяє нам отримати тип борошна
    {
        if (flourType == "White") { return 1.5; } //Якщо тип борошна білий

        return 1.0; //Якщо тип борошна - цільозерновий
    }

    private double GetBaking() //Приватний метод, який дозволяє нам отримати тип випічки
    {
        if (bakingTechnique == "Crispy") { return 0.9; } //Якщо випічка - хрустка
        if (bakingTechnique == "Chewy") { return 1.1; } //Якщо випічка - жувальна

        return 1.0; //Якщо випічка домашня
    }

    public double GetCalories() { return (2 * weight * GetBaking() * GetFlourType()); } //Публічний метод для отримання калорій з тіста

    //Деструктор
    ~Dough() { }
}