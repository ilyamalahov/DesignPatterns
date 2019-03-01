using DesignPatterns.FactoryMethod.Transports;

namespace DesignPatterns.FactoryMethod.Creators
{
    public class CarCreator : ITransportCreator
    {
        public ITransport CreateTransport()
        {
            return new Car();
        }
    }
}
