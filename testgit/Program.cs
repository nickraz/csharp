using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace testgit
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior war = new Warrior("Katarina");
            war.MaxHealth = 650;
            war.MaxAttackSpeed = 1.6;
            war.MaxArmor = 35;
            war.MaxAP = 0;
        }
    }
}
