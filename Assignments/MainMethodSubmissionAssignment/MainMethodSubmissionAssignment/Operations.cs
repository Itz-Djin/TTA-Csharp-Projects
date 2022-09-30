using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmissionAssignment
{
    public class Operations
    {
        //Method Additon for int values
        public int Addition(int x)
        {
            return 10 + x;
        }

        //Method Addition for decimal values, returns result as int 
        public int Addition(decimal x)
        {
            //return 1.5m * x;
            return Convert.ToInt32(1.5m * x);
        }

        //Method Addition for string values, returns result as int
        public int Addition(string x)
        {
            int y = Convert.ToInt32(x);
            //return 2 * Convert.ToInt32(x);
            return 2 * y;
        }
    }
}
