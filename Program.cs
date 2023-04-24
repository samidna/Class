using ConsoleApp4;
Student stu1 = new("Samid","Aghayev","P137",85);
Console.WriteLine(stu1.FullName());
Console.WriteLine(stu1.Info());

if (stu1.IsGraduated() ==true)
{
    Console.WriteLine("Ikinci imtahana haqq qazandiniz.");
}
  else
{
    Console.WriteLine("Ikinci imtahana haqq qazanmadiniz.");
}
Console.WriteLine(stu1.IsGraduated());
