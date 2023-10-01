using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_4
{
    internal class Money
    {
        private long rub;
        private byte kop;

        private void Normalize(long kop)    // метод для нормализации величины суммы копеек при передаче суммы большей чем 99 копеек
        {
            if (kop >= 100)
            {
                this.rub += kop/100;
                this.kop += (byte)(kop%100);
                if(this.kop >= 100)
                {
                    this.rub += this.kop/100;
                    this.kop = (byte)(this.kop%100);
                }
            }
            else
            {
                this.kop += (byte)kop;
                if (this.kop >= 100)
                {
                    this.rub += this.kop/100;
                    this.kop = (byte)(this.kop%100);
                }
            }
        }

        public Money()
        {
            this.rub = 0;
            this.kop = 0;
        }



        public Money(long rub, byte kop)
        {
            this.rub = rub;
            Normalize(kop);
        }

        public Money(long rub, int kop)
        {
            this.rub = rub;
            Normalize(kop);
        }

        public Money(long rub)
        {
            this.rub = rub;
        }

        public long Rub
        {
            get => this.rub;
            set
            {
                this.rub = value;
            }
        }

        public byte Kop
        {
            get => this.kop;
            set
            {
                Normalize(value);
            }
        }

        public override string ToString()
        {
            return this.rub + " р. " + this.kop + " коп.";
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }

        public static Money operator +(Money m1, Money m2)
        {
            Money result = new Money(m1.rub + m2.rub, m1.kop + m2.kop);
            return result;
        }

        public static Money operator -(Money m1, Money m2)
        {
            Money result = new Money(m1.rub - m2.rub, m1.kop - m2.kop);
            return result;
        }

        public static bool operator ==(Money m1, Money m2) 
        {
            return m1.rub == m2.rub && m1.kop == m2.kop;
        }

        public static bool operator !=(Money m1, Money m2)
        {
            return m1.rub != m2.rub || m1.kop != m2.kop;
        }

        public static bool operator >(Money m1, Money m2)
        {
            if(m1.rub > m2.rub)
            {
                return true;
            }else if(m1.rub == m2.rub && m1.kop > m2.kop)
            {
                return true;
            }
            return false;
        }

        public static bool operator <(Money m1, Money m2)
        {
            if (m1.rub < m2.rub)
            {
                return true;
            }
            else if (m1.rub == m2.rub && m1.kop < m2.kop)
            {
                return true;
            }
            return false;
        }

    }
}
