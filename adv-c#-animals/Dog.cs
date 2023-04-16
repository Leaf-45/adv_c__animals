using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adv_c__animals
{
    internal class Dog : Pet, ITalkable
    {
        public bool Friendly { get; }

        public Dog(string Name, bool friendly) : base(Name)
        {
            Friendly = friendly;
        }

        public string Talk()
        {
            return "Bark";
        }

        public string GetName()
        {
            return Name;
        }
    }
}
