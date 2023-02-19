using System;

namespace OPP
{
    public class TXT : ElDoc
    {
        public string SpecialPropertyTXT { get; set; }
        public string SomeKindOfProperty { get; set; }

        public override void PrintValues()
        {
            Console.WriteLine($"Особое свойство TXT: {SpecialPropertyTXT}\nКакое-то Свойство: {SomeKindOfProperty}");
            Console.ReadKey();
        }
    }
}
