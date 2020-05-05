using System.ServiceModel;

namespace EduardoSelfHost.Contracts
{
    [ServiceContract]
    public interface IPesquisaDolar 
    {
        [OperationContract]
        PesquisaDolar PesquisarDolar();
    }
}
