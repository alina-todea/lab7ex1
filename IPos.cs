using System;
namespace lab7ex1
{
    public interface IPos
    {

        public void RequestPayment();


        public void ConfirmPayment(double paidAmount);
        
    }
}
