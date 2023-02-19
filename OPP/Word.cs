using System;

namespace OPP
{
     public class Word : ElDoc
    {
        public string TextFont { get; set; }
        public int TextSize { get; set; }
        public int HeaderSize { get; set; }

        public override void PrintValues()
        {
            Console.WriteLine($"Шрифт Текста: {TextFont}\nРазмер Текста: {TextSize}\nРазмер Заголовка: {HeaderSize}");
            Console.ReadKey(); 
        }

    }
}
