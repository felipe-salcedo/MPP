# Fachada Exemplo do Padrão Estrutural: Sistema de Aprovação de Empréstimos

Este projeto demonstra o **Padrão de Projeto Facade** ao simular um processo simplificado de aprovação de empréstimos. O padrão Facade fornece uma interface unificada para um subsistema complexo, tornando-o mais fácil de usar.

## Visão Geral do Projeto 
O sistema verifica se um cliente é eligible para um empréstimo avaliando três critérios através de uma interface simplificada (`Loan` Facade): 
1. **Verificação de Saldo da Conta** (`AccountInfo`) 
2. **Verificação de Pontuação de Crédito** (`CreditScore`) 
3. **Verificação do Status do Empréstimo Existente** (`LoanStatus`)

A Fachada `Loan` oculta a complexidade dessas verificações do código do cliente.

## Estrutura do Projeto 
| Classe                 | Descrição                                                                                   | 
|------------------------|---------------------------------------------------------------------------------------------| 
| `Loan` (Fachada)       | Fornece um método simplificado `IsEligible()` para verificar a elegibilidade do empréstimo. | 
| `AccountInfo`          | Verifica se o cliente tem saldo suficiente na conta.                                        | 
| `CreditScore`          | Valida a pontuação de crédito do cliente.                                                   | 
| `LoanStatus`           | Verifica o status dos empréstimos existentes do cliente.                                    | 
| `Customer`             | Representa um cliente com uma propriedade de nome.                                          |

## Como Funciona 
1. O cliente cria um `Customer` (Cliente) e solicita um valor de empréstimo. 
2. A Fachada de `Loan` coordena três verificações: 
    - Suficiência do saldo da conta 
    - Validade do score de crédito 
    - Status do empréstimo existente 
3. A aprovação do empréstimo é concedida apenas se **todos os três critérios forem interpretados**.

## Exemplo de Uso 
```csharp 
// Program.cs 
Cliente Cliente = new Cliente("Jose@hotmail.com"); 
Loan loan = new Loan(); 
bool eligible = empréstimo. IsEligible(Cliente, 125000);

Console.WriteLine("\nA Requisição de Empréstimo para " + customer.Name + 
" Foi " + (eligible ? "Aprovada" : "Negada") + "!") ; 
``` 
### Saída 
``` 
Escreva o Email desse Cliente: 
Jose@hotmail.com

Endereço de Email Válido

Jose@hotmail.com está tentando conseguir um empréstimo de 125000 euros. Checagens serão realizadas, e a aplicação será concluída:

Checking the Amount of Euros in the Account of Jose@hotmail.com to Get a Loan... 
Checking the Current Status of the Account of Jose@hotmail.com to Obtain the Loan... 
Checking the Current Credit of Jose@hotmail.com to Obtain the Loan...

A Requisição de Empréstimo para Jose@hotmail.com Foi Aprovada!

++>Aprovado