using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thermostat
{
    class Thermostat
    {
        private int min;
        private int max;

        public int Min
        {
            get
            {
                return min;
            }
            set
            {
                min = value;
            }
        }

        public int Max
        {
            get
            {
                return max;
            }
            set
            {
                max = value;
            }
        }

        public Thermostat(int min, int max)
        {
            Min = min;
            Max = max;
        }

        public void SetTemp(int t)
        {
            if(t < Min)
            {
                throw new System.ArgumentException("Temperature is too cold!");
            }
            else if(t > Max)
            {
                throw new System.ArgumentException("Temperature is too hot!");
            }
            else
            {
                Console.WriteLine("\nTemperature is OK!");
            }
        } 

        public TemperatureOutofRange(int t)
        {
            if (t > Max)
            {

            }

        }
    }
}
