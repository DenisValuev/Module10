using Module10.Unit2.Models;

namespace Module10.Unit2
{
    public interface IWhatsApp
    {
        public void SendMessage(string message);
    }

    public interface IViber
    {
        public void SendMessage(string message);
    }

    public interface IWriter
    {
        public void Write();
    }

    public interface IWorker
    {
        public void Build();
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            NewMessenger newMessenger = new NewMessenger();
            ((IWhatsApp)newMessenger).SendMessage("Hello World");
            ((IViber)newMessenger).SendMessage("Hello World");

            Writer writer = new Writer();
            ((IWriter)writer).Write();

            Worker worker = new Worker();
            ((IWorker)worker).Build();

        }
    }
}
