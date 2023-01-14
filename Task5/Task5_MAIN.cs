using System;

class Program
{
    static void Main(string[] args)
    {
        string[] p = Console.ReadLine().Split(); //Ввожу назву піци
        string[] doughData = Console.ReadLine().Split(); //Ввожу дані для тіста

        try
        {
            Dough dough = new Dough(doughData[1], doughData[2], int.Parse(doughData[3])); //Записав дані тіста
            Pizza pizza = new Pizza(p[1], dough); //Записав дані піци

            while (true)
            {
                string str = Console.ReadLine();

                if (str == "END") { break; }

                string[] partsTopping = Console.ReadLine().Split(); //Пишу якусь начинку

                Topping topping = new Topping(partsTopping[1], int.Parse(partsTopping[2])); //Записую дані про начинку у клас

                pizza.AddTopping(topping); //Пробую додати начинку до піци
            }

            Console.WriteLine($"{pizza.Name} - {pizza.GetCalories()} Calories."); //Вивожу бажаний результат
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}