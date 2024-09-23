namespace DiagramaUML;
//Character
public class Character
{
        public String name;
        public int MaxHpPoints;
        public int HpPoints;
        public int BaseDamage;
        public int BaseArmor;
        // Perk //
        public bool critRate;
        public int HealingPower;

        // Lista de Items tenia que hacerla pública
        public List<Item> items;
        
        // Constructor con parámetros
        public Character(string name, int maxHpPoints, int baseDamage, int baseArmor, bool critRate, int healingPower)
        {
            this.name = name;
            this.MaxHpPoints = maxHpPoints;
            this.HpPoints = maxHpPoints;
            this.BaseDamage = baseDamage;
            this.BaseArmor = baseArmor;
            this.critRate = critRate;
            this.HealingPower = healingPower;
            this.items = new List<Item>(); // Inicializa la lista de ítems
        }
        
        //Metodos Character
        //Atque con la perk del crítico//
       public int Attack()
       {
           Random random = new Random();
           if (this.critRate) 
           {
               int numero = random.Next(0, 7);
               if (numero == 6)
               {
                   return 2 * this.BaseDamage;
               }
           }
           
           return this.BaseDamage;
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
            bool removed = items.Remove(item);
            if (removed == true)
            {
                if (item is Weapon weapon)
                {
                    this.BaseDamage -= weapon.damage;
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
}