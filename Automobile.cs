using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_4
{
    internal class Automobile : Machine
    {
        private float enginePower;
        private float engineVolume;
        private float maxSpeed;

        public Automobile() { }

        public Automobile(float enginePower, float engineVolume, float maxSpeed,
                            string name, string purpose) : base(name, purpose)
        {
            this.enginePower = enginePower;
            this.engineVolume = engineVolume;
            this.maxSpeed = maxSpeed;
        }

        public override void Sound()
        {
            Console.WriteLine("уррр - р - р - р !!");
        }

        public float EnginePower
        {
            get => enginePower;
            set => enginePower = value;
        }

        public float EngineVolume
        {
            get => engineVolume;
            set => engineVolume = value;
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
                "\nМощность двигателя (л.с.): " + this.enginePower +
                "\nОбъём цилиндров (л.): " + this.engineVolume +
                "\nМаксимальная скорость (км/ч): " + this.maxSpeed);
        }


    }
}
