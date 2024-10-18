using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    internal class Oger : Character
    {
        public Oger(string name, float maxHealth, float attackPower, float defensePower) : base(name, maxHealth, attackPower, defensePower)
        {





        }

        public override void Heal(float health)
        {
            health += Health;
        }









    }
}
