using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternChallenge.Services.Interfaces
{
    public  interface IPaymentService
    {
        void ProcessPayment(decimal amount, string cardNumber);
      
    }
}
