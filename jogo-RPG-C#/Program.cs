﻿using System;
using jogo_RPG_C#.src.Entities;

namespace jogo_RPG_C#
{

    class Program
    {
        static void Main (string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
                
            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(7));
            
        }

    }
}