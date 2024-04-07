using DestructoresMagicos;

public class Necromancer : Character
{
    public Necromancer(string name, Armor armor, Weapon weapon)
        : base(name, 0, "Spellcaster", 100, 1, armor, weapon)
    {
    }
    public int ShadowRage { get; set; }
    public int VampireTouch { get; set; }
    public int BoneShield { get; set; }
    // mostrar detalles 
    public override void Display()
    {
        base.Display();
        Console.WriteLine("Class: Necromancer");
    }
}