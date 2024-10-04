using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BattleArena
{
    internal class StephCurry : Character
    {
        
        public StephCurry(string name, float maxHealth, float attackPower, float defensePower) : base(name, maxHealth, attackPower, defensePower)
        {
            
          

       
            
        }


        public override void TakeDamage(float damage)
        {
            
            Console.WriteLine("\n Steph is a real baller, you cannot defeat him" + damage + " does nothing");
            
        }


    }
}
