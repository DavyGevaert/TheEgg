using System;
using System.Collections.Generic;
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
            return new Egg(() => new BlackBird());
        }
    }
}
