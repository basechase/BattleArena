using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    internal class Skeleton : Character
    {
        public Skeleton(string name, float maxHealth, float attackPower, float defensePower) : base(name, maxHealth, attackPower, defensePower)
        {





        }

        public override void Heal(float health)
        {
          health += Health;
        }


    }
}
