﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BattleArena
{
    internal class Game
    {

        //enum to have player swap through rooms/stages of BattleArena
        private enum Room
        {
            Start,
            Room1,
            Room2,
            Room3,
        }
        private bool _gameOver = false;

        StephCurry steph;
        Player player;
        Oger shrek;
        Skeleton bones;

        
        public int GetInput(string desc, string option1, string option2)
        {
            string input = "";
            int inputRecieved = 0;

            while (inputRecieved != 1 && inputRecieved != 2)
            {
                // Print Options
                
                Console.WriteLine(desc);
                Console.WriteLine("1. " + option1);
                Console.WriteLine("2. " + option2);
                Console.WriteLine("> ");

                // Get input from palyer
                input = Console.ReadLine();
                // if first option
                if (input == "1")
                {
                    // set input rcvd to one
                    inputRecieved = 1;
                }
                else if (input == "2")
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

        //override function for 3 inputs instead of two 


       




        public void Start()
        {
            // buff chuck norris, hes old, didnt realize thats what the bug was in the first
            //wtf is broken?
            player = new Player("Chuck Norris", 9, 10, 1);
            steph = new StephCurry("Steph Curry", 10, 9, 5);
            shrek = new Oger("Shrek", 5, 15, 5);
            bones = new Skeleton("Bones", 1, 1, 1);



        }

        public void Update()
        {
            //set gameOver conditions
            if (player.Health <= 0 || bones.Health + shrek.Health + steph.Health <=0) 
            {
                _gameOver = true;
            }

            // print player stats 
            bones.PrintStats();
            player.PrintStats();
            shrek.PrintStats();
            steph.PrintStats();




            // est empty int variable for get input
            int input;
            Room room = Room.Start;

            input = GetInput("You must pick a room to fight out of"," Room 1","Room 2");

          if (input == 1)
            {
                room = Room.Room1;
            }
          else if (input == 2)
            {
                room = Room.Room2;
            }

            switch (room)
            {
                case Room.Room1:
                    Console.WriteLine($"{player.Name} walks in and gets jumped by {steph.Name}");
                    steph.Attack(player);
                    break;
                case Room.Room2:
                    Console.WriteLine($"{bones.Name} is coming, you attack");
                    player.Attack(bones);
                    Console.WriteLine("Time for the next room");
                    room = Room.Room1;
                    break;
            }






















            /*

            Console.WriteLine("Press a key to start a battle");
            Console.ReadKey();
            

           input = GetInput($"You are {player.Name} Who would you like to fight first?", shrek.Name, bones.Name);


           if (input == 1)
            {
             player.Attack(shrek);
             Console.WriteLine($"{bones.Name} is coming, {player.Name} attacks");
             player.Attack(bones);
            }
           else if (input == 2)
            {
            Console.WriteLine($"Shrek is coming, {player.Name} attacks" );
            player.Attack(shrek);
            player.Attack(bones);
            }


            shrek.PrintStats();
            bones.PrintStats();
            Console.ReadKey();

           

            Console.WriteLine($"{steph.Name} is a real baller, he pounces on {player.Name}");
            steph.Attack(player);
            

            // player.Attack(player); <<< this is funny 
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
