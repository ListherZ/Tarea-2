using System;

namespace DestructoresMagicos
{
    public class Character
    {
        private string name;
        private int abilityPoints;
        private string faction;
        private int healthPoints;
        private int level;
        private Armor BodyArmor;
        private Weapon Weapon;
        public string Nombre
        {
            get => name;
            set => ValidarNombre(value);
        }

        public int PuntosHabilidad
        {
            get => abilityPoints;
            set => ValidarPuntosHabilidad(value);
        }

        public string Facción
        {
            get => faction;
            set => ValidarFacción(value);
        }

        public int PuntosSalud
        {
            get => healthPoints;
            set => ValidarPuntosSalud(value);
        }

        public int Nivel
        {
            get => level;
            set => ValidarNivel(value);
        }

        // Constructor
    public Character(string name, int abilityPoints, string faction, int healthPoints, int level, Armor armor, Weapon weapon)
{

            this.name = name;
            this.faction = faction;
            Nombre = name;
            PuntosHabilidad = abilityPoints;
            Facción = faction;
            PuntosSalud = healthPoints;
            Nivel = level;
            BodyArmor = armor;
            Weapon = weapon;
        }

        // Método para mostrar los detalles del personaje
        public virtual void Display()
        {
            Console.WriteLine($"Name: {Nombre}");
            Console.WriteLine($"Ability Points: {PuntosHabilidad}");
            Console.WriteLine($"Faction: {Facción}");
            Console.WriteLine($"Health Points: {PuntosSalud}");
            Console.WriteLine($"Level: {Nivel}");
        }

        // Métodos de validación
        public void ValidarNombre(string value)
        {
            if (value.Length < 3 || value.Length > 12)
            {
                throw new ArgumentOutOfRangeException(nameof(Nombre), $"La longitud del nombre debe estar entre 3 y 12 caracteres. El valor incorrecto es:  {value}");
            }
            else
            {
                name = value;
            }
        }

        public void ValidarPuntosHabilidad(int value)
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(PuntosHabilidad), $"Los puntos de habilidad deben estar entre 0 y 100.  El valor incorrecto es:  {value}");
            }
            else
            {
                abilityPoints = value;
            }
        }

        public void ValidarFacción(string value)
        {
            if (value != "Melee" && value != "Spellcaster")
            {
                throw new ArgumentOutOfRangeException(nameof(Facción), $"La facción debe ser 'Melee' o 'Spellcaster'. El valor incorrecto es:  {value}");
            }
            else
            {
                faction = value;
            }
        }

        public void ValidarPuntosSalud(int value)
        {
            if (value < 0 || value > 120)
            {
                throw new ArgumentOutOfRangeException(nameof(PuntosSalud), $"Los puntos de salud deben estar entre 0 y 120. El valor incorrecto es:  {value}");
            }
            else
            {
                healthPoints = value;
            }
        }

        public void ValidarNivel(int value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Nivel), $"El nivel debe ser un valor positivo. El valor incorrecto es:  {value}");
            }
            else
            {
                level = value;
            }
        }
    }
    // Clase base para armaduras
    public class Armor
    {
        public int ArmorPoints { get; set; }

        // Constructor
        public Armor(int armorPoints)
        {
            ArmorPoints = armorPoints;
        }
    }

    // Clase base para armas
    public class Weapon
    {
        public int Damage { get; set; }

        // Constructor
        public Weapon(int damage)
        {
            Damage = damage;
        }
    }
}





