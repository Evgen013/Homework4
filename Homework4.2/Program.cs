
/*Створити клас AbstractHandler. У тілі класу створити методи void Open(), 
 * void Create(), void Change(), void Save().
 * 
 * Створити похідні класи XMLHandler, TXTHandler, DOCHandler 
 * від базового класу AbstractHandler. 
 * 
 * Написати програму, яка виконуватиме визначення документа 
 * і для кожного формату мають бути
 * методи відкриття, створення, редагування, збереження певного формату документа.*/

using Homework4._2;

namespace Homework4._2
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the format of the document");
            string format = Console.ReadLine();
            

            switch (format)
            {
                case "xml":
                    {
                        AbstractHandler xml = new XmlHandler();

                        xml.Open();
                        xml.Create();
                        xml.Change();
                        xml.Save();

                        break;
                    }
                case "txt":
                    {
                        AbstractHandler txt = new TxtHandler();

                        txt.Open();
                        txt.Create();
                        txt.Save();
                        txt.Change();
                        break;
                    }
                case "doc":
                    {
                        AbstractHandler doc = new DocHandler();

                        doc.Open();
                        doc.Create();
                        doc.Save();
                        doc.Change();

                        break;
                    }
                default:
                    {
                        Console.WriteLine("incorect format");
                        break;
                    }
            }

            Console.ReadKey();

        }
    }
}