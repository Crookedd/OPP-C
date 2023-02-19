using System;

namespace OPP
{
    internal class Program
    {
        private static void DocumentOutput(ElDoc eldoc)
        {
            eldoc.PrintValues();
        }
        static void Main(string[] args)
        {
            ElDoc Information = new ElDoc
            {
                Name = "Общество мёртвых поэтов",
                Authors = "Н.Г.Клейнбаум",
                Theme = "Литературное произведение",
                PathToFaile = "https://DPS.L//1989",
                KeyWords = new string[] { "Капитан; ", "Мгновение; ", "Учебное заведение; "},
            };
            DocumentOutput(Information);

            Console.WriteLine("Введите документ у которого хотите узнать основные свойства: ");
            Console.WriteLine("1. MS Word\n2. PDF\n3. MS Excel\n4. TXT\n5. HTML");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ElDoc InformationWord = new Word
                    {
                        TextFont = "Times New Roman",
                        TextSize = 16,
                    };
                    DocumentOutput(InformationWord);
                    break;
                case "2":
                    ElDoc InformationPDF = new PDF
                    {
                        ProtectionParameter = "Пароль",
                        Heading = "Стекло"
                    };
                    DocumentOutput(InformationPDF);
                    break;
                case "3":
                    ElDoc InformationExcel = new Excel
                    {
                        NumberOfColumns = 15,
                        NumberOfRows = 16,
                        ColumnColor = "Красный",
                    };
                    DocumentOutput(InformationExcel);
                    break;
                case "4":
                    ElDoc InformationTXT = new TXT
                    {
                        SpecialPropertyTXT = "Что-то особенное",
                        SomeKindOfProperty = "Очень особенное",
                    };
                    DocumentOutput(InformationTXT);
                    break;
                case "5":
                    ElDoc InformationHTML = new HTML
                    {
                        FileCreationDate = "12.12.1212",
                        FileSize = 1212,
                    };
                    DocumentOutput(InformationHTML);
                    break;
                default:
                    Console.WriteLine("Такого документа нет!");
                    break;
            }
        }
    }
}
