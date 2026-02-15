using DesignPatternChallenge.Interfaces;
using DesignPatternChallenge.Tests.Services.Tests.Fixture;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DesignPatternChallenge.Tests.Services.Tests
{
    public  class PaymentServiceTests: IClassFixture<PaymentServiceFixture>
    {
        private readonly Fixture.PaymentServiceFixture _fixture;


        public PaymentServiceTests(PaymentServiceFixture fixture)
        {
            _fixture = fixture;
        }


        [Fact]
        public void ProcessPayment_InvalidCard_ShouldLogError()
        {
            // Arrange
            _fixture.ValidatorMock.Setup(v => v.ValidateCard(It.IsAny<string>())).Returns(false);
            _fixture.ProcessorMock.Setup(p => p.ProcessTransaction(It.IsAny<decimal>(), It.IsAny<string>()))
                                 .Returns("Sucesso");
            using var sw = new StringWriter();
            Console.SetOut(sw);


            // Act
            _fixture.Service.ProcessPayment(20, "6");


            // Assert
            var output = sw.ToString().Trim();
            Assert.Equal("Cartão inválido", output);
        }

        [Fact]
        public void ProcessPayment_ValidCard_ShouldProcessTransaction()
        {
            // Arrange
            _fixture.ValidatorMock.Setup(v => v.ValidateCard(It.IsAny<string>())).Returns(true);
            _fixture.ProcessorMock.Setup(p => p.ProcessTransaction(It.IsAny<decimal>(), It.IsAny<string>()))
                                  .Returns("Sucesso");

            // Act
            _fixture.Service.ProcessPayment(100, "123456");

            // Assert
            _fixture.LoggerMock.Verify(l => l.Log("Transação processada: Sucesso"), Times.Once);
        }


    }
}
     