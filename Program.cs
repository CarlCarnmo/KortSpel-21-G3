using System;
using System.Collections.Generic;
using System.Linq;
using static KortSpel_21_G3.Program;
using static KortSpel_21_G3._Deck;


namespace KortSpel_21_G3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Reset();
            Console.WriteLine(deck.Cards.Count);

        }
    }
}