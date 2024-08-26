using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Player
    {
        public List<Card> Hand {  get; set; }
        public int Balanance { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public static Game operator+ (Game game, Player player) 
        {
            game.Players.Add (player); 
            return game;
        }
        public static Game operator- (Game game, Player player)
        {  game.Players.Remove (player);
            return game;
        }
            

    }
}
