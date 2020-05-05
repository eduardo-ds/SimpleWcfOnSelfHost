using EduardoSelfHost.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EduardoSelfHost.SelfHost.ConsoleApp.Entities
{
    public class Startup
    {
        readonly System.Timers.Timer _timer;
        ServiceHost host;

        public Startup()
        {
            _timer = new System.Timers.Timer( /* ConverterMinToMiliseconds(1) */ ) { AutoReset = false };
            _timer.Elapsed += (sender, eventArgs) => Run();
        }

        public void Start()
        {
            _timer.Start();
        }

        public void Stop()
        {
            host.Close();
            Console.WriteLine("Serviço parando...");
            _timer.Stop();
        }

        public void Run()
        {
            host = new ServiceHost(typeof(PesquisaDolarService));
            host.Open();
            Console.WriteLine("Serviço rodando...");
        }

        public double ConverterMinToMiliseconds(double valor)
        {
            return valor * 60000;
        }
    }
}
