using System;

namespace Change_Desk
{
    class Program
    {
        static void Main(string[] args)
        {
            var toCurrency = Console.ReadLine();
            var euro = double.Parse(Console.ReadLine());

            var minRippleAccount = 80.0;
            var minBtcAccount = 0.001;
            var minEthAccount = 0.0099;

            var xrpToEur = 0.22;
            var btcToEur = 6400.0;
            var ethToEur = 250;


            if(euro > 1000)
            {
                euro *= 1.10;
            }

            switch (toCurrency)
            {
                case "XRP":
                    {
                        var rippleCoins = euro / xrpToEur;
                        if(rippleCoins < minRippleAccount)
                        {
                            Console.WriteLine("Insufficient funds");
                            break;
                        }
                        if (rippleCoins > 1000 && rippleCoins < 2500)
                        {
                            rippleCoins *= 1.05;
                        }
                        else if(rippleCoins >= 2500)
                        {
                            rippleCoins *= 1.10;
                        }
                        Console.WriteLine($"Successfully purchased {rippleCoins:F3} XRP");
                        break;
                    }
                case "BTC":
                    {
                        var bitcoinCoins = euro / btcToEur;
                        if(bitcoinCoins < minBtcAccount)
                        {
                            Console.WriteLine("Insufficient funds");
                            break;
                        }
                        if (bitcoinCoins > 10)
                        {
                            bitcoinCoins *= 1.02;
                        }
                        Console.WriteLine($"Successfully purchased {bitcoinCoins:F3} BTC");
                        break;
                    }
                case "ETH":
                    {
                        var ethereumCoins = euro / ethToEur;
                        if(ethereumCoins < minEthAccount)
                        {
                            Console.WriteLine("Insufficient funds");
                            break;
                        }
                        Console.WriteLine($"Successfully purchased {ethereumCoins:F3} ETH");
                        break;
                    }
                default: { Console.WriteLine($"EUR to {toCurrency} is not supported."); break; }
            }
        }
    }
}
