﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_DesignPattern.Interfaces
{
    internal interface IObserver
    {
        void Update(ISubject subject);
    }
}
