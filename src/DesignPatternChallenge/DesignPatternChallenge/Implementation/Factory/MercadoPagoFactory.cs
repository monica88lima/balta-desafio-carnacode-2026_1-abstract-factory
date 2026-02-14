using DesignPatternChallenge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternChallenge.Implementation.Factory
{
    public class MercadoPagoFactory : IPaymentFactory
    {
        public IPaymentLogger CreateLogger()
        {
            return new MercadoPagoLogger();
        }

        public IPaymentProcessor CreateProcessor()
        {
            return new MercadoPagoProcessor();
        }

        public IPaymentValidator CreateValidator()
        {
            return new MercadoPagoValidator();
        }
    }
}
