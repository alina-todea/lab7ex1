using System;
namespace lab7ex1
{
    public class Pos
    {
        public double Amount { get; set; } = 0;

        public Pos(double amount)
        { 
            this.Amount = amount;
        }
        /// <summary>
        /// cere plata
        /// </summary>
        /// 
        public void RequestPayment()
        {
            Console.WriteLine($"Suma de plata: {Amount}");
        }

        /// <summary>
        /// proceseaza plata contactful
        /// </summary>
        /// <param name="paymentMethod"></param>
        /// <returns></returns>
        public bool ProcessSaleCard(IContactfulPay paymentMethod)
        {
            paymentMethod.InsertCard();
            bool success = paymentMethod.Pay(Amount);
            paymentMethod.RemoveCard();
            return success;
        }
        /// <summary>
        /// proceseaza plata contactless
        /// </summary>
        /// <param name="paymentMethod"></param>
        /// <returns></returns>
        public bool ProcessSaleCard(IContactlessPay paymentMethod)
        {
            paymentMethod.TapCard();
            return paymentMethod.Pay(Amount);
        }

        public void ConfirmPayment(string paymentMethod, bool success)
        {
            if (success)
                Console.WriteLine($"{paymentMethod}: plata efectuata cu succes.");
            else

                Console.WriteLine($"{paymentMethod}: Contactati banca.");
        }
    }
}
