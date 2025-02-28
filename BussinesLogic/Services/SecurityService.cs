using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Abstraction;

namespace BussinesLogic.Services
{
    public class SecurityService : IObserver
    {
        public void Update(string subjectType, string message)
        {
            Console.WriteLine($"[Служба безопасности] Получено от {subjectType}: {message}");
            if (subjectType == "Датчик движения")
                Console.WriteLine(">>> Активация сигнализации!");
        }
    }
}
