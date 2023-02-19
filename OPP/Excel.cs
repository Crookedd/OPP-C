using System;

namespace OPP
{
    public class Excel : ElDoc
    {
        public int NumberOfColumns { get; set; }
        public int NumberOfRows { get; set; }
        public string ColumnColor { get; set; } 

        public override void PrintValues()
        {
            Console.WriteLine($"Количество Столбцов: {NumberOfColumns}\nКоличество Строк: {NumberOfRows}\nЦвет Столбцов: {ColumnColor}");
            Console.ReadKey();
        }

    }
}
