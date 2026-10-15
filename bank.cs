using System;
using System.Collections.Generic;


class Program {

    

    static void Main()
    {
        double balance = 0; 
        List<string> transactions = new List<string>();


        while (true)
        {
            Console.WriteLine("1.Show amount");
            Console.WriteLine("2.Add amount");
            Console.WriteLine("3.Withdraw amount");
            Console.WriteLine("4.History");
            Console.WriteLine("5.Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine($"Current balance: {balance} rub.");
                    break;
                case "2":
                    Console.WriteLine("Enter amount to add:");
                    if (!double.TryParse(Console.ReadLine(), out double amountToAdd) || amountToAdd <= 0)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                    else
                    {
                        balance += amountToAdd;
                        transactions.Add($"Add: +{amountToAdd}");
                    }
                    break;

                    case "3":
                        Console.WriteLine("enter amount to withdraw:");
                    if (!double.TryParse(Console.ReadLine(), out double amountToWithdraw) || amountToWithdraw <= 0)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                    else if (amountToWithdraw > balance)
                    {
                        Console.WriteLine("Insufficient funds.");
                    }
                    else
                    {
                        balance -= amountToWithdraw;
                        transactions.Add($"Withdraw: -{amountToWithdraw}");
                    }
                    break;
                case "4":
                    if (transactions.Count == 0)
                    {
                        Console.WriteLine("No transactions yet.");
                    }
                    else
                    {
                        Console.WriteLine("Transaction history:");
                        foreach (var transaction in transactions)
                        {
                            Console.WriteLine(transaction);
                        }
                    }
                    break;


                case "5":
                    Console.WriteLine("Exiting...");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;

            }

        }

                

            

            


         
    }



}
