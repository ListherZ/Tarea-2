using DestructoresMagicos;
using System;
using System.Runtime.InteropServices;
using Tarea_c_;
using static DestructoresMagicos.Character;


class Principal
{    
    static void Main(string[] args)
    {
        try
        {
            
            Console.WriteLine("\n Melee  \n");
            //  crear instancias de personajes, armaduras y armas, y probar su funcionalidad xd
            Warrior warrior = new Warrior("Warrior", new Chainlink(), new Axe());
            warrior.Display();
            
            // Dejar un espacio 
            Console.WriteLine();
            // 
            Knight knight = new Knight("Knight", new Chainlink(), new Hammer());
            knight.Display();
            // Dejar un espacio 
            Console.WriteLine();
            // 
            Assassin assassin = new Assassin("Assassin", new Chainlink(), new Hammer());
            assassin.Display();
            // Dejar un espacio 
      
            Console.WriteLine("\n Spellcasters \n");

            // 
            Mage mage = new Mage("Mage", new ClothRobe(), new Staff());
            mage.Display();
            Console.WriteLine();
            Necromancer necromancer = new Necromancer("Necromancer", new LightLeatherVest(), new Sword());
            necromancer.Display();

            Console.WriteLine();
            Druid druid = new Druid("Druid", new LightLeatherVest(), new Staff());
            druid.Display();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
