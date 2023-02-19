using System;

namespace OPP
{
    public class HTML : ElDoc
    {
        public string FileCreationDate { get; set; }
        public int FileSize { get; set; }

        public override void PrintValues()
        {
            Console.WriteLine($"Дата создания файла: {FileCreationDate}\nРазмер файла: {FileSize}");
            Console.ReadKey();
        }
    }
}
