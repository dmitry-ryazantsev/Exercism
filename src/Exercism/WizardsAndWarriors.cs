namespace WizardsAndWarriors;

public abstract class Character
{
    protected string characterType;

    protected Character(string characterType)
    {
        this.characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable() => false;

    public override string ToString() => $"Character is a {characterType}";
}

public class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        if (target.Vulnerable())
            return 10;

        return 6;
    }
}

public class Wizard : Character
{
    private bool preparedSpell = false;

    public Wizard() : base("Wizard")
    {
    }

    public override int DamagePoints(Character target)
    {
        if (preparedSpell)
            return 12;

        return 3;
    }

    public void PrepareSpell()
    {
        preparedSpell = true;
    }

    public override bool Vulnerable() => !preparedSpell;
}