using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    internal class StephCurry : Enemy
    {
        private string _name = "StephCurry";

       

        private int _attackPower = 10;
       

      
        public int AttackPower { get { return _attackPower; } }

        public string Name { get { return _name; } }
        

        public StephCurry(string name) 
        {
            _name = name;
            
        }


        public void Ball()
        {
            

            Console.WriteLine("You just got balled on!");
            
        }
    }
}
