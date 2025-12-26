using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Practice
{
    public enum TrafficLight
    {
        //Default Value
        Red, //0
        Green, //1
        Yellow //2
    }
    class Program
    {
        public static int GetLightDuration(TrafficLight light)
        {
            switch (light)
            {
                case TrafficLight.Red:
                    return 15;
                case TrafficLight.Green:
                    return 10;
                case TrafficLight.Yellow:
                    return 5;
                default:
                    return 0;

            }
        }
        public static TrafficLight NextLight(TrafficLight currentLight)
        {
            switch(currentLight)
            {
                case TrafficLight.Red: return TrafficLight.Green;
                case TrafficLight.Green: return TrafficLight.Yellow;
                case TrafficLight.Yellow: return TrafficLight.Red;
                default: return TrafficLight.Red;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Set a Traffic Light(Red/Yellow/Green): ");
            string setLight = Console.ReadLine();
            int light;
            if (setLight.ToLower() == "red") light = (int)TrafficLight.Red;
            else if (setLight.ToLower() == "green") light = (int)TrafficLight.Green;
            else light = (int)TrafficLight.Yellow;
            for (int i=0; i<=10; i++)
            {
                Console.WriteLine(NextLight((TrafficLight)light) + " Duration Time : " + GetLightDuration((TrafficLight)light));
                light++;
                light = light % 3;
            }
            //Console.WriteLine((int)TrafficLight.Yellow);
            Console.ReadKey();
        }
    }
}
