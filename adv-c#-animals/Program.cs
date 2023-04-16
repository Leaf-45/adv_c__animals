
namespace adv_c__animals 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            string file = "animals.txt";

            List<ITalkable> zooList = new List<ITalkable>();
     
            Zoo zoo = new Zoo();
            zooList = zoo.GetAnimals();
            
            foreach (ITalkable talkable in zooList)
            {
                PrintOut(talkable, file);
            }

            FileInput inFile = new FileInput(file);
            inFile.FileRead();
            inFile.FileClose();
        }

        static void PrintOut(ITalkable p, string file)
        {
            FileOutput outFile = new FileOutput(file);
            Console.WriteLine(p.GetName() + " says=" + p.Talk());
            outFile.FileWrite(p.GetName() + " | " + p.Talk());
            outFile.FileClose();
        }
    }
}





