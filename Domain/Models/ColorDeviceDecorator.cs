using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Abstraction;

namespace Domain.Models
{
    public class ColorDeviceDecorator : DeviceDecorator
    {
        public ColorDeviceDecorator(IDevice device) : base(device) { }

        public void ColoredOn(ConsoleColor color)
        {
            Console.ForegroundColor = color;
            base.TurnOn();
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
