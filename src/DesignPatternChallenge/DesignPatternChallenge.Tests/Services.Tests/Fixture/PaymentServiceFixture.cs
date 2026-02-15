using DesignPatternChallenge.Interfaces;
using DesignPatternChallenge.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternChallenge.Tests.Services.Tests.Fixture
{
    public class PaymentServiceFixture
    {
        public Mock<IPaymentFactory> FactoryMock { get; }
        public Mock<IPaymentValidator> ValidatorMock { get; }
        public Mock<IPaymentProcessor> ProcessorMock { get; }
        public Mock<IPaymentLogger> LoggerMock { get; }
        public PaymentService Service { get; }

        public PaymentServiceFixture()
        {
            FactoryMock = new Mock<IPaymentFactory>();
            ValidatorMock = new Mock<IPaymentValidator>();
            ProcessorMock = new Mock<IPaymentProcessor>();
            LoggerMock = new Mock<IPaymentLogger>();

            FactoryMock.Setup(f => f.CreateValidator()).Returns(ValidatorMock.Object);
            FactoryMock.Setup(f => f.CreateProcessor()).Returns(ProcessorMock.Object);
            FactoryMock.Setup(f => f.CreateLogger()).Returns(LoggerMock.Object);

            Service = new PaymentService(FactoryMock.Object);

        }

    }
}
