using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_4
{
    internal class Product
    {
        private string name;
        private Money price;
        public Product() 
        {
            this.name = "";
            this.price = new Money();
        }

        public Product(string name, Money price)
        {
            this.name=name;
            this.price=price;
        }

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        public Money Price
        {
            get => this.price;
            set => this.price = value;
        }

        public void IncreasePrice(int number)
        {
            Money increment = new Money(number);
            this.price += increment;
        }

        public void IncreasePrice(float number)
        {
            Money increment = new Money((int)number, (int)((number - (int)number)*100));
            this.price += increment;
        }

        public void IncreasePrice(double number)
        {
            Money increment = new Money((int)number, (int)((number - (int)number)*100));
            this.price += increment;
        }

        public void DecreasePrice(int number)
        {
            Money increment = new Money(number);
            this.price -= increment;
        }

        public void DecreasePrice(float number)
        {
            Money increment = new Money((int)number, (int)((number - (int)number)*100));
            this.price -= increment;
        }

        public void DecreasePrice(double number)
        {
            Money increment = new Money((int)number, (int)((number - (int)number)*100));
            this.price -= increment;
        }


        public override string ToString()
        {
            return this.name + ": " + this.price.ToString();
        }

    }
}
