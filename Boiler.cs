using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_4
{
    internal class Boiler : Machine
    {
        
        protected float waterVolume;
        protected float powerConsumption;

        public Boiler()
        {
            
        }

        public Boiler(string purpose, float waterVolume, float powerConsumption, string name) : base(name, purpose)
        {
            this.purpose=purpose;
            this.waterVolume=waterVolume;
            this.powerConsumption=powerConsumption;
        }

        public override void Sound()
        {
            Console.WriteLine("шшшшшшшш буль буль буль шшшшшшшш");
        }

        public float WaterVolume
        {
            get => (float)this.waterVolume;
            set => this.waterVolume = value;
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
                "\nОбъём воды (л.): " + this.waterVolume);
        }



    }
}
