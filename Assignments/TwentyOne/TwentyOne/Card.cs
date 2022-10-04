using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    //public makes it accessible to other parts of the program class
    public class Card
    {   
        //property of data type string called Suit, that you can get or set this property
        public Suit suit{ get; set; }
        public string Face { get; set; }
    }
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
}
