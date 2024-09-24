using System;

namespace DiagramaUML
{
    class MainClass
    {
        //Main
        public static void Main(string[] args)
        {
          //Prueba Manual
           Console.WriteLine("Prueba Manual");
           var character = new Character("Gerald",100,25,30,true,25);
           var axe = new Axe("Hacha de guerra",20);
           var sword = new Sword("Excalibur",30);
           var helmet = new Helmet("Casco de combate", 20);
           var shield = new Shield("Escudo de broce",10);
           axe.apply(character);
           sword.apply(character);
           helmet.apply(character);
           shield.apply(character);
           
           Console.WriteLine("Manual tests: ");
           
           Console.WriteLine(character);
           
           character.Unequip(sword);
           character.Unequip(shield);
           Console.WriteLine(character);
           
           character.RecieveDamage(10);
           Console.WriteLine(character);
           
           character.Heal();
           Console.WriteLine(character);
        }
    }
    
}
