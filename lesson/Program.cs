class Program
{
    static void Main()
    {
        Car car = new Car();

        car.Brand = "BMW";
        car.Model = "M5";
        car.Age = 5;
        car.Engine = 4.4;
        car.Color = "Black";

        Console.WriteLine("Year: " + car.GetYear());

        car.ShowInfo();

        Console.ReadKey();
    }
}