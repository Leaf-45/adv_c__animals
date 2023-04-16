namespace adv_c__animals
{
    abstract class Person
    {
        public string Name { get; set; }


        public Person(string name)
        {
            this.Name = name;
        }
    }
}
