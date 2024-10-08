namespace DiagramaUML;

public class Minion: Creature
{
    public void Apply(Character character)
    {
        character.Minions.Add(this);

        // Verificar si el Weapon fue agregada
        if (character.Minions.Contains(this))
        {
            Console.WriteLine("Minion added");
        }
        else
        {
            Console.WriteLine("Minion not added");
        }
    }
    public void Free(Character character)
    {
        // Verificar si el Weapon fue agregada
        if (character.Minions.Contains(this))
        {
            character.Minions.Remove(this);
            Console.WriteLine("Minion set free");
        }
        else
        {
            Console.WriteLine("This minion is not yours");
        }
    }
}