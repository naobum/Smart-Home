using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Domain.Models;

namespace Smart_Home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lamp = new Light();
            var coloredlamp = new ColorDeviceDecorator(lamp);
            coloredlamp.ColoredOn(ConsoleColor.Yellow);
            coloredlamp.TurnOff();
            var scheduledLamp = new TimeDeviceDecorator(lamp);
            scheduledLamp.ScheduleOn(new TimeSpan(17, 30, 0));
            scheduledLamp.ScheduleOff(new TimeSpan(18, 30, 0));

        }
    }
}
