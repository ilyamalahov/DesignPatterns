using DesignPatterns.FactoryMethod.Transports;

namespace DesignPatterns.FactoryMethod.Creators
{
    public interface ITransportCreator
    {
        ITransport CreateTransport();
    }
}
