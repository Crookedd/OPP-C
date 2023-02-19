using System;

namespace OPP
{
    public class ElDoc
    {
        public string Name { get; set; }
        public string Authors { get; set; }
        public string[] KeyWords { get; set; }
        public string Theme { get; set; } 
        public string PathToFaile { get; set; }

        public virtual void PrintValues()
        {
            string str = "";

            for (int index = 0; index < KeyWords.Length; ++index)
            {
                if (KeyWords[index] != "")
                {
                    str += KeyWords[index];
                }
            }
            
            Console.WriteLine($"Название: {Name}\nАвтор: {Authors}\nКлючевые слова: {str}\nТема: {Theme}\nПуть к файлу: {PathToFaile}");
            Console.ReadKey();
        }
    }
}
