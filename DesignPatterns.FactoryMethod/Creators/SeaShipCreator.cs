using DesignPatterns.FactoryMethod.Transports;

namespace DesignPatterns.FactoryMethod.Creators
{
    public class SeaShipCreator : ITransportCreator
    {
        public ITransport CreateTransport()
        {
            return new SeaShip();
        }
    }
}
