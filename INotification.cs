using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public interface INotification
    {
        public void Notify(string message);
    }
}