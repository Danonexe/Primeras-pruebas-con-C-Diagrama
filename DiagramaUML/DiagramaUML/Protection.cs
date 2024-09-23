namespace DiagramaUML;

//Clase Abstracta Protection
public abstract class Protection : Item
{
    public String name;
    public int armor;
    
    public void apply(Character character)
    {
        character.items.Add(this);

        // Verificar si el Armor fue agregada
        if (character.items.Contains(this))
        {
            character.BaseArmor += armor;
            Console.WriteLine("Item added");
        }
        else
        {
            Console.WriteLine("Item not added");
        }
    }
}