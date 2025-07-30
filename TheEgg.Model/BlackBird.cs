using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheEgg.Model
{
    /* 
     * 2)
     Now, the Hatch method can create birds, without having the knowledge about how
     or which type of bird to create, through the intermediate of the _createBird delegate.

     How would you create an egg? Well, first you need some bird implementation e.g.:
     */
    public class BlackBird : IBird
    {
        public Egg Lay()
        {
            /*
             * 4)
             * You can then create an egg with
             */
            var egg = new Egg(CreateBlackBird); // No "()". CreateBlackBird is not called but referenced.
            IBird newBird = egg.Hatch();
            return egg;
        }

        /*
         * 3)
         * Then you need a method creating and returning a IBird. E.g.:
         */

        IBird CreateBlackBird()
        {
            return new BlackBird();
        }
    }
}
