using System;
namespace lab7ex1
{
    public class Phone:Card, IContactlessPay
    {
        public Phone(int Sold) : base(Sold)
        {
        }
        /// <summary>
        /// apropie cardul
        /// </summary>
        public void TapCard()
        {
            Console.WriteLine("Card read");

        }
       
        /// <summary>
        /// face plata
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public bool Pay(double amount)
        {

            if (Sold >= amount)
            {
                this.Sold -= amount;
                return true;
            }
            else
                return false;
        }

    }
}
