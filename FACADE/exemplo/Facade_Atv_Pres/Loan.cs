/// Facade, classe para verificar o empréstimo

public class Loan
{
    AccountInfo accountInfo = new AccountInfo();
    LoanStatus loans = new LoanStatus();
    CreditScore creditScore = new CreditScore();

    public bool IsEligible(Customer customer, int amount)
    {
        //Substituí o {0] pelo valor após a vírgula, e o {1} pelo valor após a vírgula
        Console.WriteLine("\n{0} está tentando Conseguir um Empréstimo de {1} Euros. Checagens serão Realizadas, e a Aplicação será Concluída:\n",
        customer.Name, amount);

        bool eligible = true;

        // Performando as checagens de Empréstimo e decidindo se o cliente pode conseguir um empréstimo com base nas análises realizadas pelos subsistemas:

        if (!accountInfo.HasSufficientSavings(customer, amount))
        {
            eligible = false;
        }
        else if (!loans.IsLoanStatusGood(customer))
        {
            eligible = false;
        }
        else if (!creditScore.IsCreditScoreGood(customer))
        {
            eligible = false;
        }

        return eligible;
    }
}