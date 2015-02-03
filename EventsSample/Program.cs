using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventsSample.Events;
using EventsSample.Handlers;
using Ninject;

namespace EventsSample
{
    class Program
    {
        static void Main(string[] args)
        {
            InitIOC();

            Console.WriteLine("Created Handlers");

            DomainEvents.Raise(new UpdatePersonEvent(){Name = "Update Person"});

            Console.ReadKey();

        }

        private static void InitIOC()
        {
            var kernel = new StandardKernel();

            kernel.Bind<IHandle<UpdatePersonEvent>>().To<UpdatePersonHandler>();
            kernel.Bind<IHandle<UpdatePersonEvent>>().To<NotifyEmailHandler>();

            DomainEvents.Kernel = kernel;
        }
    }
}
