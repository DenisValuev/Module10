using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10.Unit3.Models
{
    internal class FileManager : IWriter, IReader, IMailer
    {
        void IReader.Read()
        {
            Console.WriteLine("Читаю  из файла ...");
        }

        void IMailer.SendEmail()
        {
            Console.WriteLine("Отправляю файл ...");
        }

        void IWriter.Write()
        {
            Console.WriteLine("Пишу в файл ...");
        }
    }
}
