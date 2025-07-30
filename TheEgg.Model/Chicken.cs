using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheEgg.Model
{
    public class Chicken : IBird
    {
        public Chicken()
        {
        }

        public void EggLay()
        {
        }

        public Egg Lay()
        {
            /*
             * 5)
             * Make sure to pass the method without parameter list, i.e. without parentheses,
             * because you don't want to call the CreateBlackBird method at this point,
             * you want to pass it over to the constructor,
             * where it is stored in the private field _createBird to be used later.

             * A lambda expression creates an anonymous delegate on the fly:
             * 
             */
            var egg = new Egg(() => new BlackBird());
            return egg;

            // 6)
            // () => new BlackBird() is a lambda expression.
            // It is equivalent to the CreateBlackBird method.
            // The return type is not specified and
            // is inferred from the parameter type of the Egg constructor.
            // It has no name.
            // Only the parameter braces are remaining from the method header.
            // => replaces the return keyword.

            // After having implemented an additional bird class with a color as constructor parameter, you can write

            // egg = new Egg(() => new ColoredBird(Color.Blue));
    }
    }
}
