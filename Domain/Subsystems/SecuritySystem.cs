using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Subsystems
{
    public class SecuritySystem
    {
        public void Arm() => Console.WriteLine("Охрана активирована");
        public void Disarm() => Console.WriteLine("Охрана отключена");
    }
}
