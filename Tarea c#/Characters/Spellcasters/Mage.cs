using DestructoresMagicos;

public class Mage : Character
{
    public Mage(string name, Armor armor, Weapon weapon)
        : base(name, 0, "Spellcaster", 100, 1, armor, weapon)
    {
    }
    public int ArcaneWrath { get; set; }
    public int Firewall { get; set; }
    public int Meditation { get; set; }
    // mostrar detalles 
    public override void Display()
    {
        base.Display();
        Console.WriteLine("Class: Mage");
    }
}