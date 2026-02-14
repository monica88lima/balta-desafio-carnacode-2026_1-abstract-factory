using DesignPatternChallenge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternChallenge.Implementation.Factory
{
    public class StripeFactory : IPaymentFactory
    {
        public IPaymentLogger CreateLogger()
        {
            return new StripeLogger();
        }

        public IPaymentProcessor CreateProcessor()
        {
           return new StripeProcessor();
        }

        public IPaymentValidator CreateValidator()
        {
           return new StripeValidator();
        }
    }
}
