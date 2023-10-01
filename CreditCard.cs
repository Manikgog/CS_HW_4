using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_4
{
    internal class CreditCard
    {
        private Money money;

        public CreditCard()
        {
            this.money = new Money();
        }

        public CreditCard(Money money)
        {
            this.money=money;
        }

        public CreditCard(long rub, byte kop)
        {
            this.money = new Money(rub, kop);
        }

        public CreditCard(CreditCard card)
        {
            this.money = new Money(card.money.Rub, card.money.Kop);
        }

        public override string ToString()
        {
            return "Всего денег на счёте: " + this.money.ToString();
        }

        public static CreditCard operator +(CreditCard creditCard, Money money)
        {
            creditCard.money = creditCard.money + money;
            return creditCard;
        }

        public static CreditCard operator -(CreditCard creditCard, Money money)
        {
            creditCard.money = creditCard.money - money;
            return creditCard;
        }

        public static bool operator ==(CreditCard c1, CreditCard c2)
        {
            return c1.money == c2.money;
        }

        public static bool operator !=(CreditCard c1, CreditCard c2)
        {
            return c1.money != c2.money;
        }

        public static bool operator >(CreditCard c1, CreditCard c2)
        {
            return c1.money > c2.money;
        }

        public static bool operator <(CreditCard c1, CreditCard c2)
        {
            return c1.money < c2.money;
        }

    }
}
