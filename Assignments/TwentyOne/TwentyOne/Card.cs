using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    //public makes it accessible to other parts of the program class
    public class Card
    {   //properties

        public Card()
        {
            Suit = "Spades";
            Face = "Two";
        }
        //property of data type string called Suit, that you can get or set this property
        public string Suit { get; set; }
        public string Face { get; set; }
    }
}
