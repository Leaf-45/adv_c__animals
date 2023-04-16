namespace adv_c__animals
{
    internal class Zoo
    {
        public List<ITalkable> GetAnimals()
        {
            var list = new List<ITalkable>();
            var message = "Press 1 to create a dog\nPress 2 to create a cat";
            Console.WriteLine(message);
            var input = "";
            var addedAnimal = false;
            while (input != "3" || !addedAnimal) 
            {
                input = Console.ReadLine();
                if (input == "1") 
                {
                    list.Add(CreateDog());
                    addedAnimal = true;
                    Console.WriteLine(message + "\nPress 3 to stop adding animals");
                } 
                else if (input == "2") 
                {
                    list.Add(CreateCat());
                    addedAnimal = true;
                    Console.WriteLine(message + "\nPress 3 to stop adding animals");
                } 
                else if (input != "3") Console.WriteLine("invalid input");
            }  
            return list;
        }

        private Cat CreateCat() 
        {
            Console.WriteLine("What is the cat's name?");
            var catName = Console.ReadLine();
            Console.WriteLine("How many mice has the cat hunted?\nEnter a number like 8 instead of eight");
            var input = Console.ReadLine();
            var totalMice = 0;
            while (!int.TryParse(input, out totalMice)) 
            {
                Console.WriteLine("Invalid response");
                input = Console.ReadLine();
            }
            Console.WriteLine($"Created a cat named {catName} and has hunted {totalMice} mice");
            
            return new Cat(catName, totalMice);
        }

        private Dog CreateDog()
        {
            Console.WriteLine("What is the dog's name?");
            var dogName = Console.ReadLine();
            Console.WriteLine("Is the dog friendly?\ny for yes and n for no");
            var input = "";
            var friendly = true;
            while (input != "y" && input != "n") 
            {
                input = Console.ReadLine().ToLower();
                if (input == "n") friendly = false;
                if (input != "y" && input != "n") Console.WriteLine("Invalid input");
            }
            
            Console.WriteLine($"Created a dog named {dogName} and he is {(friendly ? "friendly" : "not friendly")}");

            return new Dog(dogName, friendly);
        }
    }
}
