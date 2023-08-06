using System;
namespace lab7ex1
{
    public interface IContactfulPay 
    {


        public void InsertCard();
        public bool Pay(double amount);
        public void RemoveCard();
     
    }
}
