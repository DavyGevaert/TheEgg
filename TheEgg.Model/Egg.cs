using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheEgg.Model
{
    public class Egg
    {
        private readonly Func<IBird> _createBird;

        public Egg(Func<IBird> createBird)
        {
            _createBird = createBird; // No "()". createBird is not called, just assigned.
        }

        public IBird Hatch()
        {
            return _createBird(); // Here createBird is called, therefore the "()".
        }
    }
}
