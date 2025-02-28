using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Subsystems
{
    public class ClimateControl
    {
        public void SetTemperature(int temp) =>
        Console.WriteLine($"Установлена температура: {temp}°C");
    }
}
