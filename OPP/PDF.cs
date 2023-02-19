using System;

namespace OPP
{
    public class PDF : ElDoc
    {
        public string ProtectionParameter { get; set; }
        public string Heading { get; set; }

        public override void PrintValues()
        {
            Console.WriteLine($"Параметр защиты: {ProtectionParameter}\nЗаголовок: {Heading}");
            Console.ReadKey();
        }
    }
}
