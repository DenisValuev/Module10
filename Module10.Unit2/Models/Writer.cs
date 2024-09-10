using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10.Unit2.Models
{
    internal class Writer : IWriter
    {
        void IWriter.Write()
        {
            Console.WriteLine("Task 10.2.2");
        }
    }
}
