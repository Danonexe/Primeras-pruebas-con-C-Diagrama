namespace DiagramaUML;

//Clase Abstracta Protection
public abstract class Protection : Item
{
    public String name;
    public int armor;
   
    public void Apply(Character character)
    {
        character.Items.Add(this);

        // Verificar si el Armor fue agregada
        if (character.Items.Contains(this))
        {
            character.BaseArmor += armor;
            Console.WriteLine("Item added");
        }
        else
        {
            Console.WriteLine("Item not added");
        }
    }

    public override string ToString()
    {
        return  name+" armor +"+armor;
    }
}