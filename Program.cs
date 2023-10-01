using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task_1();
            Task_2();
            Task_3();
        }

        static void Task_1()
        {
                /*Запрограммируйте класс Money (объект класса оперирует одной валютой) для работы с деньгами.
            В классе должны быть предусмотрены поле для хранения целой части денег (доллары, евро, гривны и 
            т.д.) и поле для хранения копеек (центы, евроценты, копейки и т.д.). Реализовать методы для вывода 
            суммы на экран, задания значений для частей. На базе класса Money создать класс Product для работы
            с продуктом или товаром. Реализовать метод, позволяющий уменьшить цену на заданное число.
            Для каждого из классов реализовать необходимые
            методы и поля.*/
            Money m1 = new Money(25, 40);       // создаём объект m1
            Console.WriteLine(m1.ToString());   // вывод на экран объекта m1
            Money m2 = new Money(30, 20);       // создаём объект m2
            Console.WriteLine(m2.ToString());   // вывод на экран объекта m2
            Money m3 = m1 + m2;                 // сложение объектов Money
            Console.WriteLine(m3.ToString());   // вывод на экран объекта m3
            m3 = m3 - m2;                       // вычитание объектов Money
            m3.Print();                         // вывод на печать объекта m3

            Product bread = new Product("Бородинский", m1);     // создание объекта Product
            Console.WriteLine(bread.ToString());                // вывод на печать объекта bread
            bread.IncreasePrice(5.25);                          // вызов метода увеличение цены

            Console.WriteLine(bread.ToString());                // вывод на печать объекта bread

            bread.DecreasePrice(5.25);                          // вызов метода уменьшения цены
            Console.WriteLine(bread.ToString());                // вывод на печать объекта bread
        }

        static void Task_2()
        {
            /*Создать базовый класс «Устройство» и производные
        классы «Чайник», «Микроволновка», «Автомобиль», «Пароход». 
        С помощью конструктора установить имя каждого
        устройства и его характеристики.
        Реализуйте для каждого из классов методы:
        ■ Sound — издает звук устройства (пишем текстом в
        консоль);
        ■ Show — отображает название устройства;
        ■ Desc — отображает описание устройства*/
            Boiler boiler = new Boiler("для кипячения воды", 1.5F, 2F, "чайник");
            boiler.Desc();
            Console.Write("Звук: ");  boiler.Sound();
            Console.WriteLine();

            MicroWave microWave = new MicroWave("для приготовления и разогревания пищи", 5.5F, 2.3F, "микроволновая печь");
            microWave.Desc();
            Console.Write("Звук: "); microWave.Sound();
            Console.WriteLine();

            Automobile automobile = new Automobile(148F, 2F, 160, "автомобиль", "для перевозки людей по дорогам");
            automobile.Desc();
            Console.Write("Звук: "); automobile.Sound();
            Console.WriteLine();

            Steamboat steamboat = new Steamboat(1500F, 400, 40, "пароход", "для перевозки людей по воде" );
            steamboat.Desc();
            Console.Write("Звук: "); steamboat.Sound();
            Console.WriteLine();
        }

        static void Task_3()
        {
            /*
                 Создайте класс CreditCard. Добавьте к уже созданному классу
            информацию о сумме денег на карте. Выполните перегрузку + (для
            увеличения суммы денег на указанную величину), - (для уменьшения 
            суммы денег на указанную величину), == (проверка на равенство СVC кода), 
            и < и > (проверка на меньше или больше суммы денег).
            */
            CreditCard card = new CreditCard(34, 25);
            Console.WriteLine(card.ToString());
            Money m1 = new Money(25, 40);
            card = card + m1;                           // выполнение сложения счёта карты с суммой денег m1
            Console.WriteLine(card.ToString());

            card = card - m1;                           // выполнение вычитания из счёта карты суммы денег m1
            Console.WriteLine(card.ToString());

            CreditCard card2 = new CreditCard(card);
            CreditCard card3 = new CreditCard(34, 24);

            Console.WriteLine("Кредитная карта №1 -" + card.ToString());
            Console.WriteLine("Кредитная карта №2 -" + card2.ToString());
            Console.WriteLine("Кредитная карта №3 -" + card3.ToString());
            Console.WriteLine(card.ToString() + " == " + card2.ToString() + " ? - " + (card == card2)); // сравнение на равенство двух кредитных карт
            Console.WriteLine(card.ToString() + " == " + card3.ToString() + " ? - " + (card == card3)); // сравнение на равенство двух кредитных карт
            Console.WriteLine(card.ToString() + " > " + card3.ToString() + " ? - " + (card > card3));   // сравнение на больше двух кредитных карт
            Console.WriteLine(card.ToString() + " < " + card3.ToString() + " ? - " + (card < card3));   // сравнение на больше двух кредитных карт

        }
    }
}
