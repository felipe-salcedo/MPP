/// Primeiro Subsistema

public class AccountInfo
{
    public bool HasSufficientSavings(Customer c, int amount)
    {
        Console.WriteLine("Checando a Quantidade de Euros na Conta de " + c.Name + " para Conseguir um Empréstimo...");
        amount = 999999999;
        if(amount >= 99)
            return true;
        else
            return false;
        
    }
}
