using Module10.Unit4.Models;

namespace Module10.Unit4
{
    // Ковариация
    //public interface IMessenger<out T>
    //{
    //    T DeviceInfo();
    //}

    //Контравариация
    public interface IMessenger<in T>
    {
        void GetDeviceInfo(T device);
    }

    public interface IUpdater<in T>
    {
        void Update(T entity);
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //IMessenger<Phone> viberInPhone = new Viber<Phone>();
            //IMessenger<IPhone> viberInIPhone = new Viber<IPhone>();

            //viberInPhone.DeviceInfo();
            //viberInIPhone.DeviceInfo();

            //IMessenger<Phone> viberInIphone = new Viber<IPhone>();

            //viberInIphone.DeviceInfo();

            IMessenger<Phone> viberInPhone = new Viber<Phone>();
            viberInPhone.GetDeviceInfo(new Phone());

            IMessenger<IPhone> viberInIPhone = new Viber<IPhone>();
            viberInIPhone.GetDeviceInfo(new IPhone());

            IMessenger<IPhone> viberInIphone = new Viber<Phone>();

            IUpdater<Account> userService = new UserService();
        }
    }
}
