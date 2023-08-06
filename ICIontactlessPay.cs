using System;
namespace lab7ex1
{
    public interface IContactlessPay
    {
        public void TapCard();
        public bool Pay(double amount);

    }
}
