using System;
namespace lab7ex1
{
    public class ContactfulCard:Card, IContactfulPay
    {
        public ContactfulCard(int Sold): base(Sold)
        { 
        }

        /// <summary>
        /// insereaza cardul
        /// </summary>
        public void InsertCard()
        {
            Console.WriteLine("Card inserted");

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
       
        /// <summary>
        /// scoate cardul
        /// </summary>
        public void RemoveCard()
        {
            Console.WriteLine("Card removed");

        }
      
    }
}
