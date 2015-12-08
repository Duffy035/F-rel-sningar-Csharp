using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning7_Properties
{
    class Game
    {
        private int lives;   //Vi har backingfield - skrivs med lowercase
        private string name;


        public int Lives    //Vi har property - skrivs med PascalCase. Inga parenteser!
        {
            get  //motsvarar 'getter'
            {
                return lives;
            }
            set  //motsvarar 'setter'. Vi kan ett sätta åtkomstdirektiv (private etc) om vi vill.
            {
                if (value >= 0)  //vi kan sätta villkor
                    lives = value; //value är istället för inparameter
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != null)
                    name = value;
            }
        }
    }
}
