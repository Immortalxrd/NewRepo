using System;

class Spell
{
    private int _mana;
    private string _effect;

    public Spell(int mana, string effect)
    {
        _mana = mana;
        _effect = effect;
    }

    public string Use()
    {
        return _effect;
    }
}

class Magician
{
    private int _mana;
    private string _name;

    public Magician(int mana, string name)
    {
        _mana = mana;
        _name = name;
    }

    public void CastSpell(Spell spell)
    {
        if (_mana >= spell.GetMana())
        {
            Console.WriteLine($"{_name} использует способность: '{spell.Use()}'");
            _mana -= spell.GetMana();
            Console.WriteLine($"У {_name} осталось {_mana} маны\n");
        }
        else
        {
            Console.WriteLine($"Не хватает {spell.GetMana() - _mana} для использования заклинания: '{spell.Use()}'");
            Console.WriteLine($"{_name} советую выпить зелье восстановления маны!");
        }
    }
}

class Program
{
    static void Main()
    {
        Spell alohomora = new Spell(100, "Замок открывается");
        Spell vinigardiumLeviosa = new Spell(50, "Предмет поднимается в воздух");

        Magician harryPotter = new Magician(100, "Гарри Поттер");

        harryPotter.CastSpell(alohomora);
        harryPotter.CastSpell(vinigardiumLeviosa);
    }
}
