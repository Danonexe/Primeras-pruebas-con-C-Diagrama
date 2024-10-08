namespace DiagramaUML;

//Clase Sword
public class Sword : Weapon
{
    // Constructor 
    public Sword(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }
    public Sword(string name, int damage,string minionName, int minionHP, int minionDamage, int minionArmor )
    {
        this.name = name;
        this.damage = damage;
        this.minion = new Minion();
        minion.name = minionName;
        minion.MaxHpPoints = minionHP;
        minion.HpPoints = minionHP;
        minion.BaseDamage = minionDamage;
        minion.BaseArmor = minionArmor;
    }
}
