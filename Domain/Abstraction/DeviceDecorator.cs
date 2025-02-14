﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstraction
{
    public abstract class DeviceDecorator : IDevice
    {
        protected IDevice _device;
        
        public DeviceDecorator(IDevice device) =>
            _device = device;
        
        public virtual void TurnOn() =>
            _device.TurnOn();
        
        public virtual void TurnOff() =>
            _device.TurnOff();

    }
}
