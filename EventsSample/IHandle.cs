using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsSample
{
    public interface IHandle<T> where T : IDomainEvent
    {
        void Handle(T args);

    }

    public interface IDomainEvent
    {
        DateTime DateOccurred { get; } 
    }
}
