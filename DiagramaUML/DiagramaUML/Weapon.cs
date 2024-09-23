namespace DiagramaUML;

//Clase Abstracta Weapon
public abstract class Weapon : Item
{
    public String name;
    public int damage;
    
    public void apply(Character character)
    {
        character.items.Add(this);

        // Verificar si el Weapon fue agregada
        if (character.items.Contains(this))
        {
            character.BaseDamage += damage;
            Console.WriteLine("Item added");
        }
        else
        {
            Console.WriteLine("Item not added");
        }
    }
}