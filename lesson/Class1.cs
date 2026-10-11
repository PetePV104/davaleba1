class Car
{
    public string Brand;
    public string Model;
    public int Age;
    public double Engine;
    public string Color;

    public int GetYear()
    {
        return 2026 - Age;
    }

    public void ShowInfo()
    {
        Console.WriteLine("Brand: " + Brand);
        Console.WriteLine("Model: " + Model);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Engine: " + Engine);
        Console.WriteLine("Color: " + Color);
    }
}