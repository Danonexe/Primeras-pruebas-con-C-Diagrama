namespace DiagramaUML;
//Character
public class Character : Creature
{
        // Perk //
        public bool CritRate;
        public int HealingPower;

        // Lista de Items 
        public List<Item> Items;
        // Lista de Minion
        public List<Minion> Minions;
        
        // Constructor con parámetros
        public Character(string name, int maxHpPoints, int baseDamage, int baseArmor, bool critRate, int healingPower)
        {
            this.name = name;
            this.MaxHpPoints = maxHpPoints;
            this.HpPoints = maxHpPoints;
            this.BaseDamage = baseDamage;
            this.BaseArmor = baseArmor;
            this.CritRate = critRate;
            this.HealingPower = healingPower;
            this.Items = new List<Item>(); // Inicializa la lista de ítems
            this.Minions = new List<Minion>(); // Inicializa la lista de ítems
        }
        
        //Metodos Character
        //Atque con la perk del crítico//
       public int Attack()
       {
           var characterDamage=0;
           var minionDamage=0;
           Random random = new Random();
           if (this.CritRate) 
           {
               int numero = random.Next(0, 7);
               if (numero == 6)
               {
                   characterDamage= 2 * this.BaseDamage;
               }
               else{
                   characterDamage = BaseDamage;
               }
           }else{
               characterDamage=BaseDamage;
           }

           if (Minions.Count > 0)
           {
               foreach (Minion minion in Minions)
               {
                   minionDamage += minion.BaseDamage;
                   Console.WriteLine("Your minion "+minion.name+" helped you in the fight");
               }
           }
           return characterDamage+minionDamage;
       }

        public int Defense()
        {
            return this.BaseArmor;
        }

        public void RecieveDamage(int damage)
        {
            if (damage > this.BaseArmor)
            {
                this.HpPoints -= damage;
            }
        }
        //Curar
        public void Heal()
        {
            if (this.HpPoints <= this.MaxHpPoints)
            {
                this.HpPoints += this.HealingPower;
                if (this.HpPoints > this.MaxHpPoints)
                {
                    this.HpPoints = this.MaxHpPoints;
                }
            }
        }
        //Metodo añadido desequipar
        public void Unequip(Item item)
        {
            bool removed = Items.Remove(item);
            if (removed)
            {
                if (item is Weapon weapon)
                {
                    this.BaseDamage -= weapon.damage;
                    if (weapon.minion != null)
                    {
                        Minions.Remove(weapon.minion);
                    }
                }
                else if (item is Protection protection)
                {
                    this.BaseArmor -= protection.armor;
                }
                Console.WriteLine("item deleted");
            }
            else
            {
                Console.WriteLine("item not found");
            }
        }
          // for manual testing purposes
            public override string ToString()
            {
                string result = $"Character: {name} | HP: {HpPoints}/{MaxHpPoints}\n";
                result += "  Inventory:\n";
                foreach (var item in Items)
                {
                    result += $"    {item}\n";
                }
                result += $"  Attack: {Attack()}\n";
                result += $"  Defense: {Defense()}\n";
                foreach (Minion minion in Minions)
                {
                    result += $"  Minion: {minion.name} HP: {minion.HpPoints} Damage: {minion.BaseDamage} Armor: {minion.BaseArmor}\n";
                }
                return result;
            }
}