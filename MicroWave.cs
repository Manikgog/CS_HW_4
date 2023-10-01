using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_4
{
    internal class MicroWave : Machine
    {
        protected float internalVolume;
        protected float powerConsumption;

        public MicroWave()
        {
            
        }

        public MicroWave(string purpose, float internalVolume, float powerConsumption, string name) : base(name, purpose)
        {
            this.purpose = purpose;
            this.internalVolume = internalVolume;
            this.powerConsumption=powerConsumption;
        }

        public override void Sound()
        {
            Console.WriteLine("Уввввввввв пи пи пи");
        }

        public float InternalVolume
        {
            get => (float)this.internalVolume;
            set => this.internalVolume = value;
        }

        public float PowerConsumption
        {
            get => this.powerConsumption;
            set => this.powerConsumption = value;
        }
             

        public override void Desc()
        {
            Console.WriteLine("Название: " + this.name +
                "\nНазначение: " + this.purpose +
                "\nПотребляемая мощность (кВт): " + this.powerConsumption +
                "\nВнутренний объём (л.): " + this.internalVolume);
        }
    }
}
