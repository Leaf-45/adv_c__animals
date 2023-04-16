using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adv_c__animals
{
    internal class Cat : Pet, ITalkable
    {
        public int MousesKilled { get; private set; }

        public Cat(string Name, int mousesKilled) : base(Name)
        {
            MousesKilled = mousesKilled;
        }

        public void AddMouse()
        {
            MousesKilled = MousesKilled++;
        }

        public string Talk()
        {
            return "Meow";
        }

        public string GetName()
        {
            return Name;
        }
    }
}
