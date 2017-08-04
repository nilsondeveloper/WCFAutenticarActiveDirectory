using System;
using System.DirectoryServices;
using WCFAutenticarAD.Host.Contract;

namespace WCFAutenticarAD.Host.Application
{
    public class ActiveDirectoryApp : IActiveDirectoryApp
    {
        public Retorno Autenticar(string dominio, string usuario, string senha)
        {
            var retorno = new Retorno(); 

            try
            {
                var directoryEntry = new DirectoryEntry("LDAP://" + dominio, usuario, senha);
                var sirectorySearcher = new DirectorySearcher(directoryEntry)
                {
                    Filter = "(SAMAccountName=" + usuario + ")",
                    PropertiesToLoad = { "cn" }
                };

                retorno.Autenticado = sirectorySearcher.FindOne() != null;
            }
            catch (Exception ex)
            {
                retorno.MensagemErro = "Exception: " + ex.Message;
                retorno.Autenticado = false;
            }

            return retorno;
        }
 
    }
}