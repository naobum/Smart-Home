using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Abstraction;

namespace BussinesLogic.Controllers
{
    public class LightingController : IObserver
    {
        public void Update(string subjectType, string message)
        {
            Console.WriteLine($"[Контроллер света] Получено от {subjectType}: {message}");
            if (subjectType == "Датчик двери")
                Console.WriteLine(">>> Включение света в коридоре");
        }
    }
}
