# Facade Examplo do Padrão Estrutural: Loan Approval System

This project demonstrates the **Facade Design Pattern** by simulating a simplified loan approval process. The Facade pattern provides a unified interface to a complex subsystem, making it easier to use.

## Project Overview
The system checks if a customer is eligible for a loan by evaluating three criteria through a simplified interface (`Loan` Facade):
1. **Account Balance Check** (`AccountInfo`)
2. **Credit Score Check** (`CreditScore`)
3. **Existing Loan Status Check** (`LoanStatus`)

The `Loan` Facade hides the complexity of these checks from the client code.

## Project Structure
| Class                  | Description                                                                    |
|------------------------|--------------------------------------------------------------------------------|
| `Loan` (Facade)        | Provides a simplified method `IsEligible()` to check loan eligibility.         |
| `AccountInfo`          | Checks if the customer has sufficient account balance.                         |
| `CreditScore`          | Validates the customer's credit score.                                         |
| `LoanStatus`           | Verifies the status of the customer's existing loans.                          |
| `Customer`             | Represents a customer with a name property.                                    |

## How It Works
1. The client creates a `Customer` (Customer) and requests a loan amount.
2. The `Loan` Facade coordinates three checks:
   - Account balance sufficiency
   - Credit score validity
   - Existing loan status
3. Loan approval is granted only if **all three checks pass**.

## Example Usage
```csharp
// Program.cs
Customer Customer = new Customer("jose@hotmail.com");
Loan loan = new Loan();
bool eligible = loan.IsEligible(Customer, 125000);

Console.WriteLine("\nA Requisição de Empréstimo para " + customer.Name +
                  " Foi " + (eligible ? "Aprovada" : "Negada") + "!");
```
### Output
```
Escreva o Email desse Cliente:
Jose@hotmail.com

Endereço de Email Válido

Jose@hotmail.com está tentando Conseguir um Empréstimo de 125000 Euros. Checagens serão Realizadas, e a Aplicação será Concluída:

Checando a Quantidade de Euros na Conta de Jose@hotmail.com para Conseguir um Empréstimo...
Checando a Situação Atual da Conta de Jose@hotmail.com para Conseguir o Empréstimo...
Checando o Crédito Corrente de Jose@hotmail.com para Conseguir o Empréstimo...

A Requisição de Empréstimo para Jose@hotmail.com Foi Aprovada!

++>Aprovado