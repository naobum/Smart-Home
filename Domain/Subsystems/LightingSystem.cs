using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Subsystems
{
    public class LightingSystem
    {
        public void TurnOnAll() => Console.WriteLine("Весь свет включён");
        public void TurnOffAll() => Console.WriteLine("Весь свет выключен");
        public void DimAll(int percent) => Console.WriteLine($"Яркость света: {percent}%");
    }
}
