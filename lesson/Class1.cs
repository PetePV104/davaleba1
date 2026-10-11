using System;
using System.Collections.Generic;

class StudentManager
{
    public List<string> Students = new List<string>();
    public Dictionary<string, int> Grades = new Dictionary<string, int>();

    public void AddStudent(string name, int grade)
    {
        if (Grades.ContainsKey(name))
        {
            Console.WriteLine("Studenti ukve arsebobs!");
            return;
        }

        Students.Add(name);
        Grades.Add(name, grade);
    }

    public void FindStudent(string name)
    {
        if (Grades.ContainsKey(name))
            Console.WriteLine("Qula: " + Grades[name]);
        else
            Console.WriteLine("Studenti ver moidzebna");
    }

    public void UpdateGrade(string name, int grade)
    {
        if (Grades.ContainsKey(name))
            Grades[name] = grade;
        else
            Console.WriteLine("Studenti ver moidzebna");
    }

    public void ShowAll()
    {
        foreach (string name in Students)
        {
            Console.WriteLine(name + " - " + Grades[name]);
        }
    }
}