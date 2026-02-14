using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternChallenge.Interfaces
{
  public interface IPaymentValidator
   {
        bool ValidateCard(string cardNumber);
    }
}
