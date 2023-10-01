using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_4
{
    internal class Steamboat : Machine
    {
        protected float displacement;
        protected int capacityOfPeople;
        protected float maxSpeed;

        public Steamboat() { }

        public Steamboat(float displacement, int capaciteOfPeople, float maxSpeed,
                            string name, string purpose) : base(name, purpose)
        {
            this.displacement = displacement;
            this.capacityOfPeople = capaciteOfPeople;
            this.maxSpeed = maxSpeed;
        }

        public override void Sound()
        {
            Console.WriteLine("УУУУУУУУУУ УУУУУУУУ УУУУУУУУУ !!");
        }

        public float Displacement
        {
            get => displacement;
            set => displacement = value;
        }

        public int CapacityOfPeople
        {
            get => capacityOfPeople;
            set => capacityOfPeople = value;
        }

        public float MaxSpeed
        {
            get => maxSpeed;
            set => maxSpeed = value;

        }

        public override void Desc()
        {
            Console.WriteLine("Название: " + this.name +
                "\nНазначение: " + this.purpose +
                "\nВодоизмещение (т.): " + this.displacement+
                "\nВместимость (чел.): " + this.capacityOfPeople +
                "\nМаксимальная скорость (км/ч): " + this.maxSpeed);
        }
    }
}
