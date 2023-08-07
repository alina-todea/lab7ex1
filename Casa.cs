using System;
namespace lab7ex1
{
    public class Casa: CashPay, IPos
    {
        double SoldCasa { get; set; } = 0;
        double SumaDeIncasat{ get; set; } = 0;
        Pos pos;
        bool success = false;

        public Casa(double amount, Pos pos)
        {
            this.SumaDeIncasat = amount;
            this.pos = pos;
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
        public void PrintBill(double sumaPlatita, double sumadeIncasat)
        {
            Console.WriteLine("==========");
            Console.WriteLine($"Chitanta \n Total de plata:  {sumadeIncasat}\n Suma incasata: {sumaPlatita} \n Rest de plata {sumaPlatita-sumadeIncasat} \n Data: {DateTime.UtcNow}\n Metoda de plata: cash");
            Console.WriteLine("==========");

        }
        /// <summary>
        /// adaugare siuma in seif
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public bool AddToSeif(double amount)
        {
            var amountForSeif = amount - SumaDeIncasat;
            if (amountForSeif < 0)
            {
                return false;
            }
            else
            {
                SoldCasa += amount;
                Console.WriteLine($"Adaugat in seif: {SumaDeIncasat}.");
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
                PrintBill(amount, SumaDeIncasat);
                success = true;
            }
            else
            {
                Console.WriteLine("Suma platita <=0");
            }
            CloseSeif();
         
        }

        /// <summary>
        /// cere plata
        /// </summary>
        /// 
        public void RequestPayment()
        {
            Console.WriteLine($"Suma de plata: {SumaDeIncasat} cash sau card?");
            pos.Amount = this.SumaDeIncasat;
        }

        /// <summary>
        /// confirma incasarea
        /// </summary>
        /// <param name="paymentMethod"></param>
        /// <param name="success"></param>
        public void ConfirmPayment(string paymentMethod, bool success)
        {
            if (success)
                Console.WriteLine($"{paymentMethod}: plata efectuata cu succes.");
            else

                Console.WriteLine($"{paymentMethod}: Contactati banca.");
        }

    }
}
