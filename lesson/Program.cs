class Program
{
    static void Main()
    {
        StudentManager manager = new StudentManager();

        manager.AddStudent("Giorgi", 90);
        manager.AddStudent("Nika", 85);

        manager.FindStudent("Giorgi");

        manager.UpdateGrade("Nika", 95);

        manager.ShowAll();

        Console.ReadKey();
    }
}