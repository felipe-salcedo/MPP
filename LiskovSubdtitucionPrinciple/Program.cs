using System;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CreditCard creditCard = new CreditCard();
            DebitCard debitCard = new DebitCard();

           
            Console.WriteLine("CreditCard:");
            creditCard.Validacao(); 
            creditCard.ColetarPagamento(); 
            creditCard.AtualizarPontuacao();
            Console.WriteLine("\nDebitCard:");
            debitCard.Validacao();
            debitCard.ColetarPagamento();
            debitCard.AtualizarPontuacao();
        }
    }
}
