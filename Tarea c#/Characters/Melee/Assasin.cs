using DestructoresMagicos;

public class Assassin : Character
{
    public Assassin(string name, Armor armor, Weapon weapon)
        : base(name, 0, "Melee", 100, 1, armor, weapon)
    {
    }
    public int Raze { get; set; }
    public int BleedToDeath { get; set; }
    public int Survival { get; set; }
    // mostrar detalles 
    public override void Display()
    {
        base.Display();
        Console.WriteLine("Class: Assassin");
    }
}