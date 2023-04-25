namespace ConsoleApp5;

internal class car
{
    public string Colour;
    public int NumDoor;
    public string Brand;

    public car(string colour, int numdoor, string brand)
    {
        Colour = colour;
        NumDoor = numdoor;
        Brand = brand;
    }
    public void LockDoor()
    {
        Console.WriteLine("Doors are locked..");
    }
    public void EngineRun()
    {
        Console.WriteLine("Engine is run...");
    }


}
