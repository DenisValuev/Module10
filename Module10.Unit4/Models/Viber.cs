using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10.Unit4.Models
{
    internal class Viber<T> : IMessenger<T> where T : Phone, new()
    {
        //public T DeviceInfo()
        //{
        //    T device = new T();
        //    Console.WriteLine(device);
        //    return new T();
        //}
        public void GetDeviceInfo(T device)
        {
        }
    }
}
