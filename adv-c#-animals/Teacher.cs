namespace adv_c__animals
{
    internal class Teacher : Person, ITalkable
    {
        int Age { get; set; }

        public Teacher(string name, int age) : base(name) 
        {
            Age = age;
        }

        public string Talk()
        {
            return "Don't forget to do the assigned reading!";
        }

        public string GetName()
        {
            return Name;
        }
    }
}
