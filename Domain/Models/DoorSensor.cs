using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Abstraction;

namespace Domain.Models
{
    public class DoorSensor : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(string message)
        {
            foreach (IObserver observer in _observers)
                observer.Update("Датчик двери", message);
        }
        public void DoorOpened()
        {
            Console.WriteLine("\nДатчик двери: Дверь открыта!");
            Notify("Основная дверь была открыта");
        }
    }
}
