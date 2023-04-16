using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adv_c__animals
{
    internal class FileInput
    {
        private StreamReader _sr;

        private string FileName;

        public FileInput(string fileName) 
        { 
            FileName = fileName;
            try 
            { 
                _sr = new StreamReader(fileName);
            } catch (FileNotFoundException e) 
            {
                Console.WriteLine("File Open Error: " + fileName + " " + e);
            }
        }

        public void FileRead()
        {
            String line;
            try
            {
                while ((line = _sr.ReadLine()) != null) {
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("File Write Error: " + FileName + " " + e);
            }
        }

        public String FileReadLine()
        {
            try
            {
                String line = _sr.ReadLine();
                return line;
            }
            catch (Exception e)
            {
                Console.WriteLine("File Write Error: " + FileName + " " + e);
                return null;
            }
        }

        public void FileClose()
        {
            if (_sr != null) {
                try
                {
                    _sr.Close();
                } catch (IOException e)
                {
                    Console.WriteLine(e);
                }
            }

        }
    }
}
