using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventsSample.Events;

namespace EventsSample.Handlers
{
    public class UpdatePersonHandler : IHandle<UpdatePersonEvent>
    {
        public void Handle(UpdatePersonEvent args)
        {
            Console.WriteLine("Update person event handled!");
        }
    }
}
