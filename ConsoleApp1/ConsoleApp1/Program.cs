using System;

namespace Currency_conventer_system
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commands = { "/show-recent-currency-rates", "/find-currency-rate-by-code", "/calculate-amount-by-currency", "/exit" };
            string[] currencies = { "USD", "RUB", "TRY", "EUR" };
            double[] currencyRates = { 1.7000, 0.0275, 0.1022, 1.8161 };
            while (true)
            {
                Console.WriteLine();
                for (int i = 0; i < commands.Length; i++)
                {
                    Console.WriteLine(commands[i]);
                }
                Console.WriteLine();
                Console.Write("Please, choose the command:  "); string command = Console.ReadLine();

                if (command == "/show-recent-currency-rates")
                {
                    for (int i = 0; i < currencies.Length; i++)
                    {
                        Console.WriteLine($"Currency code:  {currencies[i]}  Currency rate: {currencyRates[i]}");
                    }
                }
                else if (command == "/find-currency-rate-by-code")
                {
                    Console.WriteLine("Enter the currency code:"); string targetCurrency = Console.ReadLine();
                    bool isCurrencyCodeNotFound = true;

                    for (int i = 0; i < currencies.Length; i++)
                    {
                        if (targetCurrency == currencies[i])
                        {
                            Console.WriteLine($"Currency code:  {currencies[i]}  Currency rate: {currencyRates[i]}");
                            isCurrencyCodeNotFound = false;
                            break;
                        }
                    }
                    if (isCurrencyCodeNotFound)
                    {
                        Console.WriteLine("The currency code you entered was not found: " + targetCurrency);
                    }
                }
                else if (command == "/calculate-amount-by-currency")
                {
                    Console.WriteLine("Enter currency code: ");
                    string requiredCurrency = Console.ReadLine();
                    double requiredCurrencyRate = 0;
                    bool isRequiredCurrencyNotFound = true;



                    for (int i = 0; i < currencies.Length; i++)
                    {
                        if (requiredCurrency == currencies[i])
                        {
                            requiredCurrencyRate = currencyRates[i];
                            isRequiredCurrencyNotFound = false;

                            break;
                        }
                    }
                    if (isRequiredCurrencyNotFound)
                    {
                        Console.WriteLine("Currency not found!");
                        break;
                    }

                    Console.WriteLine("Enter amount: ");
                    double requiredAmount = Convert.ToDouble(Console.ReadLine());

                    if (requiredAmount <= 1000 && requiredAmount > 0)
                    {
                        Console.WriteLine(requiredAmount / requiredCurrencyRate);
                    }
                    else
                    {
                        Console.WriteLine("Amount is not correct!");
                    }
                }

                else if (command == "/exit")
                {
                    Console.WriteLine("Bye-Bye");
                    break;
                }
                else
                {
                    Console.WriteLine("Command not found");
                }
            }
        }

    }
}
