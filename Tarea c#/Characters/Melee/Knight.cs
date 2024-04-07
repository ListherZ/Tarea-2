using DestructoresMagicos;

public class Knight : Character
{
    public Knight(string name, Armor armor, Weapon weapon)
        : base(name, 86, "Melee", 100, 1, armor, weapon)
    {
    }
    public int HolyBlow { get; set; }
    public int PurifySoul { get; set; }
    public int RighteousWings { get; set; }
    //  mostrar detalles
    public override void Display()
    {
        base.Display();
        Console.WriteLine("Class: Knight");
    }
}