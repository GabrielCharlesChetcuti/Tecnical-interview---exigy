using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        // will loop until '#' is input so that multiple decks of cards can be input if required
        while (true)
        {
            var deck = new List<string>(); // stores input by user
            for (int i = 0; i < 4; i++)
            {
                var line = Console.ReadLine();
                if (line == "#") return;
                deck.AddRange(line.Split(' ')); //splits input on ' ' signifying different cards
            }
            deck.Reverse();

            var piles = new List<Stack<string>>(); // new list of stacks = piles of cards
            for (int i = 0; i < 13; i++)
            {
                var pile = new Stack<string>();
                for (int j = 0; j < 4; j++)
                {
                    pile.Push(deck[i * 4 + j]);
                }
                piles.Add(pile);
            } // create a new stack for the pile, add the four cards for that pile to it, add the pile to the list of piles

            int count = 0;
            string lastCard = null;
            var currPile = piles[12];
            while (currPile.Any()) // loop continues as long as the current pile has cards in it
            {
                count++;
                lastCard = currPile.Pop();
                int nextPileIndex = GetValue(lastCard[0]) - 1;
                currPile = piles[nextPileIndex];
            } // increment the count of exposed cards, pop the top card from the current pile, make it the last card exposed, 
              // calculate the index of the next pile based on the value of the last card exposed, and then make that pile the new current pile

            Console.WriteLine($"{count:D2},{lastCard}"); // prints the number of cards exposed and the last card exposed
        }
    }

    private static int GetValue(char rank)
    {
        if (char.IsDigit(rank))
        {
            return int.Parse(rank.ToString());
        }
        else
        {
            switch (rank)
            {
                case 'A':
                    return 1;
                case 'T':
                    return 10;
                case 'J':
                    return 11;
                case 'Q':
                    return 12;
                case 'K':
                    return 13;
                default:
                    throw new Exception("Invalid rank");
            }
        }
    }
}
