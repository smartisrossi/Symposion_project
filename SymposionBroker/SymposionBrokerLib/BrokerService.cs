using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SymposionBrokerLib
{
    public class BrokerService : IBroker
    {
        private readonly string _serverLog = "http://localhost:8002/SymposionGestoreSicurezza/GestoreSicurezzaService/";
        private readonly string _serverUtente = "http://localhost:8000/SymposionUtente/UtenteService/";
        private readonly string _serverAmministratore = "http://localhost:8003/SymposionAmministratore/AmministratoreService/";
        private ILogin _loginController = new LoginController();
        private IIscrizione _iscrizioneController = new IscrizioneController();

        public string GestisciIscrizione(string username, string passwd, string mail, string role)
        {
            try
            {
                _iscrizioneController.RegistraDati(username, passwd, mail);
                return _serverUtente;
            }
            catch (Exception e)
            {
                throw new FaultException<AccessFault>(new AccessFault(e.Message));
            }
        }

        public string GestisciLogin(string username, string passwd, string role)
        {
            try
            {
                string roleResult = _loginController.VerificaCredenziali(username, passwd);
                if (roleResult.Equals(role))
                {
                    if (roleResult.Equals("amministratore"))
                        return _serverAmministratore;
                    else if (roleResult.Equals("utente"))
                        return _serverUtente;
                    else if (roleResult.Equals("gestoreSicurezza"))
                        return _serverLog;
                    else
                        return null;
                }
                else
                    return null;
            }
            catch(Exception e)
            {
                throw new FaultException<AccessFault>(new AccessFault(e.Message));
            }
        }
    }
}
