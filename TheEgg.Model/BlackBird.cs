using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheEgg.Model
{
    public class BlackBird : IBird
    {
        public Egg Lay()
        {
            var egg = new Egg(CreateBlackBird); // No "()". CreateBlackBird is not called but referenced.
            IBird newBird = egg.Hatch();
            return egg;
        }

        IBird CreateBlackBird()
        {
            return new BlackBird();
        }
    }
}
