using System.ServiceModel;

namespace WCFAutenticarAD.Host.Contract
{
    [ServiceContract]
    public interface IActiveDirectoryApp
    {
        [OperationContract]
        Retorno Autenticar(string dominio, string usuario, string senha);
    }
}