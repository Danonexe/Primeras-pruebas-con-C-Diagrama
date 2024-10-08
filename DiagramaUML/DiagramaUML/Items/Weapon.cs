namespace DiagramaUML;

//Clase Abstracta Weapon
public abstract class Weapon : Item
{
    public String name;
    public int damage;
    public Minion minion;
    public void Apply(Character character)
    {
        character.Items.Add(this);

        // Verificar si el Weapon fue agregada
        if (character.Items.Contains(this))
        {
            character.BaseDamage += damage;
            Console.WriteLine("Item added");
            if (minion != null)
            {
                character.Minions.Add(minion);
            }
        }
        else
        {
            Console.WriteLine("Item not added");
        }
    }

    public override string ToString()
    {
        if (minion != null)
        {
            return name + " damage +" + damage +" Minion: "+ minion.name;
        }
        else
        {
            return name + " damage +" + damage;
        }
    }
}