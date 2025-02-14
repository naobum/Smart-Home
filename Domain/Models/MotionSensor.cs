using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Abstraction;

namespace Domain.Models
{
    public class MotionSensor : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        public void Attach(IObserver observer)
        {
            Console.WriteLine($"Датчик: Подключен наблюдатель {observer.GetType().Name}");
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            Console.WriteLine($"Датчик: Отключен наблюдатель {observer.GetType().Name}");
            _observers.Remove(observer);
        }

        public void Notify(string message)
        {
            foreach (var observer in _observers)
                observer.Update("Датчик движения", message);
        }
        public void DetectMotion()
        {
            Console.WriteLine("\nДатчик движения: Обнаружено движение!");
            Notify("Обнаружено движение в зоне датчика");
        }
    }
}
