namespace ConsoleApp4;

internal class Student
{
    public string Name;
    public string Surname;
    public double Point;
    public string Group;
    public Student(string name, string surname, string group, double point)
    {
        Name = name;
        Surname = surname;
        Point = point;
        Group = group;
    }
    public string FullName()
    {
        return $"Name:{Name} Surname:{Surname}";
    }
    public string Info()
    {
        return $"{FullName()} Group:{Group} Point:{Point}";
    }
    public bool IsGraduated()
    {
        if(Point>=80)
        {
            return true ;
        }
            return false;
    }        
}







