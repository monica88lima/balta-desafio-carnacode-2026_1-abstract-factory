using DesignPatternChallenge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternChallenge.Implementation.Factory
{
    public class PagSeguroFactory : IPaymentFactory
    {
        public IPaymentLogger CreateLogger()
        {
            return new PagSeguroLogger();
        }

        public IPaymentProcessor CreateProcessor()
        {
            return new PagSeguroProcessor();
        }

        public IPaymentValidator CreateValidator()
        {
            return new PagSeguroValidator();
        }
    }
}
