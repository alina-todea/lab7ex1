using System;
namespace lab7ex1
{
    public class Card 
    {
        protected double Sold { get; set; } = 0;
        
        public Card(int sold)
        {
            this.Sold = sold;
        }

    }
}