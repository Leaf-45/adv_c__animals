using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adv_c__animals
{
    internal class FileOutput
    {
        private StreamWriter _sw;

        private string FileName;

        public FileOutput(string fileName)
        {
            FileName = fileName;
            try
            {
                _sw = new StreamWriter(fileName, true);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File Open Error: " + fileName + " " + e);
            }
        }

        public void FileWrite(String line)
        {
            try
            {
            _sw.WriteLine(line);
            } catch (Exception e)
            {
                Console.WriteLine("File Write Error: " + FileName + " " + e);
            }
        }

        public void FileClose()
        {
            if (_sw != null) {
                try
                {
                _sw.Close();
                } catch (IOException e)
                {
                    Console.WriteLine(e);
                }
            }

        }
    }
}
