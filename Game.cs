using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    internal class Game
    {
        private bool _gameOver = false;

        
        StephCurry steph;
        public virtual int GetInput(string desc, string option1, string option2)
        {
            ConsoleKeyInfo key;
            int inputRecieved = 0;

            while (inputRecieved != 1 || inputRecieved != 2)
            {
                // Print Options'
                Console.Clear();
                Console.WriteLine(desc);
                Console.WriteLine("1. " + option1);
                Console.WriteLine("2. " + option2);
                Console.WriteLine("> ");

                // Get input from palyer
                key = Console.ReadKey();
                // if first option
                if (key.KeyChar == '1')
                {
                    // set input rcvd to one
                    inputRecieved = 1;
                }
                else if (key.KeyChar == '2')
                {
                    // otherwise if seocnd option
                    // set input rcvd to two
                    inputRecieved = 2;
                }

                else
                {
                    // else neither 
                    // display error msg

                    Console.WriteLine("\nERROR ERROR INVALID INPUT");
                    Console.ReadKey();
                }

            }
            Console.WriteLine();
            return inputRecieved;
        }

        public void Start()
        {
            
            steph = new StephCurry("Steph Curry", 10, 9, 5);
           
            



        }

        public void Update()
        {




            if (steph.Health == 0) 
            {
                _gameOver = true;
            }


            steph.PrintStats();

            /*

            if (player.Health == 0 || enemy.Health == 0)
            {
                _gameOver = true;
            }

            while (player.Health > 0 && enemy.Health > 0)
            {
                player.PrintStats();
                Console.WriteLine();
                enemy.PrintStats();

                float damage = player.Attack(enemy);

                Console.WriteLine();
                Console.WriteLine(player.Name + " did " + damage + " damage to " + enemy.Name + " ! ");

                player.PrintStats();
                Console.WriteLine();
                enemy.PrintStats();

                
                damage = steph.Attack(player);


                Console.WriteLine(steph.Name + " did " + damage + " damage to " + player.Name );

                int input = GetInput("You are being attacked by" + steph.Name, "1: Dodge basketball", "2: Attack");

                if (input == 1)
                {

                }
                else if (input == 2)
                {

                }
            */
            
            
        }

        public void End()
        {
            Console.WriteLine("End/Gameover");
        }

        

        public void Run()
        {
            Start();
            while (!_gameOver)
            {
                Update();

                

            }
            End();
        }
    }
}
