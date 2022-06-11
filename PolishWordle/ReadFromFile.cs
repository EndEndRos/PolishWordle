using System;
using System.Collections.Generic;

namespace PolishWordle
{
    class ReadFromFile
    {
        public string RandomWord()
        {
             
                string[] lines = System.IO.File.ReadAllLines("words.txt");
                List<string> list = new List<string>();
                foreach (string line in lines)
                {
                    list.Add(line);
                }

                
                Random random = new Random();
                int index = random.Next(list.Count);
                string RandomeTheWord = list[index];
                RandomeTheWord = RandomeTheWord.ToUpper();
                return RandomeTheWord;

       
            

        }
    }
}
