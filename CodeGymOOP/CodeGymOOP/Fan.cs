using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOOP
{
    internal class Fan
    {
        public const int SLOW = 1;
        public const int MEDIUM = 2;
        public const int FAST = 3;

        // Các trường dữ liệu
        private int speed = SLOW; 
        private bool on = false;  
        private double radius = 5; 
        private string color = "blue"; 

        // Getter và Setter
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public bool On
        {
            get { return on; }
            set { on = value; }
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        
        public Fan() { }

        
        public override string ToString()
        {
            if (on)
            {
                return $"Fan is on: Speed = {speed}, Color = {color}, Radius = {radius}";
            }
            else
            {
                return $"Fan is off: Color = {color}, Radius = {radius}";
            }
        }
    }
}
