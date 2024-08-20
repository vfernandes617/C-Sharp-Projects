using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This is the 'CALLING METHODS SUBMISSION ASSIGNMENT'
            Console.WriteLine("Enter a number to perform math");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int number))



            Deck deck = new Deck();
            deck = Shuffle(deck);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();

            Console.WriteLine(deck.Cards[0].Face + " of " + deck.Cards[0].Suit);
            Console.ReadLine();
        }

        public static Deck Shuffle(Deck deck)
        {
            List<Card> TempList = new List<Card>();
            Random random = new Random();

            while (deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count);
                TempList.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex);

            }
            deck.Cards = TempList;
            return deck;
           
        }

       


    }

 }
