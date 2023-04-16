namespace adv_c__animals
{
    abstract class Pet
    {
        public string Name { get; }

        public Pet(string name)
        {
            Name = name;
        }
    }
}
