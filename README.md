![CR-1](https://github.com/user-attachments/assets/5b3f4530-df7d-4f27-abe2-4a9259ddf62a)

## 🥁 CarnaCode 2026 - Desafio 01 - Abstract Factory

Oi, eu sou a Monica e este é o espaço onde compartilho minha jornada de aprendizado durante o desafio **CarnaCode 2026**, realizado pelo [balta.io](https://balta.io). 👻

Aqui você vai encontrar projetos, exercícios e códigos que estou desenvolvendo durante o desafio. O objetivo é colocar a mão na massa, testar ideias e registrar minha evolução no mundo da tecnologia.

### Sobre este desafio
No desafio **Abstract Factory** eu tive que resolver um problema real implementando o **Design Pattern** em questão.
Neste processo eu aprendi:
* ✅ Boas Práticas de Software
* ✅ Design Patterns (Padrões de Projeto)
Intenção do padrão: prover uma interface para criar famílias de objetos relacionados sem expor suas classes concretas.

## Problema
Uma plataforma de e-commerce precisa integrar com múltiplos gateways de pagamento (PagSeguro, MercadoPago, Stripe) e cada gateway tem componentes específicos (Processador, Validador, Logger).
O código atual está muito acoplado e dificulta a adição de novos gateways.

## Sobre o CarnaCode 2026
O desafio **CarnaCode 2026** consiste em implementar todos os 23 padrões de projeto (Design Patterns) em cenários reais. Durante os 23 desafios desta jornada, os participantes são submetidos ao aprendizado e prática na idetinficação de códigos não escaláveis e na solução de problemas utilizando padrões de mercado.

A solução para o desafio seguiu a seguinte ordem:

Estrutura principal do projeto 
•	Program.cs — ponto de entrada; escolhe a fábrica concreta e cria PaymentService.
•	Services/Interfaces/IPaymentService.cs — contrato do serviço de pagamento (ProcessPayment).
•	Services/PaymentService.cs — implementação do fluxo de pagamento que consome uma IPaymentFactory.
•	Interfaces/IPaymentFactory.cs — abstract factory: cria IPaymentValidator, IPaymentProcessor, IPaymentLogger.
•	Interfaces/IPaymentValidator.cs, IPaymentProcessor.cs, IPaymentLogger.cs — contratos dos componentes.
•	Implementation/Factory/*.cs — fábricas concretas (PagSeguroFactory, MercadoPagoFactory, StripeFactory).
•	Implementation/Validator/Processor/Logger — implementações concretas de cada gateway.

### eBook - Fundamentos dos Design Patterns
Minha principal fonte de conhecimento durante o desafio foi o eBook gratuito [Fundamentos dos Design Patterns](https://lp.balta.io/ebook-fundamentos-design-patterns).

### Veja meu progresso no desafio
[Incluir link para o repositório central]
