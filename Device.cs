using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempClassLibrary
{
    public class Device
    {
        private float temp;
        private float humidity;
        public float Temp
        {
            get { return temp; }
            set { temp = value; }
        }
        public float Humidity
        {
            get { return humidity; }
            set { humidity = value; }
        }
        public Device(float temp, float humidity)
        {
            Temp = temp;
            Humidity = humidity;
        }
    }
}
