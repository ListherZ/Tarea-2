using DestructoresMagicos;

public class Warrior : Character
{
    public Warrior(string name, Armor armor, Weapon weapon)
        : base(name, 0, "Melee", 100, 1, armor, weapon)
    {
    }
    public int Strike { get; set; }
    public int Execute { get; set; }
    public int SkinHarden { get; set; }
    // mostrar detalles 
    public override void Display()
    {
        base.Display();
        Console.WriteLine("Class: Warrior");
    }
}