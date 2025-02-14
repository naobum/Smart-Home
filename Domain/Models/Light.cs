using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Abstraction;
using Domain.Models;

namespace Domain.Models
{
    public class Light : IDevice
    {
        public void TurnOn() 
        {
            Console.WriteLine("Лампа включена");
        }
        public void TurnOff() 
        {
            Console.WriteLine("Лампа выключена");
        }
    }
}
