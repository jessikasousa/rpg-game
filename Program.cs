using System;
using rpg_game.src.Entities;

namespace dotnet__poo 
{
   class Program
   {
       static void Main(string[] args) 
       {
           Hero hero = new Hero("Arus", 23, "Knight");
           Wizard wizard = new Wizard("Jenica", 24, "White Wizard");

           Console.WriteLine(wizard.Attack());
       }
   } 
}