using System;

namespace PaymentAdapters
{
    // 1) Interface "Alvo" (Target) - O contrato que o client conhece.
    public interface IPayPalPayment
    {
        void paypalPayment();
        void paypalReceive();
    }

    // 2) Classe que representa o serviço PayPal (o padrão).
    public class PayPal : IPayPalPayment
    {
        public void paypalPayment()
        {
            Console.WriteLine("PayPal: Enviando pagamento...");
        }

        public void paypalReceive()
        {
            Console.WriteLine("PayPal: Recebendo pagamento...");
        }
    }

    // 3) Classe que representa o serviço Payoneer (API diferente do PayPal).
    public class Payoneer
    {
        public void sendPayment()
        {
            Console.WriteLine("Payoneer: Enviando pagamento...");
        }

        public void receivePayment()
        {
            Console.WriteLine("Payoneer: Recebendo pagamento...");
        }
    }

    // 4) Adapter que "traduz" as chamadas de PayPal para Payoneer.
    public class PayoneerAdapter : IPayPalPayment
    {
        private readonly Payoneer _payoneer;

        public PayoneerAdapter(Payoneer payoneer)
        {
            _payoneer = payoneer;
        }

        public void paypalPayment()
        {
            // Aqui chamamos o método sendPayment da Payoneer
            _payoneer.sendPayment();
        }

        public void paypalReceive()
        {
            // Aqui chamamos o método receivePayment da Payoneer
            _payoneer.receivePayment();
        }
    }

    // 5) Classe que representa o serviço MercadoPago (API diferente do PayPal).
    public class MercadoPago
    {
        public void sendMercadoPayment()
        {
            Console.WriteLine("MercadoPago: Enviando pagamento...");
        }

        public void receiveMercadoPayment()
        {
            Console.WriteLine("MercadoPago: Recebendo pagamento...");
        }
    }

    // 6) Adapter que "traduz" as chamadas de PayPal para MercadoPago.
    public class MercadoPagoAdapter : IPayPalPayment
    {
        private readonly MercadoPago _mercadoPago;

        public MercadoPagoAdapter(MercadoPago mercadoPago)
        {
            _mercadoPago = mercadoPago;
        }

        public void paypalPayment()
        {
            // Aqui chamamos o método sendMercadoPayment do MercadoPago
            _mercadoPago.sendMercadoPayment();
        }

        public void paypalReceive()
        {
            // Aqui chamamos o método receiveMercadoPayment do MercadoPago
            _mercadoPago.receiveMercadoPayment();
        }
    }

    // 7) Classe cliente que conhece apenas o "contrato" PayPal
    public class Client
    {
        private IPayPalPayment _payPalPayment;

        public Client(IPayPalPayment payPalPayment)
        {
            _payPalPayment = payPalPayment;
        }

        public void MakePayment()
        {
            _payPalPayment.paypalPayment();
            _payPalPayment.paypalReceive();
        }
    }

    // 8) Classe de inicialização (exemplo de uso).
    class Program
    {
        static void Main()
        {
            Console.WriteLine("==== Usando o PayPal nativo ====");
            IPayPalPayment payPal = new PayPal();
            Client clientPaypal = new Client(payPal);
            clientPaypal.MakePayment();

            Console.WriteLine("\n==== Usando o Payoneer via Adapter ====");
            Payoneer payoneer = new Payoneer();
            IPayPalPayment payoneerAdapter = new PayoneerAdapter(payoneer);
            Client clientPayoneer = new Client(payoneerAdapter);
            clientPayoneer.MakePayment();

            Console.WriteLine("\n==== Usando o MercadoPago via Adapter ====");
            MercadoPago mercadoPago = new MercadoPago();
            IPayPalPayment mercadoPagoAdapter = new MercadoPagoAdapter(mercadoPago);
            Client clientMercadoPago = new Client(mercadoPagoAdapter);
            clientMercadoPago.MakePayment();

            Console.ReadLine();
        }
    }
}
