using System;

namespace EduardoSelfHost.Contracts
{

    public class PesquisaDolarService : IPesquisaDolar
    {
        public PesquisaDolar PesquisarDolar()
        {
            return new PesquisaDolar() { Data = DateTime.Now, Valor = "5.75" };
        }
    }
}
