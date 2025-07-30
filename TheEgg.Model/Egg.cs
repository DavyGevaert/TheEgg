using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheEgg.Model
{
    /*
     * https://stackoverflow.com/questions/55187969/passing-a-predicate-as-a-parameter-c-sharp
     * 
     * 1)
     * public Egg(Func<IBird> createBird) is not a function, 
     * it's the constructor of the Egg class. Since the Egg class must Hatch birds,
     * it needs to create birds. Func<IBird> is a delegate,
     * i.e., a value representing a reference to a method.
     * In this specific case it is representing a factory method.
     * A predicate would be a method or delegate returning a Boolean.
     * Through this parameter you can pass any method creating IBirds.
     * Since the IBird interface does not specify an explicit implementation of a bird,
     * you could initialize Egg with different methods creating different bird types.
     * Some requiring constructor parameters, some not.

        You would implement Egg like this   
     */
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
