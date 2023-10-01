using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_4
{
    abstract class Machine
    {
        protected string name;
        protected string purpose;

        public Machine() { }
        public Machine(string name, string purpose) 
        {
            this.name = name;
            this.purpose = purpose;
        }

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }
        public string Purpose
        {
            get => this.purpose;
            set => this.purpose = value;
        }

        public abstract void Sound();
        public abstract void Desc();

        public void Show()
        {
            Console.WriteLine(this.name);
        }

    }
}
