using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thermometer
{
    internal class ThermoCalculate
    {
        private double _baseValue;

        public double Celsius
        {
            get {  return Math.Round((_baseValue - 32) * 5 / 9, 2); }
            set { _baseValue = value; }
        }

        public double Fahrenheit
        {
            get { return Math.Round(_baseValue * 9 / 5 + 32, 2); }
            set { _baseValue = value; }
        }

        public double ThermoTransfer(bool isCelsius, double value)
        {
            if (isCelsius)
            {
                Celsius = value;
                return Fahrenheit;
            }
            else
            {
                Fahrenheit = value;
                return Celsius;
            }
        }
    }
}
