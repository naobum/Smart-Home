using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesLogic.Controllers;
using BussinesLogic.Services;
using Domain;
using Domain.Models;

namespace Smart_Home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lamp = new Light();
            var coloredlamp = new ColorDeviceDecorator(lamp);
            coloredlamp.ColoredOn(ConsoleColor.Yellow);
            coloredlamp.TurnOff();
            var scheduledLamp = new TimeDeviceDecorator(lamp);
            scheduledLamp.ScheduleOn(new TimeSpan(17, 30, 0));
            scheduledLamp.ScheduleOff(new TimeSpan(18, 30, 0));

            // Создаем датчики
            var motionSensor = new MotionSensor();
            var doorSensor = new DoorSensor();

            // Создаем сервисы-наблюдатели
            var security = new SecurityService();
            var lights = new LightingController();

            // Подключаем наблюдателей к датчикам
            motionSensor.Attach(security);
            motionSensor.Attach(lights);

            doorSensor.Attach(security);

            // Симулируем события
            Console.ReadKey();
            motionSensor.DetectMotion();
            Console.ReadKey();
            doorSensor.DoorOpened();

            // Отключаем один из наблюдателей
            motionSensor.Detach(lights);
            Console.WriteLine("\n--- Отключен контроллер света ---");

            // Новое событие
            motionSensor.DetectMotion();
        }
    }
}
