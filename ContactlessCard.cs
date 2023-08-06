using System;
namespace lab7ex1
{
    public class ContactlessCard:Card, IContactlessPay, IContactfulPay
    {
        public ContactlessCard(int Sold) : base(Sold)
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
        /// inswereaza cardul
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
