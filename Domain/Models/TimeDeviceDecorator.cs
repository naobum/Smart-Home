using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Abstraction;

namespace Domain.Models
{
    public class TimeDeviceDecorator : DeviceDecorator
    {
        public TimeDeviceDecorator(IDevice device) : base(device) { }

        public void ScheduleOn(TimeSpan time) 
        {
            Console.WriteLine($"Включение по расписанию в {time}");
        }
        public void ScheduleOff(TimeSpan time) 
        {
            Console.WriteLine($"Выключение по расписанию в {time}");
        }
    }
}
