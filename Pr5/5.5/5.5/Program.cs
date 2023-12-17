using System;
interface spell
{
    void castSpell(Spell spell);
}

class Spell
{
    public string Effect { get; private set; }
    public int Mana { get; private set; }
    public Spell(int mana, string effect)
    {
        Mana = mana;
        Effect = effect;
    }
    public string Use()
    {
        return Effect;
    }
}

class Magican : spell
{
    public int Mana { get; private set; }
    public string Name { get; private set; }
    public Magican(int mana, string name)
    {
        Mana = mana;
        Name = name;
    }
    public void castSpell(Spell spell)
    {
        if (Mana >= spell.Mana)
        {
            Console.WriteLine($"{Name} использует способность: '{spell.Use()}'");
            Mana -= spell.Mana;
            Console.WriteLine($"У {Name} осталось {Mana} маны\n");
        }
        else
        {
            Console.WriteLine($"Не хватает {spell.Mana - Mana} для использования заклинания: '{spell.Use()}'");
            Console.WriteLine($"{Name} советую выпить зелье восстановления маны!");
        }
    }
}

class indexClasses
{
    static void Main()
    {
        Spell alohomora = new Spell(100, "Замок открывается");
        Spell vinigardiumLeviosa = new Spell(50, "Предмет поднимается в воздух");

        Magican GarryPotter = new Magican(100, "Гарри Поттер");


        GarryPotter.castSpell(alohomora);
        GarryPotter.castSpell(vinigardiumLeviosa);
    }
}