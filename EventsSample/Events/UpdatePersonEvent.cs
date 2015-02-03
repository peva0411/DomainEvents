using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsSample.Events
{
    public class UpdatePersonEvent : IDomainEvent
    {
        public DateTime DateOccurred { get; private set; }

        public string Name { get; set; }

        public UpdatePersonEvent()
        {
            DateOccurred = DateTime.Now;
        }
    }
}
