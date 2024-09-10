using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10.Unit2.Models
{
    internal class Worker : IWorker
    {
        //public void Build()
        //{
        //    Console.WriteLine("Task 10.2.3");
        //}
        void IWorker.Build()
        {
            Console.WriteLine("Task 10.2.3");
        }
    }
}
