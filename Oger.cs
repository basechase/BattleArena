using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    internal class Oger : Enemy
    {
        private string _name = "Shrek";

       

        private int _attackPower = 10;

        public int AttackPower { get { return _attackPower; } }

       

        public string Name { get { return _name; } }


        public Oger(string name, int health)
        {
            _name = name;
            
        }

       





    }
}
