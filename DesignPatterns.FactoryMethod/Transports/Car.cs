using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod.Transports
{
    public class Car : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Deliver by car");
        }
    }
}
