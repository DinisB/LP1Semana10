﻿using System;
using System.Collections.Generic;

namespace EqualPlayer
{
    class Program
    {
        static void Main()
        {
            var setOfPlayers = new HashSet<Player>();

            setOfPlayers.Add(new Player(PlayerClass.Tank, "Ana"));
            setOfPlayers.Add(new Player(PlayerClass.Slayer, "Paulo"));
            setOfPlayers.Add(new Player(PlayerClass.Tank, "Ana"));

            foreach (Player p in setOfPlayers)
            {
                Console.WriteLine($"{p.Name} is a {p.PClass}");
            }
        }
    }
}
