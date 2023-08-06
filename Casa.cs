using System;
namespace lab7ex1
{
    public class Casa: CashPay
    {
        double SoldCasa { get; set; } = 0;
        public Casa()
        {
        }
        /// <summary>
        /// deschidere seif
        /// </summary>
        public void OpenSeif()
        {

        Console.WriteLine("Casa de marcat deschisa");   

        }
        /// <summary>
        /// inchidere seif
        /// </summary>
        public void CloseSeif()
        {

            Console.WriteLine("Casa de marcat inchisa");

        }
        /// <summary>
        /// tiparire chitanta
        /// </summary>
        /// <param name="amount"></param>
        public void PrintBill(double amount)
        {
            Console.WriteLine("==========");
            Console.WriteLine($"Chitanta \n Suma incasata: {amount} \n Data: {DateTime.UtcNow}\n Metoda de plata: cash");
            Console.WriteLine("==========");

        }
        /// <summary>
        /// adaugare siuma in seif
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public bool AddToSeif(double amount)
        {
            if (amount < 0)
            {
                return false;
            }
            else
            {
                SoldCasa += amount;
                Console.WriteLine($"Incasat Cash: {amount}.");
                return true;
            }

        }
        /// <summary>
        /// Procesare plata cash
        /// 1. va deschide un seif
        ///2. va introduce suma in seif
        ///3. va inchide seif-ul
        ///4. Va elibera chitanta
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public void ProcessSaleCash( double amount) 
        {

            OpenSeif();
            
            if (AddToSeif(amount))
            {
                PrintBill(amount);
            }
            else
            {
                Console.WriteLine("Suma platita <=0");
            }
            CloseSeif();
         
        }
    }
}
