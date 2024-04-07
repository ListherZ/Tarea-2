using DestructoresMagicos;

public class Druid : Character
{
    public Druid(string name, Armor armor, Weapon weapon)
        : base(name, 0, "Spellcaster", 100, 1, armor, weapon)
    {
    }
    public int Moonfire { get; set; }
    public int Starburst { get; set; }
    public int OneWithTheNature { get; set; }
    // mostrar detalles 
    public override void Display()
    {
        base.Display();
        Console.WriteLine("Class: Druid");
    }
}