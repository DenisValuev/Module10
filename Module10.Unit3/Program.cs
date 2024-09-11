using Module10.Unit3.Models;

namespace Module10.Unit3
{
    public interface IWriter
    {
        void Write();
    }
    public interface IReader
    {
        void Read();
    }
    public interface IMailer
    {
        void SendEmail();
    }

    public interface ICreatable 
    {
        void Create();
    }
    public interface IDeletable
    {
        void Delete();
    }
    public interface IUpdatable
    {
        void Update();
    }

    public interface IBook
    {
        void Read();
    }
    public interface IDevice
    {
        void TurnOn();
        void TurnOff();
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IWriter writer = new FileManager();
            IReader reader = new FileManager();
            IMailer mailer = new FileManager();

            writer.Write();
            reader.Read();
            mailer.SendEmail();
        }
    }
}
