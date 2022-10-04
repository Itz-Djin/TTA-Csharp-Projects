using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game
    {
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        //any class inheriting this class must implement this method
        public abstract void Play();

        //a virtual method inside an abstract class means,
        //this method gets inherited by an inheriting class but,
        //has the ability to override it
        //virtual methods opposed to abstract have an implementation, but can be overriden 
        public virtual void ListPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
