using DesignPatternChallenge.Interfaces;
using DesignPatternChallenge.Services.Interfaces;


namespace DesignPatternChallenge.Services
{

    public class PaymentService : IPaymentService
    {
        private readonly IPaymentFactory _factory;

        public PaymentService(IPaymentFactory factory)
        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }

        public void ProcessPayment(decimal amount, string cardNumber)
        {
            var validator = _factory.CreateValidator();
            if (!validator.ValidateCard(cardNumber))
            {
                Console.WriteLine("Cartão inválido");
                return;
            }

            var processor = _factory.CreateProcessor();
            var result = processor.ProcessTransaction(amount, cardNumber);

            var logger = _factory.CreateLogger();
            logger.Log($"Transação processada: {result}");
        }
    }

}

