using DesignPatternChallenge.Implementation.Factory;
using DesignPatternChallenge.Interfaces;
using DesignPatternChallenge.Services;


    
        Console.WriteLine("=== Sistema de Pagamentos ===\n");

        var pagFactory = GetFactory("pagseguro");
        var pagService = new PaymentService(pagFactory);
        pagService.ProcessPayment(150.00m, "1234567890123456");

        Console.WriteLine();

        var mpFactory = GetFactory("mercadopago");
        var mpService = new PaymentService(mpFactory);
        mpService.ProcessPayment(200.00m, "5234567890123456");


    static IPaymentFactory GetFactory(string gateway) => gateway.ToLower() switch
    {

        //Criar a classe q contem as implementações dos metodos padroes de todos os gateway
        "pagseguro" => new PagSeguroFactory(),
        "mercadopago" => new MercadoPagoFactory(),
        "stripe" => new StripeFactory(),
        _ => throw new ArgumentException("Gateway não suportado")
    };


